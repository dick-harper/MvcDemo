using MvcDemo.Domain;

namespace MvcDemo.Service
{
    public interface IUserService
    {
        User Save(User user);
    }
}