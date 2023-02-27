namespace PizzaPrice.Ingredients
{
    public class Tomato
    {
        private readonly int _price;
        private readonly string _category;

        public Tomato(int price, string category)
        {
            this._price = price;
            this._category = category;
        }
    }
}