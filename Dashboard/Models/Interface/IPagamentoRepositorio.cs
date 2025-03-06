using Dashboard.Models.Entity;
using System.Threading.Tasks;

namespace Dashboard.Models.Interface
{
    public interface IPagamentoRepositorio
    {
        Task AddPagamento(FormaPagamento usuario);
        bool ExistePagamento(string sigla);
    }
}
