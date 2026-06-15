using Helpdesk.Models.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Helpdesk.Models.Interface
{
    public interface ISuporteRepositorio
    {
        Task<Suporte> Add(Suporte objeto);
        IList<Suporte> GetAll();
        Task<Atendimento> FindById(string id);
        Task UpdateAsync(Atendimento dados);
    }
}
