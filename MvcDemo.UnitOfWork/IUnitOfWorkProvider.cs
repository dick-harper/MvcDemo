using MvcDemo.UnitOfWork.PetaPoco;

namespace MvcDemo.UnitOfWork
{
    public interface IUnitOfWorkProvider
    {
        IUnitOfWork GetUnitOfWork();
    }
}