using PizzaPrice.Ingredients;
using PizzaPrice.Pizzas;

namespace PizzaPrice
{
    public class PizzaService
    {
        public PizzaService()
        {
        }

        public decimal GetPizzaPrice(PizzaNameEnum pizzaName)
        {
            var pizzaPrice = 0m;
            if (pizzaName.Equals(PizzaNameEnum.FourCheeseTomato))
            {
                var pizza = new FourCheeseTomato();
                pizzaPrice = pizza.GetIngredientsPrice();
            }
            else if (pizzaName.Equals(PizzaNameEnum.FourCheeseFreshCream))
            {
                var pizza = new FourCheeseFreshCream();
                pizzaPrice = pizza.GetIngredientsPrice();
            }
            else if (pizzaName.Equals(PizzaNameEnum.BPM))
            {
                var pizza = new BPM();
                pizzaPrice = pizza.GetIngredientsPrice();
            }
            return pizzaPrice;
        }
    }
}