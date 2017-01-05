namespace MvcDemo.Domain
{
    public abstract class BaseEntity
    {
    }

    public abstract class Entity : IEntity
    {
        public int Id { get; set; }
    }
}