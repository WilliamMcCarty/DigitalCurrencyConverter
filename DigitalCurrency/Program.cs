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
                        Console.Clear();
                        Console.WriteLine($"Purchase Digital Currency:\n[B] BitCoin {dBitCoin:c}\n[E] Etherium {dEtherium:c}\n[L] LiteCoin {dLiteCoin:c}");
                        ConsoleKey buy = Console.ReadKey().Key;
                        Console.WriteLine("Amount: ");
                        decimal dAmountToBuy = decimal.Parse(Console.ReadLine());
                        switch (buy)
                        {
                            case ConsoleKey.B:
                                dBitCoin = dBitCoin + dAmountToBuy;
                                dCashBalance = dCashBalance - dAmountToBuy;
                                break;
                            case ConsoleKey.E:
                                dEtherium = dEtherium + dAmountToBuy;
                                dCashBalance = dCashBalance - dAmountToBuy;
                                break;
                            case ConsoleKey.L:
                                dLiteCoin = dLiteCoin + dAmountToBuy;
                                dCashBalance = dCashBalance - dAmountToBuy;
                                break;
                            default:
                                break;
                        }
                        break;
                    case ConsoleKey.S:
                        Console.Clear();
                        Console.WriteLine($"Sell Digital Currency From:\n[B] BitCoin {dBitCoin:c}\n[E] Etherium {dEtherium:c}\n[L] LiteCoin {dLiteCoin:c}");
                        ConsoleKey sellFrom = Console.ReadKey().Key;
                        Console.WriteLine("Amount: ");
                        decimal dAmountToSell = decimal.Parse(Console.ReadLine());
                        switch (sellFrom)
                        {                            
                            case ConsoleKey.B:
                                dBitCoin = dBitCoin - dAmountToSell;
                                dCashBalance = dCashBalance + dAmountToSell;
                                break;
                            case ConsoleKey.E:
                                dEtherium = dEtherium - dAmountToSell;
                                dCashBalance = dCashBalance + dAmountToSell;
                                break;
                            case ConsoleKey.L:
                                dLiteCoin = dLiteCoin - dAmountToSell;
                                dCashBalance = dCashBalance + dAmountToSell;
                                break;
                            default:
                                break;
                        }

                        break;
                    case ConsoleKey.V:
                        Console.Clear();
                        Console.WriteLine($"Cash Balance: {dCashBalance:c}\nBitCoin: {dBitCoin:c}\nEtherium: {dEtherium:c}\nLiteCoin: {dLiteCoin:c}\nSelect Valid Option From Menu Below To Continue\n\n");
                        break;
                    case ConsoleKey.T:
                        Console.Clear();
                        Console.WriteLine($"Transfer From:\n[C] Cash {dCashBalance:c}\n[B] BitCoin {dBitCoin:c}\n[E] Etherium {dEtherium:c}\n[L] LiteCoin {dLiteCoin:c}");
                        ConsoleKey transferFrom = Console.ReadKey().Key;
                        Console.WriteLine("Transfer To:\n[C] Cash\n[B] BitCoin\n[E] Etherium\n[L] LiteCoin");
                        ConsoleKey transferTo = Console.ReadKey().Key;
                        Console.WriteLine("Amount: ");
                        decimal dAmountToTransfer = decimal.Parse(Console.ReadLine());

                        switch (transferFrom)
                        {
                            case ConsoleKey.C:
                                dCashBalance = dCashBalance - dAmountToTransfer;
                                break;
                            case ConsoleKey.B:
                                dBitCoin = dBitCoin - dAmountToTransfer;
                                break;
                            case ConsoleKey.E:
                                dEtherium = dEtherium - dAmountToTransfer;
                                break;
                            case ConsoleKey.L:
                                dLiteCoin = dLiteCoin - dAmountToTransfer;
                                break;
                            default:
                                break;
                        }

                        switch (transferTo)
                        {
                            case ConsoleKey.C:
                                dCashBalance = dCashBalance + dAmountToTransfer;
                                break;
                            case ConsoleKey.B:
                                dBitCoin = dBitCoin + dAmountToTransfer;
                                break;
                            case ConsoleKey.E:
                                dEtherium = dEtherium + dAmountToTransfer;
                                break;
                            case ConsoleKey.L:
                                dLiteCoin = dLiteCoin + dAmountToTransfer;
                                break;
                            default:
                                break;
                        }

                        Console.Clear();
                        Console.WriteLine($"Cash Balance: {dCashBalance:c}\nBitCoin: {dBitCoin:c}\nEtherium: {dEtherium:c}\nLiteCoin: {dLiteCoin:c}\nSelect Valid Option From Menu Below To Continue\n\n");
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
