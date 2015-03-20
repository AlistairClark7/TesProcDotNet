using System;
using System.IO;

namespace TesEdit.Serialization
{
    public class ModFileStream : IDisposable
    {
        private FileStream _fileStream;

        public ModFileStream(string path)
        {
            _fileStream = new FileStream(path, FileMode.Open);
        }

        public void Dispose()
        {
            _fileStream.Dispose();
        }
    }
}