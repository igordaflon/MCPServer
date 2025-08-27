using System.Reflection;
using FiapGames.API.Entidades;
using Microsoft.EntityFrameworkCore;

namespace FiapGames.API.Data.Contexts;

public class FiapGamesDbContext : DbContext
{
    public FiapGamesDbContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    public DbSet<Jogo> Jogos { get; set; }
}
