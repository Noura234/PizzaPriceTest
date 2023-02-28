using PizzaPrice.Ingredients;

namespace PizzaPrice.Pizzas
{
    public class BPM : Pizza
    {
        public BPM() : base(new List<Ingredient>() {
            new Barbecue(),
            new Mozarella(),
            new Beef(),
            new RoastChicken(),
            new Merguez() })
        {
        }
    }
}