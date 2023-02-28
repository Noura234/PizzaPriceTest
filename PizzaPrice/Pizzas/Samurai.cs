using PizzaPrice.Ingredients;

namespace PizzaPrice.Pizzas
{
    public class Samurai : Pizza
    {
        public Samurai() : base(new List<Ingredient> {
            new TomatoSauce(),
            new Mozarella(),
            new Merguez(),
            new RoastChicken(),
            new RedOnion(),
            new SamuraiSauce()
        })
        {
        }
    }
}