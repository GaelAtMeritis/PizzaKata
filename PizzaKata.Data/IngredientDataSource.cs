namespace PizzaKata.Data;

internal class IngredientDataSource : IDataSource<Ingredient>
{
    private static readonly List<Ingredient> Ingredients;
    private static readonly Ingredient DefaultValue = new Ingredient(0, "---", false);
    
    static IngredientDataSource()
    {
        Ingredients = new List<Ingredient>()
        {
            DefaultValue,
            new Ingredient(1,"tomato basis", true),
            new Ingredient(2,"mozzarella (to be cooked)", true),
            new Ingredient(3,"mushroom (to be cooked)", true),
            new Ingredient(4,"fresh mushroom", false),
            new Ingredient(5,"fresh mozzarella", false),
            new Ingredient(6,"ham", false),
            new Ingredient(7,"caper", false),
            new Ingredient(8,"anchovy", false),
            new Ingredient(9,"olive", false),
            new Ingredient(10,"artichoke", false),
            new Ingredient(11,"egg plant", false),
            new Ingredient(12,"salad", false),
            new Ingredient(13,"fresh tomatoes", false),
            new Ingredient(14,"pineapple", false),
        };
    }

    public List<Ingredient> GetAll() => Ingredients;

    public Ingredient GetById(int ingredientId) =>
        Ingredients.FirstOrDefault(ingredient => ingredient.IngredientId == ingredientId) ?? 
        DefaultValue;

    public Ingredient GetDefault() => DefaultValue;
}