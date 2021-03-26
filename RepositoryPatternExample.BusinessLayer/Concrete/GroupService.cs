using RepositoryPatternExample.BusinessLayer.Abstract;
using RepositoryPatternExample.BusinessLayer.DTO;
using RepositoryPatternExample.Domain;
using RepositoryPatternExample.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryPatternExample.BusinessLayer.Concrete
{
    public class GroupService : IGroupService
    {
        private readonly IGroupRepository _groupRepository;

        // IGroupRepository will inject from Dependency Injection
        public GroupService(IGroupRepository groupRepository)
        {
            this._groupRepository = groupRepository;
        }

        public void Delete(int id)
        {
            var group = _groupRepository.GetById(id);

            if (group.Name == "Main")
                throw new Exception("You cannot delete group that Name is Main");

            // And other business logic

            _groupRepository.Delete(id);
        }

        public List<GroupDto> GetAll()
        {
            var groups = _groupRepository.GetAll()
                                         .Select(x => new GroupDto
                                         {
                                             Id = x.Id,
                                             Name = x.Name,
                                             Code = x.Code
                                         })
                                         .ToList();
            // And other business logic

            return groups;
        }

        public void Insert(InsertGroupDto data)
        {
            var group = new Group
            {
                Name = data.Name,
                Code = data.Code
            };

            // And other business logic

            _groupRepository.Insert(group);
        }
    }
}
