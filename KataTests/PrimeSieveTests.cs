using Xunit;

namespace PrimeSieveTest
{
    public class PrimeSieveTests
    {
        [Fact]
        public void TestZero()
        {
            var sievedPrimes = PrimeSieve.Siever.Sieve(0);

            var expectedPrimes = new int[]{};

            Assert.Equal(expectedPrimes, sievedPrimes);
        }

        [Fact]
        public void TestFirstPrime()
        {
            var sievedPrimes = PrimeSieve.Siever.Sieve(2);

            var expectedPrimes = new[] {2};

            Assert.Equal(expectedPrimes, sievedPrimes);
        }

        [Fact]
        public void TestFirstFive()
        {
            var sievedPrimes = PrimeSieve.Siever.Sieve(11);

            var expectedPrimes = new[] {2, 3, 5, 7, 11};

            Assert.Equal(expectedPrimes, sievedPrimes);
        }

        [Fact]
        public void TestOneThousandthPrime()
        {
            const int thousandthPrime = 7919;
            var sievedPrimes = PrimeSieve.Siever.Sieve(10000);

            Assert.True(sievedPrimes.Length >= 1000);
            Assert.Equal(thousandthPrime, sievedPrimes[999]); // Account for zero-indexing
        }

        [Fact]
        public void TestTenThousandthPrime()
        {
            const int tenThousandthPrime = 104729;
            var sievedPrimes = PrimeSieve.Siever.Sieve(1000000);

            Assert.True(sievedPrimes.Length > 9999);
            Assert.Equal(tenThousandthPrime, sievedPrimes[9999]);
        }
    }
}
