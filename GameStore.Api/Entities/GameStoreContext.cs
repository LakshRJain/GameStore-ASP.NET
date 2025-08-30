using System;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Api.Entities;

public class GameStoreContext(DbContextOptions<GameStoreContext> options) : DbContext(options)
{
    public DbSet<Game> Games => Set<Game>();
    public DbSet<Genre> Genres => Set<Genre>();
}
