using Moq;
using MvcDemo.Domain;
using MvcDemo.Repository;
using MvcDemo.UnitOfWork.PetaPoco;
using NUnit.Framework;

namespace MvcDemo.Service.Test.Unit
{
    [TestFixture]
    public class UserTests
    {

        [Test]
        public void Add_Calls_Repository_Add()
        {
            // Arrange
            var mockRepository = new Mock<IUserRepository>();
            var mockUnitOfWork = new Mock<IUnitOfWork>();
            mockRepository.Setup(x => x.Add(mockUnitOfWork.Object, It.IsAny<User>()));
            var userService = new UserService(mockUnitOfWork.Object, mockRepository.Object);

            // Act
            userService.Add(It.IsAny<User>());

            // Assert
            mockRepository.VerifyAll();
        }
    }
}