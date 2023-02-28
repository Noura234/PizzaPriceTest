using PizzaPrice.Pizzas;

namespace PizzaPrice.Tests
{
    public class PizzaPriceTests
    {
        [Fact]
        public void FourCheeseTomatoPizzaCost_Should_Return_Ingredients_Prices_13()
        {
            //arrange
            var pizzaName = PizzaNameEnum.FourCheeseTomato;
            var pizzaService = new PizzaService();

            //act
            var pizzaPrice = pizzaService.GetPizzaPrice(pizzaName); 

            //assert
            Assert.Equal(13, pizzaPrice);
        }

        [Fact]
        public void FourCheeseFreshCreamPizzaCost_Should_Return_Ingredients_Prices_13_5()
        {
            //arrange
            var pizzaName = PizzaNameEnum.FourCheeseFreshCream;
            var pizzaService = new PizzaService();

            //act
            var pizzaPrice = pizzaService.GetPizzaPrice(pizzaName);

            //assert
            Assert.Equal(13.5m, pizzaPrice);
        }

        [Fact]
        public void BPMPizzaCost_Should_Return_Ingredients_Prices()
        {
            //arrange
            var pizzaName = PizzaNameEnum.BPM;
            var pizzaService = new PizzaService();

            //act
            var pizzaPrice = pizzaService.GetPizzaPrice(pizzaName);

            //assert
            Assert.Equal(2 + 2 + 4.5m + 6 + 5, pizzaPrice);
        }
    }
}