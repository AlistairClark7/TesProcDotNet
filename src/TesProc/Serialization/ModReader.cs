using System;
using System.IO;

namespace TesEdit.Serialization
{
    public class ModReader : IDisposable
    {
        private FileStream _fileStream;

        public ModReader(string path)
        {
            _fileStream = new FileStream(path, FileMode.Open);
        }

        public void Dispose()
        {
            _fileStream.Dispose();
        }
    }
}