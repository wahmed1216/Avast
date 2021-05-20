using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiplicationTableForPrimeNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var primeCalculator = new PrimeGenerator();
            var result = new Program();
            var primeMultiplication = new PrimeProcessor();

            while (true)
            {
                var primeNumbers = primeCalculator.GeneratePrimeNumbers(result.Helper());
                var primeNumberGrid = primeMultiplication.GetMultiplicationGrid(primeNumbers);

                //Display multiplicationGrid on console. This is most time consuming part of the
                //program which can be improved depending on where we consume the Multiplication Grid/Table.
                Console.Write("{0,0}{1,7}", "|", "|");
                foreach (int prime in primeNumbers)
                {
                    Console.Write("{0,5}{1,2}", prime, "|");
                }
                Console.WriteLine();
                for (int i = 0; i < primeNumberGrid.Count(); i++)
                {
                    Console.Write("{0,0}{1,5}{2,2}", "|", primeNumbers[i], "|");
                    for (int j = 0; j < primeNumberGrid.Count(); j++)
                    {
                        Console.Write("{0,5}{1,2}", primeNumberGrid[i][j], "|");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        private UInt64 Helper()
        {
            string userInput = "";
            UInt64 input = 0;
            while (!(UInt64.TryParse(userInput, out input) && input >= 1))
            {
                Console.WriteLine("Please input a number geater than 0:");
                userInput = Console.ReadLine();
            }
            return input;
        }
    }
}
