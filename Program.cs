using PersonApi.Model;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/nom-complet", () =>
{
    return "Laamiri Yassine";
});

app.MapPost("/person", (Person person) =>
{
    return Results.Ok(person);
});

app.Run();