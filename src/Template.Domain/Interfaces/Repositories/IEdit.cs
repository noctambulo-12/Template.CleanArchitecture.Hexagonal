namespace Template.Domain.Interfaces.Repositories
{
    public interface IEdit<TEntity>
    {
        void Edit(TEntity entity);
    }
}
