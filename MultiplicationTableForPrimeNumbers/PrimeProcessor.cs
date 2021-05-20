using System;
using System.Collections.Generic;
using System.Text;

namespace MultiplicationTableForPrimeNumbers
{
    /// <summary>
    /// This class processes the generated prime numbers.
    /// </summary>
    public class PrimeProcessor
    {
        /// <summary>
        /// This method generate a multiplication grid.
        /// </summary>
        /// <param name="primeNumbers">List of input prime numbers.</param>
        /// <returns>A multiplication grid or table</returns>
        public List<List<UInt64>> GetMultiplicationGrid(List<UInt64> primeNumbers)
        {            
            List<List<UInt64>> grid = new List<List<UInt64>>();
            int index = 0;

            foreach (UInt64 outerPrime in primeNumbers)
            {
                grid.Add(new List<UInt64>());
                foreach (UInt64 innerPrime in primeNumbers)
                {
                    grid[index].Add(outerPrime * innerPrime);
                }
                index++;
            }
            return grid;
        }
    }
}
