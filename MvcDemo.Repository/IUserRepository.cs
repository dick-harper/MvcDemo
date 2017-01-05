using System.Runtime.InteropServices.ComTypes;
using MvcDemo.Domain;

namespace MvcDemo.Repository
{
    public interface IUserRepository : IRepository<User>
    {
    }
}