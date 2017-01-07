using System;
using MvcDemo.Domain;
using MvcDemo.Repository;
using MvcDemo.UnitOfWork.PetaPoco;
using NUnit.Framework;

namespace MvcDemo.Service.Test.Integration
{
    [TestFixture()]
    public class ContactServiceIntegrationTests
    {
        private readonly DateTime _dob = new DateTime(1975, 12, 1);
        private int _lastId; 

        [Test]
        public void Can_Add_A_Contact()
        {
            using (var uow = new PetaPocoUnitOfWork())
            {

                var lastName = Guid.NewGuid().ToString("N");

                var contactRepository = new ContactRepository();

                var contactService = new ContactService(uow, contactRepository);

                var contact = new MvcDemo.Domain.Contact
                {
                    Created = DateTime.Now,
                    DateOfBirth = _dob,
                    FirstName = "Ted",
                    LastName = lastName,
                };

                contactService.Add(contact);

                _lastId = contact.Id;

                Assert.IsTrue(contact.Id>0);
            }
        }

        [TearDown]
        public void TearDown()
        {
            using (var uow = new PetaPocoUnitOfWork())
            {
                uow.db.Delete<Contact>("where Id = @0",_lastId);
                uow.Commit();
            }
        }
    }
}