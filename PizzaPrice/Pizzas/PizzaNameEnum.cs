using System.ComponentModel;

namespace PizzaPrice.Pizzas
{
    public enum PizzaNameEnum
    {
        [Description("Sauce tomate à l'origan, mozzarella, fromage de chèvre, emmental et Fourme d'Ambert AOPe")]
        FourCheeseTomato,
        [Description("crème fraîche légère, mozzarella, fromage de chèvre, emmental et Fourme d'Ambert AOP")]
        FourCheeseFreshCream,
        [Description("Sauce barbecue, mozzarella, emietté au boeuf, Poulet rôti et merguez")]
        BPM,
        [Description("Sauce tomate à l'origan, mozzarella et saucisse pepperoni")]
        PepperoniLovers,
        Queen,
        Mountaineer,
        Supreme,
    }
}
