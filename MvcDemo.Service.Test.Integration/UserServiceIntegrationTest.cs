using MvcDemo.Domain;
using MvcDemo.Repository;
using MvcDemo.UnitOfWork.PetaPoco;
using NUnit.Framework;

namespace MvcDemo.Service.Test.Integration
{
    [TestFixture]
    public class UserServiceIntegrationTest
    {
        [Test]
        public void Can_Add_User()
        {
            var uow = new PetaPocoUnitOfWork();

            var userRepository = new UserRepository();

            var userService = new UserService(uow, userRepository);

            var user = new User
            {
                Active = false,
                Contact = null,
                UserName = "Ted"
                
            };

            userService.Add(user);
        }
    }
}