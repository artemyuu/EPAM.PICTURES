using EPAM.PICTURES.FILE_DAL.INTERFACES;
using EPAM.PICTURES.BLL;
using EPAM.PICTURES.BLL.INTERFACES;
using EPAM.PICTURES.DAL;
using EPAM.PICTURES.DAL.INTERFACES;
using EPAM.PICTURES.FILE_DAL;
using System;

namespace EPAM.PICTURES.DEPENDENCIES
{
    public class DependencyResolver
    {
        private static DependencyResolver _instance;

        public static DependencyResolver Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DependencyResolver();
                }

                return _instance;
            }
        }

        private IPublicationDAO PublicationDAO => new PublicationDAO();
        private IUserDAO UserDAO => new UserDAO();
        private ITagDAO CategoryDAO => new TagDAO();
        private ICommentDAO CommentDAO => new CommentDAO();

        private IFileSaver FileSaver => new FileSaver(@"A:\EPAM.PICTURES\EPAM.PICTURES.WEBPL\");
        public IFileSaverLogic FileSaverLogic => new FileSaverLogic(FileSaver);
        public IPublicationLogic PublicationLogic => new PublicationLogic(PublicationDAO);

        public ICommentLogic CommentLogic => new CommentLogic(CommentDAO);
        public IUserLogic UserLogic => new UserLogic(UserDAO);
    }
}
