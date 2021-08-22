using EPAM.PICTURES.ENTITIES;
using System.Collections.Generic;

namespace EPAM.PICTURES.DAL.INTERFACES
{
    public interface IPublicationDAO
    {
        bool Create(Publication newPublication);
        bool DeleteById(int id);
        bool UpdateById(Publication publication);
        Publication GetById(int id);
        IEnumerable<Publication> GetAll();
        IEnumerable<Publication> GetPublicationsByUserId(int userId);
        bool CheckLike(int publicationId, int userId);
        bool AddLike(int publicationId, int userId);
        bool DeleteLike(int publicationId, int userId);
        int GetLikeCountByPublicationId(int publicationId);
        IEnumerable<Publication> GetByPage(int page);
        IEnumerable<Publication> GetPublicationsByTitle(string title);
    }
}
