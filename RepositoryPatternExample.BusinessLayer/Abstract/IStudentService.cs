using RepositoryPatternExample.BusinessLayer.DTO;
using System.Collections;
using System.Collections.Generic;

namespace RepositoryPatternExample.BusinessLayer.Abstract
{
    public interface IStudentService
    {
        void Insert(InsertStudentDto data);
        List<StudentDto> GetAllWithGroup();
        void Delete(int id);
    }
}
