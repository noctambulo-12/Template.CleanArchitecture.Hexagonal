using System.Collections.Generic;

namespace Template.Domain.Interfaces.Repositories
{
    public interface IToList<TEntity, TEntityId>
    {
        List<TEntity> GetList();
        TEntity GetListById(TEntityId entityId);
    }
}
