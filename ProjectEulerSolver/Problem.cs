using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEulerSolver
{
    public interface IProblem
    {
        public String GetSolution();
        public ProblemDescription GetProblemDescription();
    }
    public struct ProblemDescription
    {
        public ProblemDescription(string name, int number, string descripton)
        {
            Name = name;
            ProblemNumber = number;
            Description = descripton;
        }
        public string Name { get; init; }
        public int ProblemNumber { get; init; }
        public string Description { get; init; }

    }
}