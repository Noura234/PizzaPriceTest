using PizzaPrice.Ingredients;

namespace PizzaPrice.Pizzas
{
    public class Raclette : Pizza
    {
        public Raclette() : base(new List<Ingredient> {
            new FreshCream(),
            new Mozarella(),
            new Potato(),
            new Bacon(),
            new RacletteCheese()
        })
        {
        }
    }
}