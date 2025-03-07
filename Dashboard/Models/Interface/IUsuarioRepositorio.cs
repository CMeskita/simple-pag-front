using Dashboard.Models.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dashboard.Models.Interface
{
    public interface IUsuarioRepositorio
    {
        Task AddUsuario(Usuario usuario);
        bool ExisteUsuario(string email);
        IList<Usuario> GetAllUsuarios();
        Task<Usuario> FindUsuarioById(string id);
        Task InativarUsuario(string id);
        Task UpdateAsync(Usuario dados);

    }
}
