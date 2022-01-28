var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/GetProblemList", () =>
{
    return ProjectEulerSolver.ProblemHelpers.GetProblemDescriptions();
});

app.MapGet("/SolveProblem/{id}", (int id) =>
{
    return ProjectEulerSolver.ProblemHelpers.ProblemList[id-1].problem.GetSolution();
});

app.Run();