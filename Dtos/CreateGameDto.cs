using System.ComponentModel.DataAnnotations;

namespace Gamestore.Api.Dtos;

public record class CreateGameDto(

    [Required][StringLength(50)] string Name,
    
    //Required and Stringlength for post info validation after this post method will not validate then we have to use package like minimalapi.Validation.
    //using minimalapi.Validation package method withparametervalidation() those required and stringlength will be validated. 
    
    [Required][StringLength(20)] string Genre, 
    [Range(1,100)] decimal Price, 
    DateOnly ReleaseDate
);
