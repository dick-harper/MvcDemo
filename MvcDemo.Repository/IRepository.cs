using MvcDemo.Domain;
using MvcDemo.UnitOfWork.PetaPoco;

namespace MvcDemo.Repository
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        void Add(IUnitOfWork uow, TEntity entity);

        TEntity Get(IUnitOfWork uow, int id);
    }
}