﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Wellcome to my project euler problem solverdo!");

Console.WriteLine("enter problem number to solve - enter xx to exit");
string line;
int probNum;
while((line = Console.ReadLine()) != "xx")
{
    if(int.TryParse(line,out probNum) && probNum >= 1 && probNum <= 11){
        String typeName = "ProjectEulerSolver.Problem"+probNum;
        Type type = Type.GetType(typeName);
        ProjectEulerSolver.IProblem prob = (ProjectEulerSolver.IProblem) Activator.CreateInstance( type);
        Console.WriteLine(prob.GetSolution());
    }
    else {
        Console.WriteLine("Enter a number [1-10]");
    }
}
