using EPAM.PICTURES.BLL.INTERFACES;
using EPAM.PICTURES.DAL.INTERFACES;
using EPAM.PICTURES.ENTITIES;
using System.Collections.Generic;

namespace EPAM.PICTURES.BLL
{
    public class PublicationLogic : IPublicationLogic
    {
        private IPublicationDAO _publicationDAO;

        public PublicationLogic(IPublicationDAO publicationDAO)
        {
            _publicationDAO = publicationDAO;
        }

        public bool AddLikePublication(int publicationId, int userId)
        {
            return _publicationDAO.AddLike(publicationId, userId);
        }

        public bool CheckLikePublication(int publicationId, int userId)
        {
            return _publicationDAO.CheckLike(publicationId, userId);
        }

        public bool CreatePublication(Publication newPublication)
        {
            return _publicationDAO.Create(newPublication);
        }

        public bool DeleteLikePublication(int publicationId, int userId)
        {
            return _publicationDAO.DeleteLike(publicationId, userId);
        }

        public bool DeletePublication(int id)
        {
            return _publicationDAO.DeleteById(id);
        }

        public IEnumerable<Publication> GeAllPublicationsByUserId(int userId)
        {
            return _publicationDAO.GetPublicationsByUserId(userId);
        }

        public IEnumerable<Publication> GetAllPublications()
        {
            return _publicationDAO.GetAll();
        }

        public IEnumerable<Publication> GetByPage(int page)
        {
            return _publicationDAO.GetByPage(page);
        }

        public IEnumerable<Publication> GetByTitle(string title)
        {
            return _publicationDAO.GetPublicationsByTitle(title);
        }

        public int GetCountLikesByPublciationId(int publicationId)
        {
            return _publicationDAO.GetLikeCountByPublicationId(publicationId);
        }

        public Publication GetPublicationById(int id)
        {
            return _publicationDAO.GetById(id);
        }
    }
}
