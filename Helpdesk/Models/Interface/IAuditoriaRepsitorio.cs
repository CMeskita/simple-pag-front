
using Helpdesk.Models.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Helpdesk.Models.Interface
{
    public interface IAuditoriaRepsitorio
    {
        Task<AuditoriaSuporte> Add(AuditoriaSuporte objeto);
        IList<AuditoriaSuporte> GetAll();
        Task<AuditoriaSuporte> FindById(string id);
    }
}
