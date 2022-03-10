namespace PizzaKata.SharedKernel;

public class BaseEntity : IEntity
{
    protected BaseEntity() => Id = Guid.NewGuid();

    public Guid Id { get; }
}