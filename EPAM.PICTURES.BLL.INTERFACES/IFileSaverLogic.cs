using System.Web;

namespace EPAM.PICTURES.BLL.INTERFACES
{
    public interface IFileSaverLogic
    {
        string Save(HttpPostedFileBase file);
    }
}
