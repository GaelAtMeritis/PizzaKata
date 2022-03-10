// See https://aka.ms/new-console-template for more information

using PizzaKata.Data;

var recipiesDS = new RecipeDataSource();
Console.WriteLine("We can produce all these pizzas:");
foreach (var pizzaName in recipiesDS.GetAllName())
{
    Console.WriteLine((object?)$"    - {pizzaName}");
}
