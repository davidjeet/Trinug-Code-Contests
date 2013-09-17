using NUnit.Framework;
using Primes.Model;
using System.Diagnostics;

namespace Primes.Test {

    [TestFixture]
    public class NUnitTests 
    {

        [Test]
        public void Test_Number_Divisble_By_Three_Is_Not_Prime()
        {
            var test = 9576; // An Divisible By 3 
            Assert.IsFalse(ComputePrimes.IsPrime(test));
        }


        [Test]
        public void Test_Number_Divisble_By_Five_Is_Not_Prime()
        {
            var test = 78315; // An Divisible By 5 (i.e. ends in a '5')
            Assert.IsFalse(ComputePrimes.IsPrime(test));
        }


        [Test]
        public void Test_Known_Prime_Is_Prime()
        {
            var test = 37; // A known prime
            Assert.IsTrue(ComputePrimes.IsPrime(test));
        }


        [Test]
        public void Test_Known_NonPrime_Is_Not_Prime()
        {
            var test = 39; // A known on-prime (divisible by 3)
            Assert.IsFalse(ComputePrimes.IsPrime(test));

        }


        [Test]
        public void Test_Computer_Primes_UpTo_1000()
        {
            var n = 1000;
            var list = ComputePrimes.ReturnPrimes(n);
            Assert.AreEqual(list.Count, 168); // refer to http://primes.utm.edu/howmany.shtml 
        }


        [Test]
        public void Test_Computer_Primes_UpTo_10000()
        {
            var n = 10000;
            var list = ComputePrimes.ReturnPrimes(n);
            Assert.AreEqual(list.Count, 1229); // refer to http://primes.utm.edu/howmany.shtml
        }


    }

}
