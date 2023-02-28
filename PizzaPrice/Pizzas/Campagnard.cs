using PizzaPrice.Ingredients;

namespace PizzaPrice.Pizzas
{
    public class Campagnard : Pizza
    {
        public Campagnard() : base(new List<Ingredient> {
            new FreshCream(),
            new Mozarella(),
            new Bacon(),
            new RedOnion(),
            new Mushroom()
        })
        {

        }
    }
}