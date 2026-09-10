using System.Security.Cryptography.X509Certificates;
using StrategyPattern.Ducks;
using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            Duck redheadDuck = new RedheadDuck();
            Duck decoyDuck = new DecoyDuck();
            Duck rubberDuck = new RubberDuck();
            Duck robotDuck = new RobotDuck();
            Duck ModelDuck = new ModelDuck();
            MakeDuckPerformAll(mallardDuck);
            MakeDuckPerformAll(redheadDuck);
            MakeDuckPerformAll(decoyDuck);
            MakeDuckPerformAll(rubberDuck);
            MakeDuckPerformAll(robotDuck);
            MakeDuckPerformAll(ModelDuck);
            ModelDuck.SetflyBehavior(new FlyWithRocket());
            ModelDuck.PerformFly();
        }
        public static void MakeDuckPerformAll(Duck duck)
        {
            duck.Display();
            duck.PerformFly();
            duck.PerformQuack();
            duck.PerformSwim();
        }
    }
}