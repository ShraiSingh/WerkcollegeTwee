using System;
using WerkcollegeTweeLib;

namespace WerkcollegeTwee
{
    class Program
    {
        static void Main(string[] args)
        {
            var rekening = new Account("BE23 2938 3838 9393", 1000, 2.0);

            while (true)
            {
                Console.WriteLine(rekening);
                Console.WriteLine("Acties: [D]eposit, [W]ithdraw");
                var input = Console.ReadKey();
                if (input.Key == ConsoleKey.D)
                {
                    Console.WriteLine("\nAmount to deposit:");
                    var amount = Console.ReadLine();
                    rekening.Deposit(double.Parse(amount));
                }
                else if (input.Key == ConsoleKey.W)
                {
                    Console.WriteLine("\nAmount to withdraw:");
                    var amount = Console.ReadLine();
                    rekening.Withdraw(double.Parse(amount));
                }
                else
                {
                    Console.WriteLine("Foutieve input");
                }
            }

        }
    }
}
