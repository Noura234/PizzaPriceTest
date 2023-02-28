using PizzaPrice.Ingredients;

namespace PizzaPrice.Pizzas
{
    public class Vegetarian : Pizza
    {
        public Vegetarian() : base(new List<Ingredient> { 
            new TomatoSauce(),
            new Mozarella(),
            new Mushroom(),
            new RedOnion(),
            new GreenPepper(),
            new FreshTomato(),
            new BlackOlive()
        })
        {
        }
    }
}