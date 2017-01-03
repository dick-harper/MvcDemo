using System;
using PetaPoco;

namespace MvcDemo.Repository.UOW
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();

        Database db { get; }
    }
}