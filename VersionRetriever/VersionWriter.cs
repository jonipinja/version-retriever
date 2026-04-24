using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionRetriever
{
    public class VersionWriter
    {
        private const string _infoRowFormat = "|{0}|{1}|{2}|{3}|";

        public string File { get; }
        public string ErrorMessage { get; private set; }

        public VersionWriter(string file)
        {
            if (string.IsNullOrWhiteSpace(file))
            {
                throw new ArgumentNullException("file", "File cannot be null or empty.");
            }

            File = file;

            // Check extension.
            if (!File.EndsWith(".md"))
            {
                File = $"{File}.md";
            }
        }

        /// <summary>
        /// Writes the fileinfos to a file.
        /// </summary>
        /// <param name="retriever">VersionRetriever containing the fileinfos.</param>
        /// <returns>True on successfull writing, false otherwise.</returns>
        public bool WriteVersions(VersionRetriever retriever)
        {
            return WriteVersions(retriever, string.Empty);
        }

        /// <summary>
        /// Writes the fileinfos to a file.
        /// </summary>
        /// <param name="retriever">VersionRetriever containing the fileinfos.</param>
        /// <param name="releaseNotes">Optional release notes.</param>
        /// <returns>True on successfull writing, false otherwise.</returns>
        public bool WriteVersions(VersionRetriever retriever, string releaseNotes)
        {
            bool returnValue = true;

            try
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(File, false);

                // Header
                file.WriteLine("Generated: " + DateTime.Now.ToLocalTime());
                file.WriteLine("### File versions and hashes:");
                file.WriteLine();

                // Check if we are dealing with archive.
                if (retriever.IsArchive)
                {
                    file.WriteLine($"### Archive");
                    file.WriteLine($"|filename|version|comment|hash|");
                    file.WriteLine($"|:---|:---|:---|:---|");
                    file.WriteLine(_infoRowFormat, retriever.ArchiveInfo.FileName, retriever.ArchiveInfo.Info.FileVersion, retriever.ArchiveInfo.Info.Comments?.Trim('\n', ' ').Replace("\n", "<br />"), retriever.ArchiveInfo.Hash);
                    file.WriteLine();
                }

                // If release notes exists, write them.
                if (!string.IsNullOrWhiteSpace(releaseNotes))
                {
                    file.WriteLine($"### Release notes");
                    file.WriteLine(releaseNotes);
                    file.WriteLine();
                }

                // Write fileinfos by extensions.
                foreach (string extension in retriever.Extensions)
                {
                    // Add dot to the extension.
                    string ext = extension;
                    if (!ext.StartsWith("."))
                    {
                        ext = $".{extension}";
                    }

                    // Get files.
                    IEnumerable<FInfo> files = retriever.GetFilesByExtension(extension).OrderBy(f => f.RelativePath).ThenBy(f => f.FileName);

                    if (files.Any())
                    {
                        file.WriteLine($"### {ext}");
                        file.WriteLine($"|{ext}|version|comment|hash|");
                        file.WriteLine($"|:---|:---|:---|:---|");

                        foreach (FInfo info in files)
                        {
                            file.WriteLine(_infoRowFormat, info.FileWithRelativePath, info.Info.FileVersion, info.Info.Comments?.Replace("\r\n", "<br />").Replace("\n", "<br />"), info.Hash);
                        }

                        file.WriteLine();
                    }
                }

                file.Close();
            }
            catch (Exception e) when (e is UnauthorizedAccessException || e is System.IO.DirectoryNotFoundException || e is System.IO.IOException)
            {
                ErrorMessage = GetExceptionErrors(e);
                returnValue = false;
            }

            return returnValue;
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
