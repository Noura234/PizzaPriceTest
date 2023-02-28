using PizzaPrice.Ingredients;

namespace PizzaPrice.Pizzas
{
    public class FourCheeseTomato : Pizza
    {
        public FourCheeseTomato() : base(new List<Ingredient>() {
            new TomatoSauce(),
            new Mozarella(),
            new Goat(),
            new Emmental(),
            new FourmeAmbert() })
        {
        }
    }
}