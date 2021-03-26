using Microsoft.AspNetCore.Mvc;
using RepositoryPatternExample.BusinessLayer.Abstract;
using RepositoryPatternExample.BusinessLayer.DTO;
using System.Collections.Generic;

namespace RepositoryPatternExample.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            this._studentService = studentService;
        }

        [HttpGet("GetAllWithGroup")]
        public List<StudentDto> GetAllWithGroup()
        {
            return _studentService.GetAllWithGroup();
        }

        [HttpPost("Insert")]
        public void Insert(InsertStudentDto data)
        {
            _studentService.Insert(data);
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _studentService.Delete(id);
        }
    }
}
