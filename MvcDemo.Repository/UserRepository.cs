using System.Runtime.InteropServices.ComTypes;
using MvcDemo.Domain;
using MvcDemo.Repository.UOW;
using PetaPoco;

namespace MvcDemo.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IDatabase _database;

        public UserRepository(IDatabase database)
        {
            _database = database;
        }

        public User Save(IUnitOfWork uow, User user)
        {
            uow.db.Save(user);

            return user;
        }
    }
}