using Dashboard.Models;
using Dashboard.Models.Dto;
using Dashboard.Models.Interface;
using Data.Conexao;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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

        public bool ExisteUsuario(string email)
        {
            Usuario usuario = _context.Usuarios.FirstOrDefault(x => x.Email == email);
            return (usuario != null);
        }
        public  IList<Usuario>GetAllUsuarios()
        {
            return _context.Usuarios.ToList();
            
        }
        public async Task<Usuario> FindUsuarioById(string id)
        {
            return await _context.Usuarios.FindAsync(id);
        }
        public async Task UpdateAsync(DtoUsuario dados)
        {

            //await _context.Database.ExecuteSqlRawAsync($@"Update FROM itemdopedido WHERE pedidoid ='{pedido}'");

            //_context.Entry(dados).State = (Microsoft.EntityFrameworkCore.EntityState)System.Data.Entity.EntityState.Added;
            //await _context.AddRangeAsync();
            //_context.Usuarios.Update(dados);

            //await _context.SaveChangesAsync();

        }
        public async Task InativarUsuario(string id)
        {
            var dados = _context.Usuarios.Where(x => x.Id == id).FirstOrDefault();
            if (dados == null)
            {
                throw new Exception("Usuário não encontrado");
            }
            dados.Inativar();

            _context.Usuarios.Attach(dados).Property(x => x.Status).IsModified = true;
            await _context.SaveChangesAsync();
        }
    }
}
