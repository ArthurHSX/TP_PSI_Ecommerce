﻿using Microsoft.EntityFrameworkCore;
using Ecommerce_PSI.Models;

namespace Ecommerce_PSI.Context
{
    public class EcommerceContext : DbContext
    {
        #region Tables

        public DbSet<Usuario> Usuario { get; set; }

        #endregion

        // Adicionar depois o nome do arquivo de conexão do BD no método base("nome...")
        public EcommerceContext() : base()      
        {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Ecommerce_PSI;Trusted_Connection=True;");
        }
    }
}
