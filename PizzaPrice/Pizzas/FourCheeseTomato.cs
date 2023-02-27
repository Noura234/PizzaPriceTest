namespace PizzaPrice.Pizzas
{
    public class FourCheeseTomato
    {
        private readonly List<object> _ingredients;

        public FourCheeseTomato(List<object> ingredients)
        {
            _ingredients = ingredients;
        }

        public decimal GetIngredientsPrice()
        {
            return 13;
        }
    }
}