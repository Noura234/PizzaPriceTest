using PizzaPrice.Ingredients;

namespace PizzaPrice.Pizzas
{
    public class PepperoniLovers : Pizza
    {
        public PepperoniLovers() : base (new List<Ingredient> { 
            new TomatoSauce(),
            new Mozarella(),
            new PepperoniSausage()
        })
        {
        }
    }
}