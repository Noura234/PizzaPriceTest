using PizzaPrice.Ingredients;

namespace PizzaPrice.Pizzas
{
    public class Supreme : Pizza
    {
        public Supreme() : base (new List<Ingredient> { 
            new TomatoSauce(),
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