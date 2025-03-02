using Dashboard.Models;
using Dashboard.Models.Interface;
using Data.Conexao;
using System.Threading.Tasks;

namespace Dashboard.Data.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly Context _context;

        public UsuarioRepositorio(Context context)
        {
            _context = context;
        }

        public async Task AddUsuario(Usuario usuario)
        {
            await _context.Usuarios.AddAsync(usuario);
           _context.SaveChanges();
        }
    }
}
