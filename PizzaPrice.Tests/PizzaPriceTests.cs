namespace PizzaPrice.Tests
{
    public class PizzaPriceTests
    {
        [Fact]
        public void FourCheeseTomatoPizzaCost_Should_Return_Ingredients_Prices_13()
        {
            //arrange
            var pizzaName = "FourCheeseTomato";
            var pizzaService = new PizzaService();

            //act
            var pizzaPrice = pizzaService.GetPizzaPrice(pizzaName); 

            //assert
            Assert.Equal(13, pizzaPrice);
        }
    }
}