using Microsoft.EntityFrameworkCore;
using Ecommerce.Models;

namespace Ecommerce.Context
{
    public class EcommerceContext : DbContext
    {
        #region Tables

        public DbSet<Usuario> Usuario { get; set; }

        #endregion

        public EcommerceContext() : base()      
        {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Ecommerce_PSI;Trusted_Connection=True;");
        }

    }
}
