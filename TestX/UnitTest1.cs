using Xunit;
using ProjectEuler;
namespace TestX;

public class UnitTest1
{
        [Fact]
        public void Problem1Test()
        {
            Problem prob = new Problem1();
            Assert.Equal(prob.getSolution(),"233168");
        }
        [Fact]
        public void Problem2Test()
        {
            Problem prob = new Problem2();
            Assert.Equal(prob.getSolution(),"4613732");
        }
        [Fact]
        public void Problem3Test()
        {
            Problem prob = new Problem3();
            Assert.Equal(prob.getSolution(),"6857");
        }
}