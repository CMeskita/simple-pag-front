using Dashboard.Models.Entity;
using Dashboard.Models.Interface;
using Data.Conexao;
using Humanizer;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard.Data.Repositorios
{
    public class FinalizadoraRepositorio : IFinalizadoraRepositorio
    {
        private readonly Context _context;

        public FinalizadoraRepositorio(Context context)
        {
            _context = context;
        }

        public async Task<Finalizadora> AddFinalizadora(Finalizadora finalizadora)
        {
            await _context.Finalizadoras.AddAsync(finalizadora);
            _context.SaveChanges();
            return finalizadora;
        }

        public bool ExisteFinalizadora(string sigla)
        {
            throw new System.NotImplementedException();
        }

        public Task<Finalizadora> FindFinalizadoraById(string id)
        {
            throw new System.NotImplementedException();
        }

        public IList<Finalizadora> GetAllFinalizadoras()
        {
            return _context.Finalizadoras.ToList();
        }

        public Task InativarFinalizadora(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(Finalizadora dados)
        {
            throw new System.NotImplementedException();
        }

        public decimal TotalPagamentos()
        {
            decimal result = _context.Finalizadoras.Sum(x => x.Valor);
            return result;
        }
        public int TotalQtdePagamentos()
        {
            var result = _context.Finalizadoras.Count();
            return result;
        }
        public decimal TotalPagamentosAvista()
        {
            var result = _context.Finalizadoras.Where(x => x.QtdParcelas < 1).Sum(x=>x.Valor);
            return result;
        }
        public decimal TotalPagamentosAPrazo()
        {
            var result = _context.Finalizadoras.Where(x => x.QtdParcelas >= 1).Sum(x => x.Valor); 
            return result;
        }
        public async Task AddFinalizadoraPagamento(FinalizadoraPagamento dados)
        {
            await _context.FinalizadoraPagamentos.AddAsync(dados);
            _context.SaveChanges();
        }
    }
}
