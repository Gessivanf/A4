using Exo.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Exo.WebApi.Contexts
{
  public class ExoContext : DbContext
  {
    public ExoContext()
    {
    }
    public ExoContext(DbContextOptions<ExoContext> options) : base(options)
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        // Essa string de conexão foi depende da SUA máquina.
        optionsBuilder.UseSqlServer("User ID=sa;Password=1234;Server=localhost\\SQLEXPRESS;Database=ExoApi;"
       + " Trusted_Connection=False;");

        // Exemplo 1 de string de conexão:

        //Server=localhost\\SQLEXPRESS01;"               
        // + "Database=ExoApi;Trusted_Connection=True

        // Exemplo 2 de string de conexão:
        // Server=localhost\\SQLEXPRESS;Database=ExoApi;Trusted_Connection=True;
      }
    }
    public DbSet<Projeto> Projetos { get; set; }
  }
}
