using PizzaPrice.Ingredients;

namespace PizzaPrice.Pizzas
{
    public class FourCheeseFreshCream
    {
        private List<Ingredient> _ingredients;

        public FourCheeseFreshCream(List<Ingredient> ingredients)
        {
            this._ingredients = ingredients ?? throw new ArgumentNullException(nameof(ingredients));
        }
        public decimal GetIngredientsPrice()
        {
            return _ingredients.Select(i => i.GetPrice()).Sum();
        }
    }
}