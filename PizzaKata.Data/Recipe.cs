namespace PizzaKata.Data;

public record Recipe(int RecipeId, string RecipeName, List<OrderedRecipeStep> IngredientIds);