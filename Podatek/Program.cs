using System;

namespace Podatek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wprowadź wartość zakupów: ");
            double valueOfPurchases = double.Parse(Console.ReadLine());

            //double taxState = valueOfPurchases * 0.04;
            //double taxCounty = valueOfPurchases  * 0.02;


            //double valueOfTaxes = taxState + taxCounty;
            //double valueOfEvrything = valueOfPurchases + valueOfTaxes;

            Calculate(valueOfPurchases);

            //Console.WriteLine($"Wartość podatku w stnaie {taxState}");
            //Console.WriteLine($"Wartość podatku w hrabstwie {taxCounty}");
            //Console.WriteLine($"Wartość podatków {valueOfTaxes}");
            //Console.WriteLine($"Wszystkie wartość {valueOfEvrything}");
            //Console.WriteLine($"Wartość zakupów to {valueOfPurchases}");

        }
        public static void Calculate(double valueOfPurchases)
        {
            double taxState = valueOfPurchases * 0.04;
            double taxCounty = valueOfPurchases * 0.02;


            double valueOfTaxes = taxState + taxCounty;
            double valueOfEvrything = valueOfPurchases + valueOfTaxes;
            Console.WriteLine($"Wartość podatku w stnaie {taxState}");
            Console.WriteLine($"Wartość podatku w hrabstwie {taxCounty}");
            Console.WriteLine($"Wartość podatków {valueOfTaxes}");
            Console.WriteLine($"Wszystkie wartość {valueOfEvrything}");
            Console.WriteLine($"Wartość zakupów to {valueOfPurchases}");
        }
       
    }
}
