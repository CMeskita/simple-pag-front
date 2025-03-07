using Dashboard.Models.Entity;
using Dashboard.Models.Interface;
using Data.Conexao;
using System.Collections.Generic;
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

        public  async Task<FormaPagamento> FindPagamentoById(string id)
        {
            return await _context.FormaPagamentos.FindAsync(id);
        }

        public IList<FormaPagamento> GetAllPagamentos()
        {
            return _context.FormaPagamentos.OrderBy(x=>x.Nome).ToList();
        }

        public async Task InativarPagamento(string id)
        {
            var dados = _context.FormaPagamentos.Where(x => x.Id == id).FirstOrDefault();
            if (dados != null)
            {
               // dados.Inativar();

                _context.FormaPagamentos.Attach(dados).Property(x => x.Status).IsModified = true;
                await _context.SaveChangesAsync();

            }
        }

        public async Task UpdateAsync(FormaPagamento dados)
        {

            FormaPagamento pagamento = _context.FormaPagamentos.Where(x => x.Id == dados.Id).FirstOrDefault();
            if (pagamento != null)
            {
                //usuarios.setUsuario(dados.Nome, dados.Email);
            }
            _context.FormaPagamentos.Update(pagamento);
            await _context.SaveChangesAsync();

        }
    }
}
