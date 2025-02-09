using System;
using Gamestore.Api.Dtos;

namespace Gamestore.Api.Endpoints;

public static class GamesEndpoints
{
    const string GetGameEndpointName = "GetGame";

    private static readonly List<GameDto> games = [
        new GameDto(1, "Halo", "Shooter", 59.99m, new DateOnly(2021, 11, 15)),  //m represents decimal value
        new GameDto(2, "FIFA 22", "Sports", 59.99m, new DateOnly(2021, 10, 1)),
        new GameDto(3, "Forza Horizon 5", "Racing", 59.99m, new DateOnly(2021, 11, 9)),
        new GameDto(4, "Call of Duty: Vanguard", "Shooter", 59.99m, new DateOnly(2021, 11, 5)),
        new GameDto(5, "Battlefield 2042", "Shooter", 59.99m, new DateOnly(2021, 11, 19))
    ];

    public static RouteGroupBuilder MapGamesEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("games")
                       .WithParameterValidation();
        //Create a group of endpoints with the path games.
        
        // GET /games
        group.MapGet("/", () => games); 
        // in " " we can use / or games. It will refer to games because we are in the group of games. 

        // GET /games/1
        group.MapGet("/{id}", (int id) => 
        {
            GameDto? game = games.Find(g => g.Id == id); //Find the game with the given id

            return game is null ? Results.NotFound() : Results.Ok(game); 
            //If game is null then return NotFound() else return Ok(game)

        })
        .WithName(GetGameEndpointName);

        //Post /games
        group.MapPost("/", (CreateGameDto newGame) => 
        {
            GameDto game = new(
                games.Count + 1,
                newGame.Name,
                newGame.Genre,
                newGame.Price,
                newGame.ReleaseDate
            );

            games.Add(game);

            return Results.CreatedAtRoute(GetGameEndpointName, new {id = game.Id}, game); 
            
            //GetGameEndpointName is the name of the route we want to redirect to after creating a new game like /games/6 (It Basically we gave the name to the Get endpoint)
        
        });


        //Put /games
        group.MapPut("/{id}", (int id, UpdateGameDto updatedGame) => 
        {
            var index = games.FindIndex(game => game.Id == id);

            if(index == -1){
                return Results.NotFound(); 
                //If the game with the given id is not found then index return -1 and it compare with the index == -1 and return notfound().
            }

            games[index] = new GameDto(
                id,
                updatedGame.Name,
                updatedGame.Genre,
                updatedGame.Price,
                updatedGame.ReleaseDate
            );

            return Results.NoContent();
        });

        group.MapDelete("/{id}", (int id) =>

        {
            games.RemoveAll(game => game.Id == id);

            return Results.NoContent();
        });

        return group;
    }

}
