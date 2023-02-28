using PizzaPrice.Ingredients;

namespace PizzaPrice.Pizzas
{
    public class Nordic : Pizza
    {
        public Nordic() : base(new List<Ingredient> {
            new FreshCream(),
            new Mozarella(),
            new SmokedSalmon()
        })
        {
        }
    }
}