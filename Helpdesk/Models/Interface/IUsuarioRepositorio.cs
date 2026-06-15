using Dashboard.Models.Dto;
using Helpdesk.Models.Entity;
using System;
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
        Task<Usuario> FindUsuarioEmail(string emai, string senha);
        Task<Usuario> ExisteUsuarioEmail(string email);

        #region AtributosSuporte
        IList<Perfil> GetAllPerfil();
        IList<Setor> GetAllSetor();
        #endregion
    }
}
