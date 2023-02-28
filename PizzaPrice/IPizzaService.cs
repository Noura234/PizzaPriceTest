using PizzaPrice.Pizzas;

namespace PizzaPrice
{
    public interface IPizzaService
    {
        decimal GetPizzaPrice(PizzaNameEnum pizzaName);
    }
}