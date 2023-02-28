using PizzaPrice.Ingredients;

namespace PizzaPrice.Pizzas
{
    public class Queen : Pizza
    {
        public Queen() : base(new List<Ingredient>
        {
            new TomatoSauce(),
            new Mozarella(),
            new Ham(),
            new Mushroom()
        })
        {
        }
    }
}