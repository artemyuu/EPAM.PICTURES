using EPAM.PICTURES.ENTITIES;
using System.Collections.Generic;

namespace EPAM.PICTURES.DAL.INTERFACES
{
    public interface ITagDAO
    {
        bool Create(Tag newTag);
        bool DeleteById(int id);
        bool UpdateById(Tag tag);
        Tag GetById(int id);
        IEnumerable<Tag> GetAll();
    }
}
