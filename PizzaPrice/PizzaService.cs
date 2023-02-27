using PizzaPrice.Ingredients;
using PizzaPrice.Pizzas;

namespace PizzaPrice
{
    public class PizzaService
    {
        public PizzaService()
        {
        }

        public decimal GetPizzaPrice(string pizzaName)
        {
            if (pizzaName.Equals("FourCheeseTomato"))
            {
                var pizza = new FourCheeseTomato(new List<object>()
                {
                    new Tomato(1, "Sauce"),
                    new Mozarella(2, "Cheese"),
                    new Goat(4, "Cheese"),
                    new Emmental(2, "Cheese"),
                    new FourmeAmbert(4, "Cheese"),
                });
                var pizzaPrice = pizza.GetIngredientsPrice();
                return pizzaPrice;
            }
            return 0;
        }
    }
}