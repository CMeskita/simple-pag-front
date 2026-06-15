using Data.Conexao;
using Helpdesk.Models.Entity;
using Helpdesk.Models.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helpdesk.Data.Repositorios
{
    public class ClienteRespositorio : IClienteRespositorio
    {
        private readonly Context _context;

        public ClienteRespositorio(Context context)
        {
            _context = context;
        }

        public async Task Add(Cliente dados)
        {
            
            await _context.Clientes.AddAsync(dados);
            _context.SaveChanges();
        }

        public async Task<Cliente> FindById(string id)
        {
            return await _context.Clientes.FindAsync(id);
        }

        public IList<Cliente> GetAll()
        {
            return _context.Clientes.ToList();
        }

        public async Task UpdateAsync(Cliente dados)
        {
           _context.Clientes.Update(dados);
            _context.Entry(dados).Property(p => p.Registro).IsModified = false;
            _context.Entry(dados).Property(p => p.Status).IsModified = false;
            await _context.SaveChangesAsync();

        }
        public async Task<Cliente> ExisteClienteEmail(string email)
        {
            var response=await _context.Clientes.FindAsync(email);
            return response;

        }
        public bool ExisteCliente(string email)
        {
            Cliente cliente = _context.Clientes.FirstOrDefault(x => x.Email == email);
            return (cliente != null);
        }
        public async Task Inativar(string id)
        {
            var dados = _context.Clientes.Where(x => x.Id == id).FirstOrDefault();
            if (dados != null)
            {
                dados.SetStatus(false);

                _context.Clientes.Attach(dados).Property(x => x.Status).IsModified = true;
                await _context.SaveChangesAsync();

            }

        }
    }
}
