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
                var pizza = new FourCheeseTomato(new List<Ingredient>()
                {
                    new Tomato(),
                    new Mozarella(),
                    new Goat(),
                    new Emmental(),
                    new FourmeAmbert(),
                });
                var pizzaPrice = pizza.GetIngredientsPrice();
                return pizzaPrice;
            }
            else if (pizzaName.Equals("FourCheeseFreshCream"))
            {
                var pizza = new FourCheeseFreshCream(new List<Ingredient>()
                {
                    new FreshCream(),
                    new Mozarella(),
                    new Goat(),
                    new Emmental(),
                    new FourmeAmbert(),
                });
                var pizzaPrice = pizza.GetIngredientsPrice();
                return pizzaPrice;
            }
            return 0;
        }
    }
}