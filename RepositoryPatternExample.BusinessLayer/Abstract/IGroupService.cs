using RepositoryPatternExample.BusinessLayer.DTO;
using System.Collections.Generic;

namespace RepositoryPatternExample.BusinessLayer.Abstract
{
    public interface IGroupService
    {
        void Insert(InsertGroupDto data);
        List<GroupDto> GetAll();
        void Delete(int id);
    }
}
