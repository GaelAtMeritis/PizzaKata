namespace PizzaKata.Data;

internal class CookingActionDataSource : IDataSource<CookingAction>
{
    private static readonly List<CookingAction?> CookingActions;
    private static readonly CookingAction DefaultValue = new CookingAction("---", 0);
    
    static CookingActionDataSource()
    {
        CookingActions = new List<CookingAction?>()
        {
            DefaultValue,
            new CookingAction("prepare dough", 1),
            new CookingAction("add ingredient", 2),
            new CookingAction("Cook the pizza", 3),
        };
    }

    public List<CookingAction> GetAll() => CookingActions;

    public CookingAction GetById(int id) =>
        CookingActions.FirstOrDefault(cookingAction => cookingAction?.CookingActionId == id) ??
        DefaultValue;

    public CookingAction GetDefault() => DefaultValue;
}