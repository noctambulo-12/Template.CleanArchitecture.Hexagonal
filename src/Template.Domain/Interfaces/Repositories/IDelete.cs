namespace Template.Domain.Interfaces.Repositories
{
    public interface IDelete<TEntityId>
    {
        void Delete(TEntityId entityId);
    }
}
