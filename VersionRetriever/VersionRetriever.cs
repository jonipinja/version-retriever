using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionRetriever
{
    public class VersionRetriever
    {
        private string _path;
        private IDictionary<string, IList<FInfo>> _filesByExtension;

        public bool IsArchive { get; private set; }
        public FInfo ArchiveInfo { get; private set; }
        public IEnumerable<string> Extensions { get; }
        public string ErrorMessage { get; private set; }

        public VersionRetriever(string path, IEnumerable<string> extensions)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentNullException(nameof(path), "Directory cannot be null or empty.");
            }

            _path = path;
            Extensions = extensions ?? throw new ArgumentNullException(nameof(extensions), "Extensions cannot be null or empty.");
            _filesByExtension = new Dictionary<string, IList<FInfo>>();

            DetermineIfArchive(path);
            ArchiveInfo = null;
        }

        public IEnumerable<FInfo> GetFilesByExtension(string extension)
        {
            if (string.IsNullOrWhiteSpace(extension))
            {
                throw new ArgumentNullException(nameof(extension), "File extension cannot be empty or null.");
            }

            if (_filesByExtension != null && _filesByExtension.TryGetValue(extension, out IList<FInfo> files))
            {
                return files;
            }
            else
            {
                return new List<FInfo>();
            }
        }

        /// <summary>
        /// Retrieves file versions from the set folder (and sub-folders).
        /// </summary>
        /// <returns>True if all went fine, false if errors occured. ErrorMessage contains more information about possible error.</returns>
        public bool ReadFileVersions()
        {
            bool retValue = true;

            string tempPath = _path;

            // If archive, extract it before file version retrieving.
            if (IsArchive)
            {
                string tmpPath = ExtractArchive(tempPath);
                if (!string.IsNullOrWhiteSpace(tmpPath))
                {
                    tempPath = tmpPath;
                }
                else // Could not extract the archive.
                {
                    return false;
                }
            }

            using (var sha = new System.Security.Cryptography.SHA256CryptoServiceProvider())
            {
                try
                {
                    // Get file info for archive.
                    if (IsArchive)
                    {
                        FileVersionInfo arfvi = FileVersionInfo.GetVersionInfo(_path);
                        ArchiveInfo = new FInfo(arfvi.InternalName, arfvi, GetHash(_path, sha), _path);
                    }

                    // Go through files by extensions.
                    foreach (string extension in Extensions)
                    {
                        foreach (string f in Directory.EnumerateFiles(tempPath, $"*{extension}", SearchOption.AllDirectories))
                        {
                            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(f);

                            FInfo inf = new FInfo(fvi.InternalName, fvi, GetHash(f, sha), tempPath);

                            if (_filesByExtension.TryGetValue(extension, out IList<FInfo> values))
                            {
                                if (values.FirstOrDefault(x => x.Hash == inf.Hash) == null)
                                {
                                    values.Add(inf);
                                }
                            }
                            else
                            {
                                _filesByExtension.Add(extension, new List<FInfo>() { inf });
                            }
                        }
                    }
                }
                catch (Exception e) when (e is IOException || e is UnauthorizedAccessException || e is ArgumentException)
                {
                    ErrorMessage = GetExceptionErrors(e);
                    retValue = false;
                }
            }
            
            // Zip-archive -> we need to clean up and delete the temp folder.
            if (IsArchive)
            {
                if (Directory.Exists(tempPath))
                {
                    try
                    {
                        Directory.Delete(tempPath, true);
                    }
                    catch (Exception e) when (e is IOException || e is UnauthorizedAccessException || e is DirectoryNotFoundException)
                    {
                        ErrorMessage = $"Could not delete the temp folder where the archive was extracted.{Environment.NewLine}{GetExceptionErrors(e)}";
                    }
                }
            }

            return retValue;
        }

        // Got from: https://stackoverflow.com/questions/13569406/how-should-i-compute-files-hashmd5-sha1-in-c-sharp
        protected virtual string GetHash(string file, System.Security.Cryptography.HashAlgorithm alg)
        {
            using (var fs = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                var hash = alg.ComputeHash(fs);
                var hstr = Convert.ToBase64String(hash);
                return hstr.TrimEnd('=');
            }
        }

        /// <summary>
        /// Determines if the given path is for a zip-archive.
        /// </summary>
        /// <param name="path"></param>
        private void DetermineIfArchive(string path)
        {
            // Check if the path is for archive.
            string ext = Path.GetExtension(path);
            if (!string.IsNullOrWhiteSpace(ext) && ext.ToLowerInvariant() == ".zip")
            {
                IsArchive = true;
            }
            else
            {
                IsArchive = false;
            }
        }

        /// <summary>
        /// Extracts archive to temp path and returns the temp path.
        /// </summary>
        /// <param name="path">Path to zip-file.</param>
        /// <returns>Path to temporary folder where the archive was extracted. Or null if something went wrong.</returns>
        private string ExtractArchive(string zipPath)
        {
            string tmpPath = Path.GetTempPath();
            string tmpFolder = $"{tmpPath}{Path.GetRandomFileName()}";

            int loop = 1;
            bool impossible = false;

            // Generate random folder paths until we find non-existing one.
            while (Directory.Exists(tmpFolder))
            {
                tmpFolder = $"{tmpPath}{Path.DirectorySeparatorChar}{Path.GetRandomFileName()}";

                // Break if not found in 1000 loops.
                if (loop >= 1000)
                {
                    impossible = true;
                    break;
                }
                ++loop;
            }

            // Could not find proper temp folder path.
            if (impossible)
            {
                ErrorMessage = "Could not find proper temp path to extract the archive.";
                return null;
            }

            // Extract the archive.
            try
            {
                ZipFile.ExtractToDirectory(zipPath, tmpFolder);
                return tmpFolder;
            }
            catch (Exception e) when (e is IOException || e is UnauthorizedAccessException || e is NotSupportedException)
            {
                ErrorMessage = GetExceptionErrors(e);

                return null;
            }
        }

        private string GetExceptionErrors(Exception ex)
        {
            string msg = ex.Message;
            Exception e = ex.InnerException;
            while (e != null)
            {
                msg += $"{Environment.NewLine}{e.Message}";
                e = e.InnerException;
            }

            return msg;
        }
    }
}
