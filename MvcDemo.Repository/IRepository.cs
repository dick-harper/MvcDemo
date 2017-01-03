using MvcDemo.Domain;
using MvcDemo.Repository.UOW;

namespace MvcDemo.Repository
{
    public interface IRepository<T> //where T : IEntity<User>
    {
        T Save(IUnitOfWork uow, T entity);
    }
}