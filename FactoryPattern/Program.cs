using FactoryPattern.Beverages;
using FactoryPattern.Factory;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BeverageFactory factory = new BeverageFactory();

            factory.OrderDrink(CoffeeType.Espresso, Size.TALL);
            factory.OrderDrink(CoffeeType.Doppio, Size.GRANDE);
            factory.OrderDrink(CoffeeType.Lungo, Size.VENDI);
            factory.OrderDrink(CoffeeType.Macchiato, Size.VENDI);
            factory.OrderDrink(CoffeeType.Corretta, Size.GRANDE);
            factory.OrderDrink(CoffeeType.ConPanna, Size.GRANDE);
            factory.OrderDrink(CoffeeType.Cappuccino, Size.GRANDE);
            factory.OrderDrink(CoffeeType.Americano, Size.VENDI);
            factory.OrderDrink(CoffeeType.CaffeLatte, Size.VENDI);
            factory.OrderDrink(CoffeeType.FlatWhite, Size.VENDI);
            factory.OrderDrink(CoffeeType.Romana, Size.VENDI);
            factory.OrderDrink(CoffeeType.Morocchino, Size.VENDI);
            factory.OrderDrink(CoffeeType.Mocha, Size.VENDI);
            factory.OrderDrink(CoffeeType.Bicerin, Size.VENDI);
            factory.OrderDrink(CoffeeType.Breve, Size.VENDI);
            factory.OrderDrink(CoffeeType.RafCoffee, Size.VENDI);
            factory.OrderDrink(CoffeeType.MeadRaf, Size.VENDI);
            factory.OrderDrink(CoffeeType.Galao, Size.VENDI);
            factory.OrderDrink(CoffeeType.CaffeAffogato, Size.VENDI);
            factory.OrderDrink(CoffeeType.ViennaCoffee, Size.VENDI);
            factory.OrderDrink(CoffeeType.Glace, Size.VENDI);
            factory.OrderDrink(CoffeeType.ChocolateMilk, Size.VENDI);
            factory.OrderDrink(CoffeeType.DemiCreme, Size.VENDI);
            factory.OrderDrink(CoffeeType.LatteMacchiato, Size.VENDI);
            factory.OrderDrink(CoffeeType.Freddo, Size.VENDI);
            factory.OrderDrink(CoffeeType.Frappuccino, Size.VENDI);
            factory.OrderDrink(CoffeeType.CaramelFrappuccino, Size.VENDI);
            factory.OrderDrink(CoffeeType.Frappe, Size.VENDI);
            factory.OrderDrink(CoffeeType.IrishCoffee, Size.VENDI);
        }
    }
}
