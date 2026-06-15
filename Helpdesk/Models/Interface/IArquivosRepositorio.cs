using Helpdesk.Models.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Helpdesk.Models.Interface
{
    public interface IArquivosRepositorio
    {
        Task<Arquivos> Add(Arquivos objeto);
        IList<Arquivos> GetAll();
        Task<Arquivos> FindById(string id);

  
    }
}
