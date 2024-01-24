using System.Data.Entity;
using KlusterIO.Business.Models.Fornecedores;
using KlusterIO.Business.Models.Produtos;

namespace KlusterIO.Infra.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base(" DefaultConnection") { }
        
        
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
    }
}