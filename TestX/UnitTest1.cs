using Xunit;
using System;
namespace TestX;


public class UnitTest1
{
    [Theory]
    [InlineData(typeof(ProjectEulerSolver.Problem1), "233168")]
    [InlineData(typeof(ProjectEulerSolver.Problem2), "4613732")]
    [InlineData(typeof(ProjectEulerSolver.Problem3), "6857")]
    [InlineData(typeof(ProjectEulerSolver.Problem4), "906609")]
    [InlineData(typeof(ProjectEulerSolver.Problem5), "232792560")]
    [InlineData(typeof(ProjectEulerSolver.Problem6), "25164150")]
    [InlineData(typeof(ProjectEulerSolver.Problem7), "104743")]
    [InlineData(typeof(ProjectEulerSolver.Problem8), "23514624000")]
    [InlineData(typeof(ProjectEulerSolver.Problem9), "31875000")]
    [InlineData(typeof(ProjectEulerSolver.Problem10), "142913828922")]
    [InlineData(typeof(ProjectEulerSolver.Problem11), "70600674")]
    [InlineData(typeof(ProjectEulerSolver.Problem12), "76576500")]
    public void CheckEuler(Type type, string correctAnswer)
    {
        ProjectEulerSolver.IProblem prob = (ProjectEulerSolver.IProblem)Activator.CreateInstance(type);
        Assert.Equal(correctAnswer, prob.GetSolution());
    }

}