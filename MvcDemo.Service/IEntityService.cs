using MvcDemo.Domain;

namespace MvcDemo.Service
{
    public interface IEntityService<T>  : IService
        where T : BaseEntity
    {
        T Save(T entity);
    }
}