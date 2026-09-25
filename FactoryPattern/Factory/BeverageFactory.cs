using System;
using FactoryPattern.Beverages;
using FactoryPattern.Condiments;

namespace FactoryPattern.Factory
{
    internal class BeverageFactory
    {
        public Beverage CreateFactoryBeverage(CoffeeType type, Size size)
        {
            Beverage beverage = type switch
            {
                CoffeeType.Espresso => new Beverages.Espresso(),
                CoffeeType.Doppio => new Condiments.Espresso(new Beverages.Espresso()),
                CoffeeType.Lungo => new Water(new Beverages.Espresso()),
                CoffeeType.Macchiato => new MilkFoam(new Beverages.Espresso()),
                CoffeeType.Corretta => new Liqour(new Beverages.Espresso()),
                CoffeeType.ConPanna => new Whip(new Beverages.Espresso()),
                CoffeeType.Cappuccino => new MilkFoam(new SteamedMilk(new Beverages.Espresso())),
                CoffeeType.Americano => new Water(new Water(new Beverages.Espresso())),
                CoffeeType.CaffeLatte => new MilkFoam(new SteamedMilk(new SteamedMilk(new Beverages.Espresso()))),
                CoffeeType.FlatWhite => new SteamedMilk(new SteamedMilk(new Beverages.Espresso())),
                CoffeeType.Romana => new Lemon(new Beverages.Espresso()),
                CoffeeType.Morocchino => new MilkFoam(new Condiments.Chocolate(new Beverages.Espresso())),
                CoffeeType.Mocha => new Whip(new SteamedMilk(new Condiments.Chocolate(new Beverages.Espresso()))),
                CoffeeType.Bicerin => new Whip(new WhiteChocolate(new BlackChocolate(new Beverages.Espresso()))),
                CoffeeType.Breve => new HalfMilk(new MilkFoam(new Beverages.Espresso())),
                CoffeeType.RafCoffee => new Cream(new VanillaSugar(new Beverages.Espresso())),
                CoffeeType.MeadRaf => new Cream(new Honey(new Beverages.Espresso())),
                CoffeeType.Galao => new MilkFoam(new MilkFoam(new Beverages.Espresso())),
                CoffeeType.CaffeAffogato => new IceCream(new Condiments.Espresso(new Beverages.Espresso())),
                CoffeeType.ViennaCoffee => new Whip(new Whip(new Condiments.Espresso(new Beverages.Espresso()))),
                CoffeeType.Glace => new IceCream(new Beverages.Espresso()),
                CoffeeType.ChocolateMilk => new Milk(new Milk(new Beverages.Chocolate())),
                CoffeeType.DemiCreme => new Cream(new Cream(new Condiments.Espresso(new Beverages.Espresso()))),
                CoffeeType.LatteMacchiato => new MilkFoam(new SteamedMilk(new SteamedMilk(new Beverages.Espresso()))),
                CoffeeType.Freddo => new Ice(new Liqour(new Beverages.Espresso())),
                CoffeeType.Frappuccino => new Whip(new SteamedMilk(new Ice(new Beverages.Espresso()))),
                CoffeeType.CaramelFrappuccino => new Syrup(new Cream(new SteamedMilk(new Ice(new Beverages.Espresso())))),
                CoffeeType.Frappe => new IceCream(new SteamedMilk(new SteamedMilk(new Beverages.Espresso()))),
                CoffeeType.IrishCoffee => new Whip(new Whiskey(new Condiments.Espresso(new Beverages.Espresso())))
            };

            beverage.Size = size;   
            return beverage;
        }

        public string CoffeName(CoffeeType type)
        {
            return type switch
            {
                CoffeeType.Espresso => "Espresso",
                CoffeeType.Doppio => "Doppio",
                CoffeeType.Lungo => "Lungo",
                CoffeeType.Macchiato => "Macchiato",
                CoffeeType.Corretta => "Corretta",
                CoffeeType.ConPanna => "Con Panna",
                CoffeeType.Cappuccino => "Cappucinno",
                CoffeeType.Americano => "Americano",
                CoffeeType.CaffeLatte => "Caffé Latte",
                CoffeeType.FlatWhite => "Flat White",
                CoffeeType.Romana => "Romana",
                CoffeeType.Morocchino => "Morocchino",
                CoffeeType.Mocha => "Mocha",
                CoffeeType.Bicerin => "Bicerin",
                CoffeeType.Breve => "Breve",
                CoffeeType.RafCoffee => "Raf coffee",
                CoffeeType.MeadRaf => "Mead raf",
                CoffeeType.Galao => "Galao",
                CoffeeType.CaffeAffogato => "Caffé affogato",
                CoffeeType.ViennaCoffee => "Vienna coffee",
                CoffeeType.Glace => "Glace",
                CoffeeType.ChocolateMilk => "Chocolate milk",
                CoffeeType.DemiCreme => "Demi – créme",
                CoffeeType.LatteMacchiato => "Latte macchiato",
                CoffeeType.Freddo => "Freddo",
                CoffeeType.Frappuccino => "Frappuccino",
                CoffeeType.CaramelFrappuccino => "Caramel frappuccino",
                CoffeeType.Frappe => "Frappe",
                CoffeeType.IrishCoffee => "Irish Coffee"
            };
        }
    }
}
