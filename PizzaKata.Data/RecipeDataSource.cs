namespace PizzaKata.Data;

public class RecipeDataSource : IRecipeDataSource
{
    private static readonly List<Recipe> Recipies;

    private static readonly Recipe DefaultValue;
    
    #region Define step

    private static RecipeStep PrepareDough;
    private static RecipeStep AddTomatoesForCooking;
    private static RecipeStep AddMozzarellaForCooking;
    private static RecipeStep AddMushroomForCooking;
    private static RecipeStep CookPizza;
    private static RecipeStep AddFreshTomatoes;
    private static RecipeStep AddFreshMozzarella;
    private static RecipeStep AddFreshMushroom;
    private static RecipeStep AddHam;
    private static RecipeStep AddCaper;
    private static RecipeStep AddAnchovy;
    private static RecipeStep AddOlive;
    private static RecipeStep AddPineapple;

    #endregion

    static RecipeDataSource()
    {
        var cookingActions      = new CookingActionDataSource();
        var ingredients         = new IngredientDataSource();
        DefaultValue            = new(0, "---", new());
        PrepareDough            = new(1, cookingActions.GetById(1), ingredients.GetDefault());
        AddTomatoesForCooking   = new(2, cookingActions.GetById(2), ingredients.GetById(1));
        AddMozzarellaForCooking = new(3, cookingActions.GetById(2), ingredients.GetById(2));
        AddMushroomForCooking   = new(5, cookingActions.GetById(2), ingredients.GetById(3));
        CookPizza               = new(4, cookingActions.GetById(3), ingredients.GetDefault());
        AddFreshTomatoes        = new(6, cookingActions.GetById(2), ingredients.GetById(13));
        AddFreshMozzarella      = new(7, cookingActions.GetById(2), ingredients.GetById(2));
        AddFreshMushroom        = new(8, cookingActions.GetById(2), ingredients.GetById(3));
        AddHam                  = new(8, cookingActions.GetById(2), ingredients.GetById(6));
        AddCaper                = new(8, cookingActions.GetById(2), ingredients.GetById(7));
        AddAnchovy              = new(8, cookingActions.GetById(2), ingredients.GetById(8));
        AddOlive                = new(8, cookingActions.GetById(2), ingredients.GetById(9));
        AddPineapple            = new(8, cookingActions.GetById(2), ingredients.GetById(14));
        Recipies = new()
        {
            DefaultValue,
            new(1, "Regina", new()
            {
                new(1, PrepareDough),
                new(2, AddTomatoesForCooking),
                new(3, AddMozzarellaForCooking),
                new(4, CookPizza),
                new(5, AddHam),
                new(6, AddOlive),
            }),
            new(2, "Margherita", new()
            {
                new(1, PrepareDough),
                new(2, AddTomatoesForCooking),
                new(3, AddMozzarellaForCooking),
                new(4, CookPizza),
                new(5, AddOlive),
            }),
            new(3, "Napolitan", new()
            {
                new(1, PrepareDough),
                new(2, AddTomatoesForCooking),
                new(3, CookPizza),
                new(4, AddAnchovy),
                new(5, AddCaper),
            }),
            new(4, "Hawaian", new()
            {
                new(1, PrepareDough),
                new(2, AddTomatoesForCooking),
                new(3, AddMozzarellaForCooking),
                new(4, CookPizza),
                new(5, AddHam),
                new(6, AddPineapple),
            })
        };
    }

    public List<Recipe> GetAll() => Recipies;

    public Recipe GetById(int id) => Recipies.FirstOrDefault(recipie => recipie.RecipeId == id) ?? DefaultValue;

    public Recipe GetDefault() => DefaultValue;
    
    public IEnumerable<string> GetAllName() => Recipies.Select(recipe => recipe.RecipeName);
}