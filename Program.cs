using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using pulCurrency;

// issue created for error CS0246: link: https://developercommunity.visualstudio.com/t/error-CS0246:-The-type-or-namespace-name/10550647
namespace currencyTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void convertCurrency(double amount, string currency)
            {
                switch (currency)
                {
                    case "EUR":
                        double eurAmount = Euro.ConvertToEuro(amount);
                        Console.WriteLine("The amount of: " + amount + " USD converted to Euros is: " + eurAmount + " " + currency);
                        break;
                    case "JPY":
                        double jpyAmount = Yen.ConvertToYen(amount);
                        Console.WriteLine("The amount of: " + amount + " USD converted to Yens is: " + jpyAmount + " " + currency);
                        break;
                    case "USD":
                        Console.WriteLine("The amount of: " + amount + " USD converted to USD is: " + amount + " " + currency);
                        break;
                    default:
                        Console.WriteLine("Currency not supported");
                        break;
                }
            }
            double amt = 100;
            string euros = Euro.GetSymbol();
            string yens = Yen.GetSymbol();
            string dollars = USDollar.GetSymbol();
            string[] symbolArray = new string[] { euros, yens, dollars };
            foreach (string currency in symbolArray)
            {
                convertCurrency(amt, currency);
            }
        }
    }
}
