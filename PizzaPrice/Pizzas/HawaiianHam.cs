using PizzaPrice.Ingredients;

namespace PizzaPrice.Pizzas
{
    public class HawaiianHam : Pizza
    {
        public HawaiianHam() : base(new List<Ingredient> {
            new TomatoSauce(),
            new Mozarella(),
            new Ham(),
            new PineApple()
        })
        {
        }
    }
}