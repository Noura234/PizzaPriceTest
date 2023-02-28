using PizzaPrice.Ingredients;

namespace PizzaPrice.Pizzas
{
    public class Supreme : Pizza
    {
        public Supreme() : base (new List<Ingredient> { 
            new Tomato(),
            new Mozarella(),
            new Beef(),
            new PepperoniSausage(),
            new Mushroom(),
            new RedOnion(),
            new GreenPepper(),
        })
        {
        }
    }
}