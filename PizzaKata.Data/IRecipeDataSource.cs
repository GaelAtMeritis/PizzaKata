namespace PizzaKata.Data;

public interface IRecipeDataSource : IDataSource<Recipe>
{
    IEnumerable<string> GetAllName();
}