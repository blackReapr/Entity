using ConsoleApp3.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp3.DAL;


internal class DataContext:DbContext
{
    public DbSet<Movie> Movies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=SASKE;Database=imdb;Trusted_Connection=True;TrustServerCertificate=Yes");
        base.OnConfiguring(optionsBuilder);
    }
}
