using MvcDemo.Domain;

namespace MvcDemo.Service
{
    public interface IEntityService<TEntity>  : IService
        where TEntity : IEntity
    {
        void Add(TEntity entity);
    }
}