using System.Linq.Expressions;
using KarateChop;
using Xunit;

namespace PrimeSieveTest
{
    public class KarateChopTests
    {
        [Fact]
        public void EmptyArray()
        {
            Assert.Equal(-1, Chopper.Chop(3, new int[] { }));
        }

        [Fact]
        public void NotInArray()
        {
            Assert.Equal(-1, Chopper.Chop(3, new[] { 1 }));
        }

        [Fact]
        public void LongArray()
        {
            int[] ints = new int[20];
            for (var i = 0; i < 20; i++)
            {
                ints[i] = i;
            }

            foreach (var i in ints)
            {
                Assert.Equal(i, Chopper.Chop(i, ints));
            }
        }
    }
}
