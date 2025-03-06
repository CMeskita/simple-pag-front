using System;

namespace Dashboard.Models.Entity
{
    public class FinalizadoraPagamento
    {
        public FinalizadoraPagamento()
        {
            
        }
        public FinalizadoraPagamento(string finalizadoraId, string formaPagamentoId, StatusPagamento statusPagamento, string registro,string sigla)
        {
            Id = Guid.NewGuid().ToString().ToUpper();
            FinalizadoraId = finalizadoraId;
            FormaPagamentoId = formaPagamentoId;
            Sigla = sigla.ToUpper();
            StatusPagamento = statusPagamento;
            Registro = registro;
        }

        public string Id { get; protected set; }
        public string FinalizadoraId { get; protected set; }
        public string FormaPagamentoId { get; protected set; }
        public string Sigla { get; protected set; }
        public string Modalidade { get; protected set; }
        public string Registro { get; protected set; }
        public StatusPagamento StatusPagamento { get; protected set; }



        public void AtualizarStatusPagamento(DateTime dataPagamento)
        {
            if (dataPagamento <= DateTime.Now)
            {
                StatusPagamento = StatusPagamento.PAGO;
            }
            else
            {
                StatusPagamento = StatusPagamento.PENDENTE;
            }
        }

    }
    public enum StatusPagamento
    {
        PAGO,
        PENDENTE
    }
}
