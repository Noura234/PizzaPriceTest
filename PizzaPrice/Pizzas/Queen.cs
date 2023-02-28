using PizzaPrice.Ingredients;

namespace PizzaPrice.Pizzas
{
    public class Queen : Pizza
    {
        public Queen() : base(new List<Ingredient>
        {
            new Tomato(),
            new Mozarella(),
            new Ham(),
            new Mushroom()
        })
        {
        }
    }
}