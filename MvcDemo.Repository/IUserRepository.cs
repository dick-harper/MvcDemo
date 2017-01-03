using MvcDemo.Domain;
using MvcDemo.Repository.UOW;

namespace MvcDemo.Repository
{
    public interface IUserRepository
    {
        User Save(IUnitOfWork uow, User user);
    }
}