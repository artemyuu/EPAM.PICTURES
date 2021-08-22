using System;

namespace EPAM.PICTURES.ENTITIES
{
    public class Publication
    {
        public int Id { get; private set; }
        public User Author { get; private set; }
        public int UserId { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Image { get; private set; }
        public DateTime DateOfCreation { get; private set; }
        public Publication(int id, User author, string title, string descripton, string image, DateTime dateOfCreation)
        {
            Id = id;
            Author = author;
            Title = title;
            Description = descripton;
            Image = image;
            DateOfCreation = dateOfCreation;
        }

        public Publication(int id, int userId, string title, string descripton, string image, DateTime dateOfCreation)
        {
            Id = id;
            UserId = userId;
            Title = title;
            Description = descripton;
            Image = image;
            DateOfCreation = dateOfCreation;
        }

        public Publication (User author, string title, string descripton, string image, DateTime dateOfCreation)
        {
            Author = author;
            Title = title;
            Description = descripton;
            Image = image;
            DateOfCreation = dateOfCreation;
        }
    }
}
