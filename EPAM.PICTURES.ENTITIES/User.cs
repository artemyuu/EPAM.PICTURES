using System;

namespace EPAM.PICTURES.ENTITIES
{
    public class User
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Email { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public int Role { get; private set; }
        public DateTime DateOfDirth { get; private set; }
        public DateTime RegistrationDate { get; private set; }
        public string Image {get; private set;}
        public User(int id, string name, string surname, string email, string username, string password, int role, DateTime dateOfDirth, DateTime registrationDate, string image)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Email = email;
            Username = username;
            Password = password;
            Role = role;
            DateOfDirth = dateOfDirth;
            RegistrationDate = registrationDate;
            Image = image;
        }

        public User(string name, string surname, string email, string username, string password, int role, DateTime dateOfDirth, DateTime registrationDate, string image)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Username = username;
            Password = password;
            Role = role;
            DateOfDirth = dateOfDirth;
            RegistrationDate = registrationDate;
            Image = image;
        }
    }
}
