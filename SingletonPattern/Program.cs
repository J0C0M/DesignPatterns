using System.Threading;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler[] results = new ChocolateBoiler[10];
            Thread[] threads = new Thread[results.Length];

            for (int i = 0; i < threads.Length; i++)
            {
                int index = i;
                threads[i] = new Thread(() => results[index] = ChocolateBoiler.GetInstance());
                threads[i].Start();
            }

            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            bool allSameInstance = true;
            foreach (ChocolateBoiler result in results)
            {
                if (!ReferenceEquals(result, results[0]))
                {
                    allSameInstance = false;
                }
            }

            Console.WriteLine(allSameInstance
                ? "Very goed: Alle threads kregen dezelfde ChocolateBoiler instance."
                : "Error: Er zijn meerdere ChocolateBoiler instances aangemaakt");
        }
    }
}