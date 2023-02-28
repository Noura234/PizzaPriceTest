using PizzaPrice.Pizzas;

namespace PizzaPrice
{
    public class PizzaService : IPizzaService
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly Dictionary<PizzaNameEnum, Type> _pizzaKindByName = new Dictionary<PizzaNameEnum, Type>()
        {
            [PizzaNameEnum.FourCheeseTomato] = typeof(FourCheeseTomato),
            [PizzaNameEnum.FourCheeseFreshCream] = typeof(FourCheeseFreshCream),
            [PizzaNameEnum.BPM] = typeof(BPM),
            [PizzaNameEnum.PepperoniLovers] = typeof(PepperoniLovers),
            [PizzaNameEnum.Queen] = typeof(Queen),
            [PizzaNameEnum.Mountaineer] = typeof(Mountaineer),
            [PizzaNameEnum.Supreme] = typeof(Supreme)
        };

        public PizzaService(IServiceProvider serviceProvider)
        {
            this._serviceProvider = serviceProvider;
        }

        public decimal GetPizzaPrice(PizzaNameEnum pizzaName)
        {
            return GetPizza(pizzaName).GetIngredientsPrice();
        }

        private Pizza GetPizza(PizzaNameEnum pizzaName)
        {
            if (_pizzaKindByName.TryGetValue(pizzaName, out Type pizzaClass))
            {
                if (_serviceProvider.GetService(pizzaClass) is Pizza pizza)
                {
                    return pizza;
                }
            }
            throw new InvalidOperationException($"Could not find the matching type for pizzaname {pizzaName}");
        }
    }
}