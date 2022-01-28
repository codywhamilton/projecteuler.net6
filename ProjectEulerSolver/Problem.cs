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
        public ProblemDescription(string name, int number, string description)
        {
            Name = name;
            ProblemNumber = number;
            Description = description;
        }
        public string Name { get; init; }
        public int ProblemNumber { get; init; }
        public string Description { get; init; }

    }
    //to store methods to help solve problems and to deal with the problem metadata
    public static class ProblemHelpers
    {
        public static List<(IProblem problem, ProblemDescription description)> ProblemList { get;} = createProblemList();
        public static List<ProblemDescription> GetProblemDescriptions()
        {
            var list = from prob in ProblemList select prob.description;
            return list.ToList();
        }
        private static List<(IProblem problem, ProblemDescription description)> createProblemList()
        {
            var types = System.Reflection.Assembly.GetCallingAssembly().GetTypes()
                        .Where(m => m.IsClass && m.GetInterface("IProblem") != null);
            var listOfProblems = new List<(IProblem problem, ProblemDescription description)>();

            foreach (var type in types)
            {
                try
                {
                    IProblem problem = (IProblem)Activator.CreateInstance(type) ?? throw new Exception();
                    listOfProblems.Add((problem, problem.GetProblemDescription()));

                }
                catch (Exception e)
                {
                    //todo add error printing/logging of some kind
                }
            }
            return listOfProblems.OrderBy(d => d.description.ProblemNumber).ToList();
        }


    }
}