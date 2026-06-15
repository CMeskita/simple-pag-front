
using Helpdesk.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace Data.Conexao
{
    public class Context : DbContext

    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        public virtual DbSet<Suporte> Suportes { get; set; }
        public virtual DbSet<Setor> Setor { get; set; }

        public virtual DbSet<Perfil> Perfil { get; set; }




    }
}
