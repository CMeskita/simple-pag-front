using Dashboard.Models.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dashboard.Models.Interface
{
    public interface IFinalizadoraRepositorio
    {
        Task<Finalizadora> AddFinalizadora(Finalizadora usuario);
        bool ExisteFinalizadora(string sigla);
        IList<Finalizadora> GetAllFinalizadoras();
        Task<Finalizadora> FindFinalizadoraById(string id);
        Task InativarFinalizadora(string id);
        Task UpdateAsync(Finalizadora dados);
        decimal TotalPagamentos();
        int TotalQtdePagamentos();
        decimal TotalPagamentosAvista();
        decimal TotalPagamentosAPrazo();
        Task AddFinalizadoraPagamento(FinalizadoraPagamento dados);


    }
}
