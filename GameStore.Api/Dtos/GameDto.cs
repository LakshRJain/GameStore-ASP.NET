namespace GameStore.Api.Dtos;

public record class GameDto(
    int Id,
    string Name,
    String Genre ,
    decimal Price ,
    DateOnly ReleaseDate 
);