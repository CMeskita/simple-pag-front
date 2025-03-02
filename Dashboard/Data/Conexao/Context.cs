using Dashboard.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Conexao
{
    public class Context : DbContext

    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }
        public virtual DbSet<Usuario> Usuarios { get; set; }
 
     
    }
}
