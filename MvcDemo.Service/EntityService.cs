using System;
using MvcDemo.Domain;
using MvcDemo.Repository;
using MvcDemo.UnitOfWork.PetaPoco;

namespace MvcDemo.Service
{
    public class EntityService<TEntity> : IEntityService<TEntity> where TEntity : IEntity
    {
        protected IRepository<TEntity> _repository;
        protected IUnitOfWork _uow;

        public EntityService(IUnitOfWork uow, IRepository<TEntity> repository)
        {
            _uow = uow;
            _repository = repository;
        }

        public void Add(TEntity entity)
        {
            _repository.Add(_uow, entity);
            _uow.Commit();
        }

        public void Dispose()
        {
            _uow?.Dispose();
        }
    }
}