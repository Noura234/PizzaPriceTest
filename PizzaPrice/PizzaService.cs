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
                var pizza = new FourCheeseTomato(new List<Ingredient>()
                {
                    new Tomato(),
                    new Mozarella(),
                    new Goat(),
                    new Emmental(),
                    new FourmeAmbert(),
                });
                pizzaPrice = pizza.GetIngredientsPrice();
            }
            else if (pizzaName.Equals(PizzaNameEnum.FourCheeseFreshCream))
            {
                var pizza = new FourCheeseFreshCream(new List<Ingredient>()
                {
                    new FreshCream(),
                    new Mozarella(),
                    new Goat(),
                    new Emmental(),
                    new FourmeAmbert(),
                });
                pizzaPrice = pizza.GetIngredientsPrice();
            }
            else if (pizzaName.Equals(PizzaNameEnum.BPM))
            {
                var pizza = new BPM(new List<Ingredient>()
                {
                    new Barbecue(),
                    new Mozarella(),
                    new Beef(),
                    new RoastChicken(),
                    new Merguez(),
                });
                pizzaPrice = pizza.GetIngredientsPrice();
            }
            return pizzaPrice;
        }
    }
}