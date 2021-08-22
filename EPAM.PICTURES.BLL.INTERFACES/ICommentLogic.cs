using EPAM.PICTURES.ENTITIES;
using System.Collections.Generic;

namespace EPAM.PICTURES.BLL.INTERFACES
{
    public interface ICommentLogic
    {
        bool CreateComment(Comment newComment);
        bool DeleteCommentById(int id);
        bool DeleteCommentsByPublicationId(int id);
        IEnumerable<Comment> GetAllCommentsByPublicationId(int publicationId);
        int GetCountCommenstByPublicationId(int publicationId);
    }
}
