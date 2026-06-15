
using Helpdesk.Models.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Helpdesk.Models.Interface
{
    public interface IClienteRespositorio
    {
        Task Add(Cliente dados);
        IList<Cliente>GetAll();
        Task<Cliente>FindById(string id);
        Task<Cliente> ExisteClienteEmail(string email);
        bool ExisteCliente(string email);
        Task Inativar(string id);
        Task UpdateAsync(Cliente dados);
    }
}
