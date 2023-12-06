using Microsoft.EntityFrameworkCore;
using Projeto_Login.Models;

namespace Projeto_Login.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<Cidade>? Cidade { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<EntradaProduto> EntradaProduto { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Pais> Pais { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<SaidaProduto> SaidaProduto { get; set; }
        public DbSet<Tipoproduto> Tipoproduto { get; set; }
        public DbSet<TipoSaida> TipoSaida { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        
    }
}
