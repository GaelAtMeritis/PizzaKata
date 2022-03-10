namespace PizzaKata.SharedKernel;

public interface IAggregate<out TEntity> where TEntity : IEntity
{
    IEnumerable<TEntity> Entities { get; }
}