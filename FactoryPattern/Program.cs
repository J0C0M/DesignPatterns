using System;
using FactoryPattern.Beverages;
using FactoryPattern.Factory;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BeverageFactory factory = new BeverageFactory();

            PrintBeverage(factory, CoffeeType.Espresso, Size.TALL);
            PrintBeverage(factory, CoffeeType.Doppio, Size.GRANDE);
            PrintBeverage(factory, CoffeeType.Lungo, Size.VENDI);
            PrintBeverage(factory, CoffeeType.Macchiato, Size.VENDI);
            PrintBeverage(factory, CoffeeType.Corretta, Size.GRANDE);
            PrintBeverage(factory, CoffeeType.ConPanna, Size.GRANDE);
            PrintBeverage(factory, CoffeeType.Cappuccino, Size.GRANDE);
            PrintBeverage(factory, CoffeeType.Americano, Size.VENDI);
            PrintBeverage(factory, CoffeeType.CaffeLatte, Size.VENDI);
            PrintBeverage(factory, CoffeeType.FlatWhite, Size.VENDI);
            PrintBeverage(factory, CoffeeType.Romana, Size.VENDI);
            PrintBeverage(factory, CoffeeType.Morocchino, Size.VENDI);
            PrintBeverage(factory, CoffeeType.Mocha, Size.VENDI);
            PrintBeverage(factory, CoffeeType.Bicerin, Size.VENDI);
            PrintBeverage(factory, CoffeeType.Breve, Size.VENDI);
            PrintBeverage(factory, CoffeeType.RafCoffee, Size.VENDI);
            PrintBeverage(factory, CoffeeType.MeadRaf, Size.VENDI);
            PrintBeverage(factory, CoffeeType.Galao, Size.VENDI);
            PrintBeverage(factory, CoffeeType.CaffeAffogato, Size.VENDI);
            PrintBeverage(factory, CoffeeType.ViennaCoffee, Size.VENDI);
            PrintBeverage(factory, CoffeeType.Glace, Size.VENDI);
            PrintBeverage(factory, CoffeeType.ChocolateMilk, Size.VENDI);
            PrintBeverage(factory, CoffeeType.DemiCreme, Size.VENDI);
            PrintBeverage(factory, CoffeeType.LatteMacchiato, Size.VENDI);
            PrintBeverage(factory, CoffeeType.Freddo, Size.VENDI);
            PrintBeverage(factory, CoffeeType.Frappuccino, Size.VENDI);
            PrintBeverage(factory, CoffeeType.CaramelFrappuccino, Size.VENDI);
            PrintBeverage(factory, CoffeeType.Frappe, Size.VENDI);
            PrintBeverage(factory, CoffeeType.IrishCoffee, Size.VENDI);
        }

        static void PrintBeverage(BeverageFactory factory, CoffeeType type, Size size)
        {
            Beverage beverage = factory.CreateFactoryBeverage(type, size);
            Console.WriteLine(factory.CoffeName(type) + ": " + beverage.GetDescription() + beverage.cost().ToString(" #.##") + " euro");
        }
    }
}
