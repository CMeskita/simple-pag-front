using Data.Conexao;
using Helpdesk.Models.Entity;
using Helpdesk.Models.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Helpdesk.Data.Repositorios
{
    public class ArquivosRepositorio : IArquivosRepositorio
    {
        private readonly Context _context;

        public ArquivosRepositorio(Context context)
        {
            _context = context;
        }

        public Task<Arquivos> Add(Arquivos objeto)
        {
            throw new System.NotImplementedException();
        }

        public Task<Arquivos> FindById(string id)
        {
            throw new System.NotImplementedException();
        }

        public IList<Arquivos> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
