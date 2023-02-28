using PizzaPrice.Ingredients;

namespace PizzaPrice.Pizzas
{
    public class HoneyGoat : Pizza
    {
        public HoneyGoat() : base(new List<Ingredient> {
            new FreshCream(),
            new Mozarella(),
            new GoatCheese(),
            new Honey()
        })
        {
        }
    }
}