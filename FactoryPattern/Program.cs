using System;
using FactoryPattern.Beverages;
using FactoryPattern.Condiments;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Beverages.Espresso();
            espresso.Size = Size.TALL;
            PrintBeverage("Espresso", espresso);

            Beverage doppio = new Beverages.Espresso();
            doppio.Size = Size.GRANDE;
            doppio = new Condiments.Espresso(doppio);
            PrintBeverage("Doppio", doppio);

            Beverage lungo = new Beverages.Espresso();
            lungo.Size = Size.VENDI;
            lungo = new Water(lungo);
            PrintBeverage("Lungo", lungo);

            Beverage macchiato = new Beverages.Espresso();
            macchiato.Size = Size.VENDI;
            macchiato = new MilkFoam(macchiato);
            PrintBeverage("Macchiato", macchiato);

            Beverage corretta = new Beverages.Espresso();
            corretta.Size = Size.GRANDE;
            corretta = new Liqour(corretta);
            PrintBeverage("Corretta", corretta);

            Beverage conpanna = new Beverages.Espresso();
            conpanna.Size = Size.GRANDE;
            conpanna = new Whip(conpanna);
            PrintBeverage("Con Panna", conpanna);

            Beverage cappucinno = new Beverages.Espresso();
            cappucinno.Size = Size.GRANDE;
            cappucinno = new SteamedMilk(cappucinno);
            cappucinno = new MilkFoam(cappucinno);
            PrintBeverage("Cappucinno", cappucinno);

            Beverage americano = new Beverages.Espresso();
            americano.Size = Size.VENDI;
            americano = new Water(americano);
            americano = new Water(americano);
            PrintBeverage("Americano", americano);

            Beverage caffélatte = new Beverages.Espresso();
            caffélatte.Size = Size.VENDI;
            caffélatte = new SteamedMilk(caffélatte);
            caffélatte = new SteamedMilk(caffélatte);
            caffélatte = new MilkFoam(caffélatte);
            PrintBeverage("Caffé Latte", caffélatte);

            Beverage flatwhite = new Beverages.Espresso();
            flatwhite.Size = Size.VENDI;
            flatwhite = new SteamedMilk(flatwhite);
            flatwhite = new SteamedMilk(flatwhite);
            PrintBeverage("Flat White", flatwhite);

            Beverage romana = new Beverages.Espresso();
            romana.Size = Size.VENDI;
            romana = new Lemon(romana);
            PrintBeverage("Romana", romana);

            Beverage morocchino = new Beverages.Espresso();
            morocchino.Size = Size.VENDI;
            morocchino = new Condiments.Chocolate(morocchino);
            morocchino = new MilkFoam(morocchino);
            PrintBeverage("Morocchino", morocchino);

            Beverage mocha = new Beverages.Espresso();
            mocha.Size = Size.VENDI;
            mocha = new Condiments.Chocolate(mocha);
            mocha = new SteamedMilk(mocha);
            mocha = new Whip(mocha);
            PrintBeverage("Mocha", mocha);

            Beverage bicerin = new Beverages.Espresso();
            bicerin.Size = Size.VENDI;
            bicerin = new BlackChocolate(bicerin);
            bicerin = new WhiteChocolate(bicerin);
            bicerin = new Whip(bicerin);
            PrintBeverage("Bicerin", bicerin);

            Beverage breve = new Beverages.Espresso();
            breve.Size = Size.VENDI;
            breve = new MilkFoam(breve);
            breve = new HalfMilk(breve);
            PrintBeverage("Breve", breve);

            Beverage rafcoffee = new Beverages.Espresso();
            rafcoffee.Size = Size.VENDI;
            rafcoffee = new VanillaSugar(rafcoffee);
            rafcoffee = new Cream(rafcoffee);
            PrintBeverage("Raf coffee", rafcoffee);

            Beverage meadraf = new Beverages.Espresso();
            meadraf.Size = Size.VENDI;
            meadraf = new Honey(meadraf);
            meadraf = new Cream(meadraf);
            PrintBeverage("Mead raf", meadraf);

            Beverage galao = new Beverages.Espresso();
            galao.Size = Size.VENDI;
            galao = new MilkFoam(galao);
            galao = new MilkFoam(galao);
            PrintBeverage("Galao", galao);

            Beverage cafféaffogato = new Beverages.Espresso();
            cafféaffogato.Size = Size.VENDI;
            cafféaffogato = new Condiments.Espresso(cafféaffogato);
            cafféaffogato = new IceCream(cafféaffogato);
            PrintBeverage("Caffé affogato", cafféaffogato);

            Beverage viennacoffee = new Beverages.Espresso();
            viennacoffee.Size = Size.VENDI;
            viennacoffee = new Condiments.Espresso(viennacoffee);
            viennacoffee = new Whip(viennacoffee);
            viennacoffee = new Whip(viennacoffee);
            PrintBeverage("Vienna coffee", viennacoffee);

            Beverage glace = new Beverages.Espresso();
            glace.Size = Size.VENDI;
            glace = new IceCream(glace);
            PrintBeverage("Glace", glace);

            Beverage chocolatemilk = new Beverages.Chocolate();
            chocolatemilk.Size = Size.VENDI;
            chocolatemilk = new Milk(chocolatemilk);
            chocolatemilk = new Milk(chocolatemilk);
            PrintBeverage("Chocolate milk", chocolatemilk);

            Beverage democréme = new Beverages.Espresso();
            democréme.Size = Size.VENDI;
            democréme = new Condiments.Espresso(democréme);
            democréme = new Cream(democréme);
            democréme = new Cream(democréme);
            PrintBeverage("Demi – créme", democréme);

            Beverage lattemacchiato = new Beverages.Espresso();
            lattemacchiato.Size = Size.VENDI;
            lattemacchiato = new SteamedMilk(lattemacchiato);
            lattemacchiato = new SteamedMilk(lattemacchiato);
            lattemacchiato = new MilkFoam(lattemacchiato);
            PrintBeverage("Latte macchiato", lattemacchiato);

            Beverage freddo = new Beverages.Espresso();
            freddo.Size = Size.VENDI;
            freddo = new Liqour(freddo);
            freddo = new Ice(freddo);
            PrintBeverage("Freddo", freddo);

            Beverage frapppuccino = new Beverages.Espresso();
            frapppuccino.Size = Size.VENDI;
            frapppuccino = new Ice(frapppuccino);
            frapppuccino = new SteamedMilk(frapppuccino);
            frapppuccino = new Whip(frapppuccino);
            PrintBeverage("Frappuccino", frapppuccino);

            Beverage caramelfrappuccino = new Beverages.Espresso();
            caramelfrappuccino.Size = Size.VENDI;
            caramelfrappuccino = new Ice(caramelfrappuccino);
            caramelfrappuccino = new SteamedMilk(caramelfrappuccino);
            caramelfrappuccino = new Cream(caramelfrappuccino);
            caramelfrappuccino = new Syrup(caramelfrappuccino);
            PrintBeverage("Caramel frappuccino", caramelfrappuccino);

            Beverage frappe = new Beverages.Espresso();
            frappe.Size = Size.VENDI;
            frappe = new SteamedMilk(frappe);
            frappe = new SteamedMilk(frappe);
            frappe = new IceCream(frappe);
            PrintBeverage("Frappe", frappe);

            Beverage irishcoffee = new Beverages.Espresso();
            irishcoffee.Size = Size.VENDI;
            irishcoffee = new Condiments.Espresso(irishcoffee);
            irishcoffee = new Whiskey(irishcoffee);
            irishcoffee = new Whip(irishcoffee);
            PrintBeverage("Irish Coffee", irishcoffee);
        }

        static void PrintBeverage(string name, Beverage beverage)
        {
            Console.WriteLine(name + ": " + beverage.GetDescription() + beverage.cost().ToString(" #.##") + " euro");
        }
    }
}