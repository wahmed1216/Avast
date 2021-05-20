using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiplicationTableForPrimeNumbers
{
    /// <summary>
    /// This class is responsible of generating prime numbers.
    /// </summary>
    public class PrimeGenerator
    {
        /// <summary>
        /// This method generate prime numbers.
        /// </summary>
        /// <param name="n">Input which defines how many prime numbers needs generating</param>
        /// <returns>List of prime numbers</returns>
        public List<UInt64> GeneratePrimeNumbers(UInt64 n)
        {
            List<UInt64> primeNumbers = new List<UInt64>() { 2 };  // list to store generated prime numbers and initialize with first prime number
            UInt64 count = 1, nextPrimeNumber = 3; // increment ammount and next prime
            while ((UInt64)primeNumbers.Count() < n)
            {
                int index = 0;
                while (primeNumbers[index] <= Math.Sqrt(nextPrimeNumber) && (nextPrimeNumber % primeNumbers[index] != 0)) // checking if next prime evenly divides with previous primes up to square root of next prime
                {
                    index++;
                }
                if (primeNumbers[index] > Math.Sqrt(nextPrimeNumber) && count == 1) // checking if current prime is greater than square root of next prime
                {
                    primeNumbers.Add(nextPrimeNumber);
                    count = 2;
                    nextPrimeNumber = nextPrimeNumber + 2; // 2 is only even prime number, increment by 2 after 3 to skip even numbers
                }

                else if (primeNumbers[index] > Math.Sqrt(nextPrimeNumber) && count == 2)
                {
                    primeNumbers.Add(nextPrimeNumber);
                    if (nextPrimeNumber == 5) // 3, 5, 7 are only case of triplets of prime numbers, this could be omited if min ammount of primes was 4 instead of 1, by using starting primes
                    {
                        count = 1;
                        nextPrimeNumber = nextPrimeNumber + 2;
                    }
                    else
                    {
                        count = 1;
                        nextPrimeNumber = nextPrimeNumber + 4; // skip 4 digits after encoutering twin primes
                    }
                }
                else
                {
                    count = 1;
                    nextPrimeNumber = nextPrimeNumber + 2;
                }
            }
            return primeNumbers;
        }
    }
}
