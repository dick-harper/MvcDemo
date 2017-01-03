namespace MvcDemo.Repository.UOW
{
    public interface IUnitOfWorkProvider
    {
        IUnitOfWork GetUnitOfWork();
    }
}