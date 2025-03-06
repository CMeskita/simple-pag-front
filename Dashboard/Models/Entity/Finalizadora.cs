using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dashboard.Models.Entity
{
    public class Finalizadora
    {
        public Finalizadora()
        {
            
        }
        public Finalizadora(decimal valor, int qtdParcelas, string modalidade, string vencimento)
        {
            Id = Guid.NewGuid().ToString().ToUpper();
            Valor = valor;
            QtdParcelas = qtdParcelas;
            Modalidade = modalidade;
            Vencimento = vencimento;


        }

        public string Id { get;protected set; }
        public decimal Valor { get; protected set; }
        [Display(Name = "Parcelas")]
        public int QtdParcelas { get; protected set; }
        public string Modalidade { get; protected set; }
        public string Vencimento { get; protected set; }
        public string FormaPagamento { get; protected set; }



    }
   

}
