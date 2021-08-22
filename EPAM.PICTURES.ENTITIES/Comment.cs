using System;

namespace EPAM.PICTURES.ENTITIES
{
    public class Comment
    {
        public int Id { get; private set; }
        public int PublicationId { get; private set; }
        public int UserId { get; private set; }
        public DateTime DateOfCreation { get; private set; }
        public string CommentBody { get; private set; }

        public Comment(int publicationId, int userId, DateTime dateOfCreation, string commentBody)
        {
            PublicationId = publicationId;
            UserId = userId;
            DateOfCreation = dateOfCreation;
            CommentBody = commentBody;
        }
        public Comment(int id, int publicationId, int userId, DateTime dateOfCreation, string commentBody)
        {
            Id = id;
            PublicationId = publicationId;
            UserId = userId;
            DateOfCreation = dateOfCreation;
            CommentBody = commentBody;
        }


    }
}
