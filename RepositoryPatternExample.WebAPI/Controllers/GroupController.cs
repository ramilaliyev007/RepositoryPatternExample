using Microsoft.AspNetCore.Mvc;
using RepositoryPatternExample.BusinessLayer.Abstract;
using RepositoryPatternExample.BusinessLayer.DTO;
using System.Collections.Generic;

namespace RepositoryPatternExample.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly IGroupService _groupService;

        public GroupController(IGroupService groupService)
        {
            this._groupService = groupService;
        }

        [HttpGet("GetAll")]
        public List<GroupDto> GetAll()
        {
            return _groupService.GetAll();
        }

        [HttpPost("Insert")]
        public void Insert(InsertGroupDto data)
        {
            _groupService.Insert(data);
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _groupService.Delete(id);
        }
    }
}
