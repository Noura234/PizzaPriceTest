using PizzaPrice.Ingredients;

namespace PizzaPrice.Pizzas
{
    public class FourCheeseTomato
    {
        private readonly List<Ingredient> _ingredients;

        public FourCheeseTomato(List<Ingredient> ingredients)
        {
            _ingredients = ingredients ?? throw new ArgumentNullException(nameof(ingredients));
        }

        public decimal GetIngredientsPrice()
        {
            return _ingredients.Select(i => i.GetPrice()).Sum();
        }
    }
}