using Microsoft.EntityFrameworkCore;
using Ecommerce.Models;

namespace Ecommerce_PSI.DBContext
{
    public class UsuarioContext  : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
    }
}
