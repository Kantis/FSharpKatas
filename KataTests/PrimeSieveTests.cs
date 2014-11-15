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
            int[] actualPrimes = PrimeSieve.Siever.Sieve(1);

            var expectedPrimes = new int[] {2};

            Assert.Equal(expectedPrimes, actualPrimes);
        }
    }
}
