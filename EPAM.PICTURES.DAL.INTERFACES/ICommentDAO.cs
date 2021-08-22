using EPAM.PICTURES.ENTITIES;
using System.Collections.Generic;

namespace EPAM.PICTURES.DAL.INTERFACES
{
    public interface ICommentDAO
    {
        bool Create(Comment newComment);
        bool DeleteById(int id);
        bool DeleteByPublicationId(int id);
        bool UpdateById(Comment comment);
        Comment GetById(int id);
        IEnumerable<Comment> GetAllByPublicationId(int publicationId);
        int GetCountCommenstByPublicationId(int publicationId);
    }
}
