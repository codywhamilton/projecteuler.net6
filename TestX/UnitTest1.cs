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
    [InlineData(typeof(ProjectEuler.Problem7), "104743")]
    [InlineData(typeof(ProjectEuler.Problem8), "23514624000")]
    [InlineData(typeof(ProjectEuler.Problem9), "31875000")]
    [InlineData(typeof(ProjectEuler.Problem10), "142913828922")]
    public void CheckEuler(Type type, string correctAnswer)
    {
                ProjectEuler.IProblem prob = (ProjectEuler.IProblem) Activator.CreateInstance( type);
                Assert.Equal(correctAnswer,prob.GetSolution());
    }

}