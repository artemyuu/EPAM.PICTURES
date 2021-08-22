using EPAM.PICTURES.FILE_DAL.INTERFACES;
using EPAM.PICTURES.BLL.INTERFACES;
using EPAM.PICTURES.FILE_DAL;
using EPAM.PICTURES.FILE_DAL.INTERFACES;
using System;
using System.Web;

namespace EPAM.PICTURES.BLL
{
    public class FileSaverLogic : IFileSaverLogic
    {
        private IFileSaver _fileSaver;
        public FileSaverLogic(IFileSaver fileSaver)
        {
            _fileSaver = fileSaver;
        }
        public string Save(HttpPostedFileBase file)
        {
            
            return _fileSaver.Save(file.InputStream, Guid.NewGuid() + GetFileExtension(file.FileName));
        }

        public string GetFileExtension(string fileName)
        {
            int idxFirstPoint = 0;
            for(int i = fileName.Length-1; i > 0; i--)
            {
                if (fileName[i] == '.') idxFirstPoint = i;
            }
            
            return fileName.Substring(idxFirstPoint);
        }
    }
}
