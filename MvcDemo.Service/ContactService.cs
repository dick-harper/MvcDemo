using MvcDemo.Domain;
using MvcDemo.Repository;
using MvcDemo.UnitOfWork.PetaPoco;

namespace MvcDemo.Service
{
    public class ContactService : EntityService<Contact>, IContactService
    {
        public ContactService(IUnitOfWork uow, IRepository<Contact> repository) : base(uow, repository)
        {
        }
    }
}