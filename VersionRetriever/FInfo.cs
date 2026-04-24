using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionRetriever
{
    public class FInfo
    {
        public string FileName { get; set; }
        public FileVersionInfo Info { get; set; }
        public string Hash { get; set; }
        public string Path { get; set; }
        public string RelativePath { get; private set; }
        public string FileWithRelativePath
        {
            get
            {
                return $"{RelativePath}{FileName}";
            }
        }

        private string _basePath;

        public FInfo()
        {

        }

        public FInfo(string fileName, FileVersionInfo info, string hash, string basePath)
        {
            FileName = fileName;
            Info = info;
            Hash = hash;
            _basePath = basePath;

            if (!string.IsNullOrWhiteSpace(FileName) && info != null)
            {
                Path = info.FileName.Substring(0, info.FileName.Length - FileName.Length);

                SetRelativePath(Path, _basePath);
            }

            // Try to get at least some kind of file name.
            if (string.IsNullOrWhiteSpace(FileName) && info != null)
            {
                int index = info.FileName.LastIndexOf(System.IO.Path.DirectorySeparatorChar);
                FileName = info.FileName.Substring(index + 1);
                Path = info.FileName.Substring(0, index + 1);

                SetRelativePath(Path, _basePath);
            }
        }

        private void SetRelativePath(string path, string basePath)
        {
            if (path.StartsWith(basePath))
            {
                string tempo = path.Remove(0, basePath.Length);
                if (tempo.Length > 0 && tempo[0] == System.IO.Path.DirectorySeparatorChar)
                {
                    RelativePath = tempo.Remove(0, 1);
                }
            }
        }
    }
}
