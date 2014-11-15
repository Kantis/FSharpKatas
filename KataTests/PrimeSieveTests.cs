using Xunit;

namespace PrimeSieveTest
{
    public class PrimeSieveTests
    {
        [Fact]
        public void TestZero()
        {
            int[] sievedPrimes = PrimeSieve.Siever.Sieve(0);

            var expectedPrimes = new int[]{};

            Assert.Equal(expectedPrimes, sievedPrimes);
        }

        [Fact]
        public void TestFirstPrime()
        {
            int[] sievedPrimes = PrimeSieve.Siever.Sieve(2);

            var expectedPrimes = new int[] {2};

            Assert.Equal(expectedPrimes, sievedPrimes);
        }

        [Fact]
        public void TestFirstFive()
        {
            int[] sievedPrimes = PrimeSieve.Siever.Sieve(11);

            var expectedPrimes = new int[] {2, 3, 5, 7, 11};

            Assert.Equal(expectedPrimes, sievedPrimes);
        }

        [Fact]
        public void TestOneThousandthPrime()
        {
            int thousandthPrime = 7919;
            int[] sievedPrimes = PrimeSieve.Siever.Sieve(10000);

            Assert.True(sievedPrimes.Length >= 1000);
            Assert.Equal(thousandthPrime, sievedPrimes[999]); // Account for zero-indexing
        }
    }
}
