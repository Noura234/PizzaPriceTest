using PizzaPrice.Ingredients;

namespace PizzaPrice.Pizzas
{
    public class PepperoniLovers : Pizza
    {
        public PepperoniLovers() : base (new List<Ingredient> { 
            new Tomato(),
            new Mozarella(),
            new PepperoniSausage()
        })
        {
        }
    }
}