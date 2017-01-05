using MvcDemo.Domain;
using MvcDemo.Repository;
using MvcDemo.UnitOfWork.PetaPoco;

namespace MvcDemo.Service
{
    public class UserService : EntityService<User>, IUserService
    {
        public UserService( IUnitOfWork uow, IRepository<User> repository) : base(uow, repository)
        {
        }
    }
}