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
        [Description("Sauce tomate à l'origan, mozzarella, jambon et champignons frais")]
        Queen,
        [Description("Crème fraîche légère, mozzarella, jambon cru, fromage à raclette et champignons frais")]
        Mountaineer,
        [Description("Sauce tomate à l'origan, mozzarella, emietté au boeuf, saucisse pepperoni, champignons frais, oignons rouges frais et poivrons verts frais")]
        Supreme,
        [Description("Crème fraîche légère, mozzarella, pommes de terre, lardons et fromage à raclette")]
        Raclette,
        [Description("Crème fraîche légère, mozzarella, fromage de chèvre, miel")]
        HoneyGoat,
        [Description("Crème fraîche légère, mozzarella et saumon fumé de Norvège")]
        Nordic,
        [Description("Crème fraîche légère, mozzarella, lardons, oignons rouges frais et champignons frais")]
        Campagnard,
        [Description("Sauce tomate à l'origan, mozzarella, merguez, Poulet rôti, oignons rouges frais, Sauce Samouraï")]
        Samurai,
        [Description("Sauce tomate à l'origan, mozzarella, Poulet rôti, tomates fraîches, parmigiano reggiano AOP")]
        ChikenPermesan,
        [Description("Sauce tomate à l'origan, mozzarella, champignons frais, oignons rouges frais, poivrons verts frais, tomates fraîches et Olives noires")]
        Vegetarian,
        [Description("Sauce tomate à l'origan, mozzarella, jambon et ananas")]
        HawaiianHam
    }
}
