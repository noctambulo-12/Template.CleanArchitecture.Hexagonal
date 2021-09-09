using Template.Domain.Interfaces.Repositories;

namespace Template.Application.Interfaces
{
    public interface IBaseCommandService<TEntity, TEntityId>
   : IAdd<TEntity>, IEdit<TEntity>, IDelete<TEntityId>, IToList<TEntity, TEntityId>
    {
    }
}
