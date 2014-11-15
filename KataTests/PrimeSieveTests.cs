using Xunit;

namespace PrimeSieveTest
{
    public class PrimeSieveTests
    {
        [Fact]
        public void TestZero()
        {
            int[] actualPrimes = PrimeSieve.Siever.Sieve(0);

            var expectedPrimes = new int[]{};

            Assert.Equal(expectedPrimes, actualPrimes);
        }

        [Fact]
        public void TestFirstPrime()
        {
            int[] actualPrimes = PrimeSieve.Siever.Sieve(2);

            var expectedPrimes = new int[] {2};

            Assert.Equal(expectedPrimes, actualPrimes);
        }

        [Fact]
        public void TestFirstFive()
        {
            int[] actualPrimes = PrimeSieve.Siever.Sieve(11);

            var expectedPrimes = new int[] {2, 3, 5, 7, 11};

            Assert.Equal(expectedPrimes, actualPrimes);
        }
    }
}
