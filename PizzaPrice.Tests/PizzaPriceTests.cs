using PizzaPrice.Pizzas;

namespace PizzaPrice.Tests
{
    public class PizzaPriceTests
    {
        private PizzaService pizzaService;
        public PizzaPriceTests()
        {
            pizzaService = new PizzaService();
        }

        [Fact]
        public void FourCheeseTomatoPizzaCost_Should_Return_Ingredients_Prices()
        {
            //arrange
            var pizzaName = PizzaNameEnum.FourCheeseTomato;

            //act
            var pizzaPrice = pizzaService.GetPizzaPrice(pizzaName); 

            //assert
            Assert.Equal(1 + 2 + 4 + 2 +4, pizzaPrice);
        }

        [Fact]
        public void FourCheeseFreshCreamPizzaCost_Should_Return_Ingredients_Prices()
        {
            //arrange
            var pizzaName = PizzaNameEnum.FourCheeseFreshCream;

            //act
            var pizzaPrice = pizzaService.GetPizzaPrice(pizzaName);

            //assert
            Assert.Equal(1.5m + 2 + 4 + 2 + 4, pizzaPrice);
        }

        [Fact]
        public void BPMPizzaCost_Should_Return_Ingredients_Prices()
        {
            //arrange
            var pizzaName = PizzaNameEnum.BPM;

            //act
            var pizzaPrice = pizzaService.GetPizzaPrice(pizzaName);

            //assert
            Assert.Equal(2 + 2 + 4.5m + 6 + 5, pizzaPrice);
        }

        [Fact]
        public void PepperoniLoversPizzaCost_Should_Return_Ingredients_Prices()
        {
            //arrange
            var pizzaName = PizzaNameEnum.PepperoniLovers;

            //act
            var pizzaPrice = pizzaService.GetPizzaPrice(pizzaName);

            //assert
            Assert.Equal(1 + 2 + 6 , pizzaPrice);
        }

        [Fact]
        public void QueenPizzaCost_Should_Return_Ingredients_Prices()
        {
            //arrange
            var pizzaName = PizzaNameEnum.Queen;

            //act
            var pizzaPrice = pizzaService.GetPizzaPrice(pizzaName);

            //assert
            Assert.Equal(1 + 2 + 4.5m + 2, pizzaPrice);
        }

        [Fact]
        public void MountaineerPizzaCost_Should_Return_Ingredients_Prices()
        {
            //arrange
            var pizzaName = PizzaNameEnum.Mountaineer;

            //act
            var pizzaPrice = pizzaService.GetPizzaPrice(pizzaName);

            //assert
            Assert.Equal(1.5m + 2 + 4.5m +4 + 2, pizzaPrice);
        }

        [Fact]
        public void SupremePizzaCost_Should_Return_Ingredients_Prices()
        {
            //arrange
            var pizzaName = PizzaNameEnum.Supreme;

            //act
            var pizzaPrice = pizzaService.GetPizzaPrice(pizzaName);

            //assert
            Assert.Equal(1 + 2 + 4.5m + 6 + 2 + 3.5m + 3, pizzaPrice);
        }
    }
}