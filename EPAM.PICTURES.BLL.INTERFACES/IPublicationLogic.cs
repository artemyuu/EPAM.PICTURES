using EPAM.PICTURES.ENTITIES;
using System.Collections.Generic;

namespace EPAM.PICTURES.BLL.INTERFACES
{
    public interface IPublicationLogic
    {
        bool CreatePublication(Publication newPublication);
        bool DeletePublication(int id);
        IEnumerable<Publication> GetAllPublications();
        IEnumerable<Publication> GeAllPublicationsByUserId(int userId);
        Publication GetPublicationById(int id);
        bool AddLikePublication(int publicationId, int userId);
        bool DeleteLikePublication(int publicationId, int userId);
        bool CheckLikePublication(int publicationId, int userId);
        int GetCountLikesByPublciationId(int publicationId);
        IEnumerable<Publication> GetByPage(int page);
        IEnumerable<Publication> GetByTitle(string title);
    }
}
