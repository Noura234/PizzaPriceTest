using PizzaPrice.Ingredients;

namespace PizzaPrice.Pizzas
{
    public class FourCheeseFreshCream : Pizza
    {
        public FourCheeseFreshCream() : base(new List<Ingredient>() {
            new FreshCream(),
            new Mozarella(),
            new Goat(),
            new Emmental(),
            new FourmeAmbert() })
        {
        }
    }
}