using PizzaPrice.Ingredients;

namespace PizzaPrice.Pizzas
{
    public class Mountaineer : Pizza
    {
        public Mountaineer() : base (new List<Ingredient> { 
            new FreshCream(),
            new Mozarella(),
            new Ham(),
            new RacletteCheese(),
            new Mushroom()
        })
        {
        }
    }
}