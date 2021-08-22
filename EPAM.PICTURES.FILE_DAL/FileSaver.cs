using EPAM.PICTURES.FILE_DAL.INTERFACES;
using System.IO;

namespace EPAM.PICTURES.FILE_DAL
{
    public class FileSaver : IFileSaver
    {
        private string _folderPath;
        public FileSaver(string folderPath)
        {
            _folderPath = folderPath;
        }
        public string Save(Stream stream, string fileName)
        {
            var fileStream = File.Create(_folderPath + fileName);
            stream.Seek(0, SeekOrigin.Begin);
            stream.CopyTo(fileStream);
            fileStream.Close();
            return fileName;
        }
    }
}
