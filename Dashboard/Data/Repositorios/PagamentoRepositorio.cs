using Dashboard.Models;
using Dashboard.Models.Entity;
using Dashboard.Models.Interface;
using Data.Conexao;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard.Data.Repositorios
{
    public class PagamentoRepositorio: IPagamentoRepositorio
    {
        private readonly Context _context;

        public PagamentoRepositorio(Context context)
        {
            _context = context;
        }

        public async Task AddPagamento(FormaPagamento pagamento)
        {
            await _context.FormaPagamentos.AddAsync(pagamento);
            _context.SaveChanges();
        }
        public bool ExistePagamento(string sigla)
        {
            FormaPagamento pagamento = _context.FormaPagamentos.FirstOrDefault(x => x.Sigla == sigla.ToUpper());
            return (pagamento != null);
        }
    }
}
