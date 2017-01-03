using Moq;
using MvcDemo.Domain;
using MvcDemo.Repository;
using MvcDemo.Repository.UOW;
using NUnit.Framework;
using PetaPoco;

namespace MvcDemo.Service.Test
{
    [TestFixture]
    public class UserTests
    {

        [Test]
        public void Save_Calls_Repository_Save()
        {
            // Arrange
            var mockRepository = new Mock<IUserRepository>();
            var mockUnitOfWork = new Mock<IUnitOfWork>();
            mockRepository.Setup(x => x.Save(mockUnitOfWork.Object, It.IsAny<User>()));
            
            var mockService = new Mock<IUserService>();

            // Act
            mockService.Object.Save(It.IsAny<User>());

            // Assert
            mockService.VerifyAll();
        }
    }
}