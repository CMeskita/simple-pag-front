using Dashboard.Models.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dashboard.Models.Interface
{
    public interface IPagamentoRepositorio
    {
        Task AddPagamento(FormaPagamento usuario);
        bool ExistePagamento(string sigla);
        IList<FormaPagamento> GetAllPagamentos();
        Task<FormaPagamento> FindPagamentoById(string id);
        Task InativarPagamento(string id);
        Task UpdateAsync(FormaPagamento dados);
    }
}
