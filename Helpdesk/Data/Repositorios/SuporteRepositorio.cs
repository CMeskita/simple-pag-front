
using Data.Conexao;
using Helpdesk.Models.Entity;
using Helpdesk.Models.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helpdesk.Data.Repositorios
{
    public class SuporteRepositorio : ISuporteRepositorio
    {
        private readonly Context _context;

        public SuporteRepositorio(Context context)
        {
            _context = context;
        }

        public Task<Suporte> Add(Suporte dados)
        {
            throw new System.NotImplementedException();
        }

        public Task<Atendimento> FindById(string id)
        {
            throw new System.NotImplementedException();
        }

        public IList<Suporte> GetAll()
        {
            return _context.Suportes.ToList();
        }

        public Task UpdateAsync(Atendimento dados)
        {
            throw new System.NotImplementedException();
        }
    }
}
