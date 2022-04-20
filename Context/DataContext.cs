using EFCoreConsole.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCoreConsole.Context
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Pooling=true;Database=EFCore;User Id=postgres;Password=1234");

        }
        public DbSet<Livro> Livros { get; set; }
    }
}