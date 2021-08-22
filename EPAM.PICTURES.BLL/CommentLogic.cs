using EPAM.PICTURES.BLL.INTERFACES;
using EPAM.PICTURES.DAL.INTERFACES;
using EPAM.PICTURES.ENTITIES;
using System.Collections.Generic;

namespace EPAM.PICTURES.BLL
{
    public class CommentLogic : ICommentLogic
    {
        private ICommentDAO _commentDAO;
        public CommentLogic(ICommentDAO commentDAO)
        {
            _commentDAO = commentDAO;
        }
        public bool CreateComment(Comment newComment)
        {
            return _commentDAO.Create(newComment);
        }

        public bool DeleteCommentById(int id)
        {
            return _commentDAO.DeleteById(id);
        }

        public bool DeleteCommentsByPublicationId(int id)
        {
            return _commentDAO.DeleteByPublicationId(id);
        }

        public IEnumerable<Comment> GetAllCommentsByPublicationId(int publicationId)
        {
            return _commentDAO.GetAllByPublicationId(publicationId);
        }

        public int GetCountCommenstByPublicationId(int publicationId)
        {
            return _commentDAO.GetCountCommenstByPublicationId(publicationId);
        }
    }
}
