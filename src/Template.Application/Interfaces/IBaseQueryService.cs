using Template.Domain.Interfaces.Repositories;

namespace Template.Application.Interfaces
{
    public interface IBaseQueryService<TEntity, TEntityId>
        : IToList<TEntity, TEntityId>
    {
    }
}
