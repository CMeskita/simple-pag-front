using System;
using System.ComponentModel.DataAnnotations;

namespace Dashboard.Models.Entity
{
    public class Finalizadora
    {
        public Finalizadora()
        {

        }
        public Finalizadora(decimal valor, int qtdParcelas, string modalidade, string vencimento, string formaPagamento)
        {
            Id = Guid.NewGuid().ToString().ToUpper();
            Valor = valor;
            QtdParcelas = qtdParcelas;
            Modalidade = modalidade.ToUpper();
            Vencimento = vencimento.ToString();
            FormaPagamento = formaPagamento;
        }

        public string Id { get; protected set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Somente números são permitidos.")]
        public decimal Valor { get; protected set; }
        [Display(Name = "Parcelas")]
        public int QtdParcelas { get; protected set; }
        public string Modalidade { get; protected set; }
        public string Vencimento { get; protected set; }
        [Display(Name = "Pagamento")]
        public string FormaPagamento { get; protected set; }

     
    }
   

}
