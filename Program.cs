using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500);

            Menu();
             

        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("GO...");
            Thread.Sleep(2500);

            Start(time);
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0s = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string userInput = Console.ReadLine().ToLower();

            char type = char.Parse(userInput.Substring(userInput.Length - 1, 1));
            int time = int.Parse(userInput.Substring(0, userInput.Length - 1));
            int multiplier = 1;

            if(type == 'm')
                multiplier = 60;
                
            if(time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplier);
            

        }
    }
}
