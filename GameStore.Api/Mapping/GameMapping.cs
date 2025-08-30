using System;
using GameStore.Api.Dtos;
using GameStore.Api.Entities;

namespace GameStore.Api.Mapping;

public static class GameMapping
{
    public static Game ToEntity(this CreateGameDto dto)
    {
        return new Game()
        {
            Name = dto.Name,
            GenreId = dto.GenreId,
            Price = dto.Price,
            ReleaseDate = dto.ReleaseDate
        };
    }
    public static Game ToEntity(this UpdateGameDto dto , int id)
    {
        return new Game()
        {
            Name = dto.Name,
            Id = id,
            GenreId = dto.GenreId,
            Price = dto.Price,
            ReleaseDate = dto.ReleaseDate
        };
    }
    
    public static GameSummaryDto ToGameSummaryDto(this Game entity)
    {
        return new GameSummaryDto(
            entity.Id,
            entity.Name,
            entity.Genre!.Name,
            entity.Price,
            entity.ReleaseDate
        );
    }
    public static GameDetailsDto ToGameDetailsDto(this Game entity)
    {
        return new GameDetailsDto(
            entity.Id,
            entity.Name,
            entity.GenreId,
            entity.Price,
            entity.ReleaseDate
        );
    }
}
