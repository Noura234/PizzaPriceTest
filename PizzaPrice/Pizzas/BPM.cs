using PizzaPrice.Ingredients;

namespace PizzaPrice.Pizzas
{
    public class BPM
    {
        private List<Ingredient> _ingredients;

        public BPM(List<Ingredient> ingredients)
        {
            this._ingredients = ingredients;
        }

        public decimal GetIngredientsPrice()
        {
            return _ingredients.Select(i => i.GetPrice()).Sum();
        }
    }
}