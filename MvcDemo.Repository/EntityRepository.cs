using System;
using MvcDemo.Domain;
using MvcDemo.UnitOfWork;
using MvcDemo.UnitOfWork.PetaPoco;
using PetaPoco;

namespace MvcDemo.Repository
{
    public class EntityRepository<TEntity> : IRepository<TEntity> where TEntity : IEntity
    {
        public void Add(IUnitOfWork uow, TEntity entity)
        {
            uow.db.Save(this.GetTableName(), "Id", entity);
        }

        public TEntity Get(IUnitOfWork uow, int id)
        {
            var tableName = this.GetTableName();

            return uow.db.SingleOrDefault<TEntity>($"SELECT * FROM {tableName} WHERE id = @0", id);
        }

        private string GetTableName()
        {
            var entityName = $"dbo.{typeof(TEntity).Name}";

            var plural = entityName[entityName.Length - 1] == 's' ? "" : "s";

            return $"{entityName}{plural}";
        }
    }
}