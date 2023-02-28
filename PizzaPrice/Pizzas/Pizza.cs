using PizzaPrice.Ingredients;

namespace PizzaPrice.Pizzas
{
    public abstract class Pizza
    {
        private readonly List<Ingredient> _ingredients;

        public Pizza(List<Ingredient> ingredients)
        {
            _ingredients = ingredients ?? throw new ArgumentNullException(nameof(ingredients));
        }

        public decimal GetIngredientsPrice()
        {
            return _ingredients.Select(i => i.GetPrice()).Sum();
        }
    }
}