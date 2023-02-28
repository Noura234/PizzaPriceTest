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
            else if (pizzaName.Equals(PizzaNameEnum.PepperoniLovers))
            {
                var pizza = new PepperoniLovers();
                pizzaPrice = pizza.GetIngredientsPrice();
            }
            else if (pizzaName.Equals(PizzaNameEnum.Queen))
            {
                var pizza = new Queen();
                pizzaPrice = pizza.GetIngredientsPrice();
            }
            else if (pizzaName.Equals(PizzaNameEnum.Mountaineer))
            {
                var pizza = new Mountaineer();
                pizzaPrice = pizza.GetIngredientsPrice();
            }
            else if (pizzaName.Equals(PizzaNameEnum.Supreme))
            {
                var pizza = new Supreme();
                pizzaPrice = pizza.GetIngredientsPrice();
            }
            return pizzaPrice;
        }
    }
}