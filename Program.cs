using Gamestore.Api.Dtos;
using Gamestore.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGamesEndpoints();

app.Run();
