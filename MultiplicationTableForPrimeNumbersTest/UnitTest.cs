using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiplicationTableForPrimeNumbers;
using System;
using System.Collections.Generic;

namespace MultiplicationTableForPrimeNumbersTest
{
    [TestClass]
    public class UnitTest
    {
        #region GeneratePrimeNumber Tests

        /// <summary>
        /// Test whether GeneratePrimeNumbers method generates 1 prime number.
        /// </summary>
        [TestMethod]
        public void CallingGeneratePrimeNumbersMethod_When1IsPassedThenOnePrimeNumberGetsGenerated()
        {
            //Arrange
            PrimeGenerator prime = new PrimeGenerator();

            //Act
            List<UInt64> primes = prime.GeneratePrimeNumbers(1);

            //Assert
            Assert.AreEqual((UInt64)2, primes[0]);
        }

        /// <summary>
        /// Test whether GeneratePrimeNumbers method generates 3 prime numbers.
        /// </summary>
        [TestMethod]
        public void CallingGeneratePrimeNumbersMethod_When3IsPassedThenFivePrimeNumbersGetGenerated()
        {
            //Arrnage
            PrimeGenerator prime = new PrimeGenerator();
            List<UInt64> expected = new List<UInt64>() { (UInt64)2, (UInt64)3, (UInt64)5 };

            //Act
            List<UInt64> primes = prime.GeneratePrimeNumbers(3);

            //Assert
            CollectionAssert.AreEqual(expected, primes);
        }

        /// <summary>
        /// Test whether GeneratePrimeNumbers method generates 5 prime numbers.
        /// </summary>
        [TestMethod]
        public void CallingGenerateGeneratePrimeNumbersMethod_When5IsPassedThenFivePrimeNumbersGetGenerated()
        {
            //Arrange
            PrimeGenerator prime = new PrimeGenerator();
            List<UInt64> expected = new List<UInt64>() { (UInt64)2, (UInt64)3, (UInt64)5, (UInt64)7, (UInt64)11 };

            //Act
            List<UInt64> primes = prime.GeneratePrimeNumbers(5);

            //Assert
            CollectionAssert.AreEqual(expected, primes);
        }

        /// <summary>
        /// Test whether GeneratePrimeNumbers method generates 10 prime numbers.
        /// </summary>
        [TestMethod]
        public void CallingGeneratePrimeNumbersMethod_When10IsPassedThenFivePrimeNumbersGetGenerated()
        {
            //Arrange
            PrimeGenerator prime = new PrimeGenerator();
            List<UInt64> expected = new List<UInt64>() { (UInt64)2, (UInt64)3, (UInt64)5, (UInt64)7, (UInt64)11, (UInt64)13, (UInt64)17, (UInt64)19, (UInt64)23, (UInt64)29 };

            //Act
            List<UInt64> primes = prime.GeneratePrimeNumbers(10);

            //Assert
            CollectionAssert.AreEqual(expected, primes);
        }

        #endregion

        #region GetMultiplicationGrid Tests

        [TestMethod]
        public void CallingPrimeMultiplicationMethod_WhenListOf1PrimeNumberIsPassedThenMultiplicationGridIsGenerated()
        {
            //Arrange
            PrimeProcessor multiplicationGrid = new PrimeProcessor();
            List<UInt64> provided = new List<UInt64>() { (UInt64)2};
            List<List<UInt64>> expected = new List<List<UInt64>>();
            expected.Add(new List<UInt64> { (UInt64)4});

            //Act
            List<List<UInt64>> returned = multiplicationGrid.GetMultiplicationGrid(provided);

            //Assert
            CollectionAssert.AreEqual(expected[0], returned[0]);
        }

        [TestMethod]
        public void CallingPrimeMultiplicationMethod_WhenListOf3PrimeNumberIsPassedThenMultiplicationGridIsGenerated()
        {
            //Arrange
            PrimeProcessor multiplicationGrid = new PrimeProcessor();
            List<UInt64> provided = new List<UInt64>() { (UInt64)2, (UInt64)3, (UInt64)5 };
            List<List<UInt64>> expected = new List<List<UInt64>>();
            expected.Add(new List<UInt64> { (UInt64)4, (UInt64)6, (UInt64)10 });
            expected.Add(new List<UInt64> { (UInt64)6, (UInt64)9, (UInt64)15 });
            expected.Add(new List<UInt64> { (UInt64)10, (UInt64)15, (UInt64)25 });

            //Act
            List<List<UInt64>> returned = multiplicationGrid.GetMultiplicationGrid(provided);

            //Assert
            CollectionAssert.AreEqual(expected[0], returned[0]);
            CollectionAssert.AreEqual(expected[1], returned[1]);
            CollectionAssert.AreEqual(expected[2], returned[2]);
        }

        [TestMethod]
        public void CallingPrimeMultiplicationMethod_WhenListOf5PrimeNumberIsPassedThenMultiplicationGridIsGenerated()
        {
            //Arrange
            PrimeProcessor multiplicationGrid = new PrimeProcessor();
            List<UInt64> provided = new List<UInt64>() { (UInt64)2, (UInt64)3, (UInt64)5, (UInt64)7, (UInt64)11 };
            List<List<UInt64>> expected = new List<List<UInt64>>();
            expected.Add(new List<UInt64> { (UInt64)4, (UInt64)6, (UInt64)10, (UInt64)14, (UInt64)22 });
            expected.Add(new List<UInt64> { (UInt64)6, (UInt64)9, (UInt64)15, (UInt64)21, (UInt64)33 });
            expected.Add(new List<UInt64> { (UInt64)10, (UInt64)15, (UInt64)25, (UInt64)35, (UInt64)55 });
            expected.Add(new List<UInt64> { (UInt64)14, (UInt64)21, (UInt64)35, (UInt64)49, (UInt64)77 });
            expected.Add(new List<UInt64> { (UInt64)22, (UInt64)33, (UInt64)55, (UInt64)77, (UInt64)121 });

            //Act
            List<List<UInt64>> returned = multiplicationGrid.GetMultiplicationGrid(provided);

            //Assert
            CollectionAssert.AreEqual(expected[0], returned[0]);
            CollectionAssert.AreEqual(expected[1], returned[1]);
            CollectionAssert.AreEqual(expected[2], returned[2]);
            CollectionAssert.AreEqual(expected[3], returned[3]);
            CollectionAssert.AreEqual(expected[4], returned[4]);
        }


        [TestMethod]
        public void CallingPrimeMultiplicationMethod_WhenListOf10PrimeNumberIsPassedThenMultiplicationGridIsGenerated()
        {
            //Arrange
            PrimeProcessor multiplicationGrid = new PrimeProcessor();
            List<UInt64> provided = new List<UInt64>() { (UInt64)2, (UInt64)3, (UInt64)5, (UInt64)7, (UInt64)11, (UInt64)13, (UInt64)17, (UInt64)19, (UInt64)23, (UInt64)29 };
            List<List<UInt64>> expected = new List<List<UInt64>>();
            expected.Add(new List<UInt64> { (UInt64)4, (UInt64)6, (UInt64)10, (UInt64)14, (UInt64)22, (UInt64)26, (UInt64)34, (UInt64)38, (UInt64)46, (UInt64)58 });
            expected.Add(new List<UInt64> { (UInt64)6, (UInt64)9, (UInt64)15, (UInt64)21, (UInt64)33, (UInt64)39, (UInt64)51, (UInt64)57, (UInt64)69, (UInt64)87 });
            expected.Add(new List<UInt64> { (UInt64)10, (UInt64)15, (UInt64)25, (UInt64)35, (UInt64)55, (UInt64)65, (UInt64)85, (UInt64)95, (UInt64)115, (UInt64)145 });
            expected.Add(new List<UInt64> { (UInt64)14, (UInt64)21, (UInt64)35, (UInt64)49, (UInt64)77, (UInt64)91, (UInt64)119, (UInt64)133, (UInt64)161, (UInt64)203 });
            expected.Add(new List<UInt64> { (UInt64)22, (UInt64)33, (UInt64)55, (UInt64)77, (UInt64)121, (UInt64)143, (UInt64)187, (UInt64)209, (UInt64)253, (UInt64)319 });
            expected.Add(new List<UInt64> { (UInt64)26, (UInt64)39, (UInt64)65, (UInt64)91, (UInt64)143, (UInt64)169, (UInt64)221, (UInt64)247, (UInt64)299, (UInt64)377 });
            expected.Add(new List<UInt64> { (UInt64)34, (UInt64)51, (UInt64)85, (UInt64)119, (UInt64)187, (UInt64)221, (UInt64)289, (UInt64)323, (UInt64)391, (UInt64)493 });
            expected.Add(new List<UInt64> { (UInt64)38, (UInt64)57, (UInt64)95, (UInt64)133, (UInt64)209, (UInt64)247, (UInt64)323, (UInt64)361, (UInt64)437, (UInt64)551 });
            expected.Add(new List<UInt64> { (UInt64)46, (UInt64)69, (UInt64)115, (UInt64)161, (UInt64)253, (UInt64)299, (UInt64)391, (UInt64)437, (UInt64)529, (UInt64)667 });
            expected.Add(new List<UInt64> { (UInt64)58, (UInt64)87, (UInt64)145, (UInt64)203, (UInt64)319, (UInt64)377, (UInt64)493, (UInt64)551, (UInt64)667, (UInt64)841 });

            //Act
            List<List<UInt64>> returned = multiplicationGrid.GetMultiplicationGrid(provided);

            //Assert
            CollectionAssert.AreEqual(expected[0], returned[0]);
            CollectionAssert.AreEqual(expected[1], returned[1]);
            CollectionAssert.AreEqual(expected[2], returned[2]);
            CollectionAssert.AreEqual(expected[3], returned[3]);
            CollectionAssert.AreEqual(expected[4], returned[4]);
            CollectionAssert.AreEqual(expected[5], returned[5]);
            CollectionAssert.AreEqual(expected[6], returned[6]);
            CollectionAssert.AreEqual(expected[7], returned[7]);
            CollectionAssert.AreEqual(expected[8], returned[8]);
            CollectionAssert.AreEqual(expected[9], returned[9]);
        }
        #endregion
    }
}
