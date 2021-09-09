namespace Template.Domain.Interfaces.Repositories
{
    public interface IAdd<TEntity>
    {
        TEntity Add(TEntity entity);
    }
}
