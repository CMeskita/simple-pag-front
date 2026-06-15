using Data.Conexao;
using Helpdesk.Models.Entity;
using Helpdesk.Models.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Helpdesk.Data.Repositorios
{
    public class AuditoriaRepsitorio : IAuditoriaRepsitorio
    {
        private readonly Context _context;

        public AuditoriaRepsitorio(Context context)
        {
            _context = context;
        }

        public Task<AuditoriaSuporte> Add(AuditoriaSuporte objeto)
        {
            throw new System.NotImplementedException();
        }

        public Task<AuditoriaSuporte> FindById(string id)
        {
            throw new System.NotImplementedException();
        }

        public IList<AuditoriaSuporte> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
