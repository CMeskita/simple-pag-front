using Dashboard.Models.Entity;
using Microsoft.AspNetCore.Http;
using System;


namespace Dashboard.Models.Dto
{
    public class DtoFinalizadora
    {
        public decimal Valor { get;  set; }
        public int QtdParcelas { get;  set; }
        public string Modalidade { get;  set; }
        public string Vencimento { get;  set; }
        public string FormaPagamento { get; set; }

        public bool ValidarVencimento()
        {
            string dataAtual = DateTime.UtcNow.ToString("dd-MM-yyyy");
            string vencimento = DateTime.Parse(Vencimento).ToString("dd-MM-yyyy");

            DateTime dataAT = DateTime.Parse(dataAtual);
            DateTime dataVC = DateTime.Parse(vencimento);
           
            return dataVC >= dataAT;
        }

        public static implicit operator Finalizadora(DtoFinalizadora dto)
       => new Finalizadora(dto.Valor, dto.QtdParcelas, dto.Modalidade,dto.Vencimento,dto.FormaPagamento);
    }
    public class DtoFinalizadoraPagamento
    {
        public string FinalizadoraId { get;  set; }
        public string FormaPagamentoId { get;  set; }
        public string Sigla { get;  set; }
        public string Modalidade { get;  set; }
        public StatusPagamento StatusPagamento { get;  set; }


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

        public static implicit operator FinalizadoraPagamento(DtoFinalizadoraPagamento dto)
       => new FinalizadoraPagamento(dto.FinalizadoraId, dto.FormaPagamentoId, dto.StatusPagamento.ToString(), dto.Modalidade, dto.Sigla);
    }

    public enum StatusPagamento
    {
        PAGO,
        PENDENTE
    }
}
