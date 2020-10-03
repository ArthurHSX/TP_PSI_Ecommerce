using Microsoft.EntityFrameworkCore;
using Ecommerce.Models;

namespace Ecommerce.Context
{
    public class EcommerceContext : DbContext
    {
        // Adicionar depois o nome do arquivo de conexão do BD no método base("nome...")
        public EcommerceContext() : base()      
        {}

        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Ecommerce_PSI;Trusted_Connection=True;");
        }
    }
}
