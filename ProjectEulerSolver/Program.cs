// See https://aka.ms/new-console-template for more information
using ProjectEulerSolver;
Console.WriteLine("Wellcome to my project euler problem solverdo!");

Console.WriteLine("enter problem number to solve - enter xx to exit");
string line;
int probNum;
var listOfProblems = ProblemHelpers.ProblemList;
PrintProblems(listOfProblems);
Console.Write("\nEnter a number [1-{0}] xx to exit: ",listOfProblems.Count);

while ((line = Console.ReadLine()) != "xx")
{
    if (int.TryParse(line, out probNum) && probNum >= 1 && probNum <= listOfProblems.Count)
    {
        Console.WriteLine("The answer to problem #{0} is {1}",probNum,listOfProblems[probNum-1].problem.GetSolution());
    }
    else
    {
        Console.WriteLine("\nThat is not a number [1-{0}]",listOfProblems.Count);
    }
    Console.Write("\nEnter a number [1-{0}] xx to exit:",listOfProblems.Count);
}

void PrintProblems(List<(IProblem problem, ProblemDescription description)> problems)
{
    foreach (var problem in problems)
    {
        Console.WriteLine("#:{0} Name:{1}", problem.description.ProblemNumber ,problem.description.Name);
    }
}