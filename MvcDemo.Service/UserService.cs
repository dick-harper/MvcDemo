using MvcDemo.Domain;
using MvcDemo.Repository;
using MvcDemo.Repository.UOW;
using MvcDemo.Repository.UOW.PetaPoco;

namespace MvcDemo.Service
{
    public class UserService : IUserService 
    {
        private readonly IUserRepository _repository;
        
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public User Save(User user)
        {
            using (IUnitOfWork uow = new PetaPocoUnitOfWork())
            {
                //return _repository.Save(uow, user);
            }

            return null;
        }
    }
}