namespace TemplateMethodPattern
{
    public class ChocolateMilk : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Mixing chocolate with milk");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Whipcream");
        }
    }
}
