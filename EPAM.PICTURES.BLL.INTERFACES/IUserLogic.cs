using EPAM.PICTURES.ENTITIES;

namespace EPAM.PICTURES.BLL.INTERFACES
{
    public interface IUserLogic
    {
        bool CreateUser(User newUser);
        User Authentication(string email, string password);
        User GetUserById(int id);
        User GetUserByUsername(string username);
        bool UpdateUserByUsername(string username, User newUser);

    }
}
