using EPAM.PICTURES.BLL.INTERFACES;
using EPAM.PICTURES.DAL.INTERFACES;
using EPAM.PICTURES.ENTITIES;

namespace EPAM.PICTURES.BLL
{
    public class UserLogic : IUserLogic
    {
        private IUserDAO _userDAO;

        public UserLogic (IUserDAO userDAO)
        {
            _userDAO = userDAO;
        }

        public bool CreateUser(User newUser)
        {
            return _userDAO.Create(newUser);
        }

        public User Authentication(string email, string password)
        {
            return _userDAO.Authentication(email, password);
        }

        public User GetUserById(int id)
        {
            return _userDAO.GetById(id);
        }

        public User GetUserByUsername(string username)
        {
            return _userDAO.GetByUsername(username);
        }

        public bool UpdateUserByUsername(string username, User newUser)
        {
            return _userDAO.UpdateUserByUsername(username, newUser);
        }
    }
}
