using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en addition eller en subtraktion");
            string tal = Console.ReadLine();
            
            //Console.WriteLine(" ");

            string[] input2 = tal.Split('+', '-');

            double tal1 = double.Parse(input2[0]);
            double tal2 = double.Parse(input2[1]);

            if (tal.Contains("+"))
            {
                double svar1 = tal1 + tal2;

                Console.WriteLine($"Ditt svar blir {svar1} ");
            }

            else if (tal.Contains("-"))
            {
                double svar2 = tal1 - tal2;

                Console.WriteLine($"Ditt svar blir {svar2} ");
            }

            else
            {
                Console.WriteLine("Kunde tyvär inte lösa ditt tal, tästa igen om det inte funkar kontaka mig så kan jag hjälpa.");
            }
        }
    }
}



