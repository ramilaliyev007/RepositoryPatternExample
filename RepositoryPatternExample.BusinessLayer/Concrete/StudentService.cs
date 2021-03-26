using RepositoryPatternExample.BusinessLayer.Abstract;
using RepositoryPatternExample.BusinessLayer.DTO;
using RepositoryPatternExample.Domain;
using RepositoryPatternExample.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryPatternExample.BusinessLayer.Concrete
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        // IStudentRepository will inject from Dependency Injection
        public StudentService(IStudentRepository studentRepository)
        {
            this._studentRepository = studentRepository;
        }

        public void Delete(int id)
        {
            var student = _studentRepository.GetById(id);

            if (student.FirstName == "Ramil")
                throw new Exception("You cannot delete student that FirstName is Ramil");

            // And other business logic

            _studentRepository.Delete(id);
        }

        public List<StudentDto> GetAllWithGroup()
        {
            var students = _studentRepository.GetAllWithGroup();

            var result = students.Select(x => new StudentDto
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                FullName = $"{x.FirstName} {x.LastName}",
                GroupId = x.GroupId,
                GroupName = x.Group.Name,
            })
            .ToList();

            // And other business logic

            return result;
        }

        public void Insert(InsertStudentDto data)
        {
            var student = new Student
            {
                FirstName = data.FirstName,
                LastName = data.LastName,
                GroupId = data.GroupId
            };

            // And other business logic

            _studentRepository.Insert(student);
        }
    }
}
