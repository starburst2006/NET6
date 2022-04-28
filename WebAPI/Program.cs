using PrvniKonzolovaApp.Data;
using PrvniKonzolovaApp.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();



app.MapGet("/person", () => RandomPersonGenerator.GetRandomPerson());

app.MapGet("/people", () => RandomPersonGenerator.GetPeople(10));

app.Run();


