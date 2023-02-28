using PizzaPrice.Ingredients;

namespace PizzaPrice.Pizzas
{
    public class ChikenPermesan : Pizza
    {
        public ChikenPermesan() : base(new List<Ingredient> {
            new TomatoSauce(),
            new Mozarella(),
            new RoastChicken(),
            new FreshTomato(),
            new ParmigianoCheese()
        })
        {
        }
    }
}