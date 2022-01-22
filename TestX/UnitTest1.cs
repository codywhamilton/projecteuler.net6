using Xunit;
using System;
namespace TestX;


public class UnitTest1
{
    [Theory]
    [InlineData(typeof(ProjectEuler.Problem1), "233168")]
    [InlineData(typeof(ProjectEuler.Problem2), "4613732")]
    [InlineData(typeof(ProjectEuler.Problem3), "6857")]
    [InlineData(typeof(ProjectEuler.Problem4), "906609")]
    [InlineData(typeof(ProjectEuler.Problem5), "232792560")]
    [InlineData(typeof(ProjectEuler.Problem6), "25164150")]
    public void CheckEuler(Type type, string correctAnswer)
    {
                ProjectEuler.Problem prob = (ProjectEuler.Problem) Activator.CreateInstance( type);
                Assert.Equal(correctAnswer,prob.getSolution());
    }

}