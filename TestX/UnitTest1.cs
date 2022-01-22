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
}