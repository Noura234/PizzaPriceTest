namespace PizzaPrice.Ingredients
{
    public abstract class Ingredient
    {
        private readonly decimal _price;
        private readonly IngredientCategoryEnum _category;

        public Ingredient(decimal price, IngredientCategoryEnum category)
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