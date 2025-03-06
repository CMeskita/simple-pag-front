using Dashboard.Models;
using Dashboard.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace Data.Conexao
{
    public class Context : DbContext

    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<FormaPagamento>FormaPagamentos{ get; set; }
        public virtual DbSet<Finalizadora> Finalizadoras { get; set; }
        public virtual DbSet<FinalizadoraPagamento> FinalizadoraPagamentos { get; set; }


    }
}
