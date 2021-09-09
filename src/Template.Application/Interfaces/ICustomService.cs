using System.Collections.Generic;
using Template.Domain.Interfaces.Repositories;


namespace Template.Application.Interfaces
{
    public interface ICustomService<TEntity, TEntityId, TDataTransferObject1, TDataTransferObject2>
     :  IToList<TEntity, TEntityId>
    {
        public bool ValidateFields(string document, byte age);
        public List<TDataTransferObject1> GetListOfChildren(TEntityId entityId);
        public TDataTransferObject1 GetProductParent(TEntityId entityId);
        public TDataTransferObject1 SearchByName(string name);
    }
}