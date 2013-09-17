using System.Collections.Generic;

namespace Primes.Model
{
    public static class ComputePrimes
    {
        private static IList<int> primesList;

        /// <summary>
        /// Returns all the primes from 0 to maxValue.
        /// </summary>
        /// <param name="maxValue">The upper limit for the list of primes</param>
        /// <returns>IList of prime numbers</returns>
        public static IList<int> ReturnPrimes(int maxValue)
        {
            primesList = new List<int>();
            if (maxValue >= 2) primesList.Add(2); //optimization 1: front-loading the first 3 known primes
            if (maxValue >= 3) primesList.Add(3);
            if (maxValue >= 5) primesList.Add(5);
            // optimization 2: incrementing by 2 
            //(i.e. only checking odd numbers since the product of an even number with an odd number 
            // is always even and non-prime)
            for (int i = 7; i < maxValue; i += 2) 
            {
                if (IsPrime(i))
                    primesList.Add(i);
            }

            return primesList;
        }

        /// <summary>
        /// Determines whether the specified value is prime (but see remarks).
        /// </summary>
        /// <param name="val">The value we are testing to see if prime</param>
        /// <returns>true if value is prime</returns>
        /// <remarks>
        /// NOTE: This IsPrime method does not handle all cases of computing primes
        /// because is assuming a pre-optimized list of integers designed specifically to solve this code challenge.
        /// </remarks>
        public static bool IsPrime(int val)
        {
            bool retValue = true;
            if (val % 3 == 0) return false; // optimization 3: multiples of 3 are not primes
            if (val % 5 == 0) return false; // optimization 4: multiples of 5 are not primes

            int j = 1; //optimization 5: increment loop by diving by other prime numbers => hence primesList[j++] 
            for (double i = 5; i < ((val + i) / i); i = primesList[++j]) //optimization 6: loop as far as (val+i)/i, not val which would be excessive
            {
                if (val % i == 0)
                {
                    retValue = false;
                    break;
                }
            }
            return retValue;
        }

    }
}