using Moq;
using PizzaPrice.Pizzas;

namespace PizzaPrice.Tests
{
    public class PizzaPriceTests
    {
        private PizzaService pizzaService;
        private Mock<IServiceProvider> serviceProvider;
        public PizzaPriceTests()
        {
            serviceProvider= new Mock<IServiceProvider>();
            pizzaService = new PizzaService(serviceProvider.Object);
        }

        [Fact]
        public void FourCheeseTomatoPizzaCost_Should_Return_Ingredients_Prices()
        {
            //arrange
            var pizzaName = PizzaNameEnum.FourCheeseTomato;
            serviceProvider.Setup(sp => sp.GetService(typeof(FourCheeseTomato)))
                .Returns(new FourCheeseTomato());

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
            serviceProvider.Setup(sp => sp.GetService(typeof(FourCheeseFreshCream)))
                .Returns(new FourCheeseFreshCream());

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
            serviceProvider.Setup(sp => sp.GetService(typeof(BPM)))
                .Returns(new BPM());

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
            serviceProvider.Setup(sp => sp.GetService(typeof(PepperoniLovers)))
                .Returns(new PepperoniLovers());

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
            serviceProvider.Setup(sp => sp.GetService(typeof(Queen)))
                .Returns(new Queen());

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
            serviceProvider.Setup(sp => sp.GetService(typeof(Mountaineer)))
                .Returns(new Mountaineer());

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
            serviceProvider.Setup(sp => sp.GetService(typeof(Supreme)))
                .Returns(new Supreme());

            //act
            var pizzaPrice = pizzaService.GetPizzaPrice(pizzaName);

            //assert
            Assert.Equal(1 + 2 + 4.5m + 6 + 2 + 3.5m + 3, pizzaPrice);
        }

        [Fact]
        public void RaclettePizzaCost_Should_Return_Ingredients_Prices()
        {
            //arrange
            var pizzaName = PizzaNameEnum.Raclette;
            serviceProvider.Setup(sp => sp.GetService(typeof(Raclette)))
                .Returns(new Raclette());

            //act
            var pizzaPrice = pizzaService.GetPizzaPrice(pizzaName);

            //assert
            Assert.Equal(1.5m + 2 + 3 + 5.5m + 4, pizzaPrice);
        }

        [Fact]
        public void HoneyGoatPizzaCost_Should_Return_Ingredients_Prices()
        {
            //arrange
            var pizzaName = PizzaNameEnum.HoneyGoat;
            serviceProvider.Setup(sp => sp.GetService(typeof(HoneyGoat)))
                .Returns(new HoneyGoat());

            //act
            var pizzaPrice = pizzaService.GetPizzaPrice(pizzaName);

            //assert
            Assert.Equal(1.5m + 2 + 4 + 5, pizzaPrice);
        }

        [Fact]
        public void NordicPizzaCost_Should_Return_Ingredients_Prices()
        {
            //arrange
            var pizzaName = PizzaNameEnum.Nordic;
            serviceProvider.Setup(sp => sp.GetService(typeof(Nordic)))
                .Returns(new Nordic());

            //act
            var pizzaPrice = pizzaService.GetPizzaPrice(pizzaName);

            //assert
            Assert.Equal(1.5m + 2 + 6, pizzaPrice);
        }

        [Fact]
        public void CampagnardPizzaCost_Should_Return_Ingredients_Prices()
        {
            //arrange
            var pizzaName = PizzaNameEnum.Campagnard;
            serviceProvider.Setup(sp => sp.GetService(typeof(Campagnard)))
                .Returns(new Campagnard());

            //act
            var pizzaPrice = pizzaService.GetPizzaPrice(pizzaName);

            //assert
            Assert.Equal(1.5m + 2 + 5.5m + 3.5m + 2, pizzaPrice);
        }

        [Fact]
        public void SamuraiPizzaCost_Should_Return_Ingredients_Prices()
        {
            //arrange
            var pizzaName = PizzaNameEnum.Samurai;
            serviceProvider.Setup(sp => sp.GetService(typeof(Samurai)))
                .Returns(new Samurai());

            //act
            var pizzaPrice = pizzaService.GetPizzaPrice(pizzaName);

            //assert
            Assert.Equal(1 + 2 + 5 + 6 + 3.5m + 1, pizzaPrice);
        }

        [Fact]
        public void ChikenPermesanPizzaCost_Should_Return_Ingredients_Prices()
        {
            //arrange
            var pizzaName = PizzaNameEnum.ChikenPermesan;
            serviceProvider.Setup(sp => sp.GetService(typeof(ChikenPermesan)))
                .Returns(new ChikenPermesan());

            //act
            var pizzaPrice = pizzaService.GetPizzaPrice(pizzaName);

            //assert
            Assert.Equal(1 + 2 + 6 + 3 + 5, pizzaPrice);
        }

        [Fact]
        public void VegetarianPizzaCost_Should_Return_Ingredients_Prices()
        {
            //arrange
            var pizzaName = PizzaNameEnum.Vegetarian;
            serviceProvider.Setup(sp => sp.GetService(typeof(Vegetarian)))
                .Returns(new Vegetarian());

            //act
            var pizzaPrice = pizzaService.GetPizzaPrice(pizzaName);

            //assert
            Assert.Equal(1 + 2 + 2 + 3.5m + 3 + 3 + 3, pizzaPrice);
        }

        [Fact]
        public void HawaiianHamPizzaCost_Should_Return_Ingredients_Prices()
        {
            //arrange
            var pizzaName = PizzaNameEnum.HawaiianHam;
            serviceProvider.Setup(sp => sp.GetService(typeof(HawaiianHam)))
                .Returns(new HawaiianHam());

            //act
            var pizzaPrice = pizzaService.GetPizzaPrice(pizzaName);

            //assert
            Assert.Equal(1 + 2 + 4.5m + 5, pizzaPrice);
        }
    }
}