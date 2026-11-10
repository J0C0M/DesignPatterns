namespace TemplateMethodPattern
{
    internal class ChocolateMilkWithHook : CaffeineBeverageWithHook
    {
        public override void Brew()
        {
            Console.WriteLine("Mixing chocolate with milk");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Whipcream");
        }

        public override bool CustomerWantsCondement()
        {
            Console.WriteLine("Would you like whipcream with your chocolate milk y/n?");
            string answer = Console.ReadLine();
            return answer.ToLower().StartsWith('y');
        }
    }
}
