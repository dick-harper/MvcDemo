using PetaPoco;

namespace MvcDemo.Repository.UOW.PetaPoco
{
    public class PetaPocoUnitOfWork : IUnitOfWork
    {
        private readonly Transaction _petaTransaction;

        private readonly Database _db;

        public PetaPocoUnitOfWork()
        {
            _db = new Database("DbName");
            _petaTransaction = new Transaction(_db);
        }

        public void Dispose()
        {
            _petaTransaction.Dispose();
        }

        public void Commit()
        {
            _petaTransaction.Complete();
        }

        public Database db => _db;
    }
}