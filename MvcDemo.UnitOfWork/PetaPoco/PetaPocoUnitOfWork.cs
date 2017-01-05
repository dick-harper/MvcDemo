using PetaPoco;

namespace MvcDemo.UnitOfWork.PetaPoco
{
    public class PetaPocoUnitOfWork : IUnitOfWork
    {
        private readonly Transaction _petaTransaction;

        private readonly Database _db;

        public PetaPocoUnitOfWork()
        {
            _db = new Database(MvcDemo.Resources.MvcDemoResources.ConnectionStringName);
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