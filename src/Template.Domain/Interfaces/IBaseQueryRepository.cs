using Template.Domain.Interfaces.Repositories;

namespace Template.Domain.Interfaces
{
    public interface IBaseQueryRepository<TEntity, TEntityId>
        : IToList<TEntity, TEntityId>
    {
    }
}
