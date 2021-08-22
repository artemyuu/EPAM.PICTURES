using System.IO;


namespace EPAM.PICTURES.FILE_DAL.INTERFACES
{
    public interface IFileSaver
    {
        string Save(Stream stream, string fileName);
    }
}
