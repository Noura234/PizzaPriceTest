using PizzaPrice.Ingredients;

namespace PizzaPrice.Pizzas
{
    public class FourCheeseTomato : Pizza
    {
        public FourCheeseTomato() : base(new List<Ingredient>() {
            new Tomato(),
            new Mozarella(),
            new Goat(),
            new Emmental(),
            new FourmeAmbert() })
        {
        }
    }
}