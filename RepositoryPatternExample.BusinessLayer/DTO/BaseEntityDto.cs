namespace RepositoryPatternExample.BusinessLayer.DTO
{
    public class BaseEntityDto<TId> where TId : struct
    {
        public virtual TId Id { get; set; }
    }

    public class BaseEntityDto : BaseEntityDto<int>
    {

    }
}
