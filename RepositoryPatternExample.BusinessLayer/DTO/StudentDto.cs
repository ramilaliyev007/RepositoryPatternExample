namespace RepositoryPatternExample.BusinessLayer.DTO
{
    public class StudentDto : BaseEntityDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }

        public int GroupId { get; set; }
        public string GroupName { get; set; }
    }
}
