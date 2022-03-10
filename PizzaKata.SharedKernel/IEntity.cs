using System.Data.Common;

namespace PizzaKata.SharedKernel;

public interface IEntity
{
    public Guid Id { get; }
}