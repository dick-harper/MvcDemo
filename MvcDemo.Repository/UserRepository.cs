using MvcDemo.Domain;

namespace MvcDemo.Repository
{
    public class UserRepository : EntityRepository<User>, IUserRepository
    {
    }
}