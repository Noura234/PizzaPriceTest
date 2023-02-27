namespace PizzaPrice.Ingredients
{
    public abstract class Ingredient
    {
        private readonly decimal _price;
        private readonly string _category;

        public Ingredient(decimal price, string category)
        {
            this._price = price;
            this._category = category;
        }

        public decimal GetPrice()
        {
            return _price;
        }
    }
}