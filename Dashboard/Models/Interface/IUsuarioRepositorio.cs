using System.Threading.Tasks;

namespace Dashboard.Models.Interface
{
    public interface IUsuarioRepositorio
    {
        Task AddUsuario(Usuario usuario);
    }
}
