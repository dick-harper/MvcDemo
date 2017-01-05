using System;
using PetaPoco;

namespace MvcDemo.UnitOfWork.PetaPoco
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit(); // Complete

        Database db { get; }
    }
}