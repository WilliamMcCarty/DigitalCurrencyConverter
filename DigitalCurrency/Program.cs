using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalCurrency
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal dCashBalance = 5000.00m;
            decimal dBitCoin = 7480.00m;
            decimal dEtherium = 586.15m;
            decimal dLiteCoin = 119.04m;
            string sExit = "N";
            do
            {
                Console.WriteLine("[P] Purchase Digital Currency\n[S] Sell Digital Currency\n[V] View Account Account Balances\n[T] Transfer Between Digital Currency Types\n[X] Exit");
                ConsoleKey userChoice = Console.ReadKey().Key;
                Console.Clear();

                switch (userChoice)
                {
                    case ConsoleKey.P:
                        break;
                    case ConsoleKey.S:
                        break;
                    case ConsoleKey.V:
                        Console.Clear();
                        Console.WriteLine($"Cash Balance: {dCashBalance:c}\nBitCoin: {dBitCoin:c}\nEtherium: {dEtherium:c}\nLiteCoin: {dLiteCoin:c}\nSelect Valid Option From Menu Below To Continue\n\n");
                        break;
                    case ConsoleKey.T:
                        Console.Clear();
                        Console.WriteLine("Transfer From:\n[C] Cash\n[B] BitCoin\n[E] Etherium\n[L] LiteCoin");
                        ConsoleKey transferFrom = Console.ReadKey().Key;
                        Console.WriteLine("Transfer To:\n[C] Cash\n[B] BitCoin\n[E] Etherium\n[L] LiteCoin");
                        ConsoleKey transferTo = Console.ReadKey().Key;
                        Console.WriteLine("Amount: ");
                        decimal dAmountToTransfer = decimal.Parse(Console.ReadLine());


                        break;
                    case ConsoleKey.X:
                        sExit = "X";
                        break;
                    default:
                        Console.WriteLine("You have picked a invalied selection, please try again.");
                        break;
                }


            } while (sExit.ToUpper() != "X");

            Console.WriteLine("Thank you for your business.");
        }
    }
}
