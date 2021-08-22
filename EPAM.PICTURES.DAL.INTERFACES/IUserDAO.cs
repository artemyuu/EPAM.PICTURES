using EPAM.PICTURES.ENTITIES;
using System.Collections.Generic;

namespace EPAM.PICTURES.DAL.INTERFACES
{
    public interface IUserDAO
    {
        bool Create(User newUser);
        bool DeleteById(int id);
        bool UpdateUserByUsername(string username, User newUserData);
        User GetById(int id);
        User GetByUsername(string username);
        IEnumerable<User> GetAll();
        User Authentication(string email, string password);
    }
}
