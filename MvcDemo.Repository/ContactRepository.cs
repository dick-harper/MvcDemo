using MvcDemo.Domain;

namespace MvcDemo.Repository
{
    public class ContactRepository : EntityRepository<Contact>, IContactRepository
    {
        
    }
}