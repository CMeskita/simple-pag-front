using System;

namespace Dashboard.Models.Entity
{
    public class FinalizadoraPagamento
    {
        public FinalizadoraPagamento()
        {
            
        }
        public FinalizadoraPagamento(string finalizadoraId, string formaPagamentoId, string statusPagamento, string modalidade, string sigla)
        {
            Id = Guid.NewGuid().ToString().ToUpper();
            FinalizadoraId = finalizadoraId;
            FormaPagamentoId = formaPagamentoId;
            Sigla = sigla.ToUpper();
            StatusPagamento = statusPagamento;
            Registro = DateTime.UtcNow.ToString("dd-MM-yyyy");
            Modalidade = modalidade;
        }

        public string Id { get; protected set; }
        public string FinalizadoraId { get; protected set; }
        public string FormaPagamentoId { get; protected set; }
        public string Sigla { get; protected set; }
        public string Modalidade { get; protected set; }
        public string Registro { get; protected set; }
        public string StatusPagamento { get; protected set; }




    }
    
}
