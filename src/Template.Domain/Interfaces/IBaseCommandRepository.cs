using Template.Domain.Interfaces.Repositories;

namespace Template.Domain.Interfaces
{
    public interface IBaseCommandRepository<TEntity, TEntityId>
   : IAdd<TEntity>, IEdit<TEntity>, IDelete<TEntityId>, IToList<TEntity, TEntityId>, ITransaccion
    {
    }
}
