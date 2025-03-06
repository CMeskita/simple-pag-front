using System;
using System.ComponentModel.DataAnnotations;

namespace Dashboard.Models.Entity
{
    public class FormaPagamento
    {
        public FormaPagamento(string nome, string sigla,int codFinalizadora)
        {
            Id = Guid.NewGuid().ToString().ToUpper();
            Nome = nome.Trim().ToUpper();
            Sigla = sigla.Trim().ToUpper();
            CodFinalizadora = codFinalizadora;
            Status = true;
            Registro = DateTime.UtcNow.ToString("dd-MM-yyyy");
           
        }

        public string Id { get; protected set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; protected set; }

        [Display(Name = "Código Finalizadora")]
        [Required(ErrorMessage = "O campo Codigo Finalizadora é obrigatório.")]
        public int CodFinalizadora { get; protected set; }
        public string Registro { get; protected set; }

        [Required(ErrorMessage = "O campo Codigo Finalizadora é obrigatório.")]
        public string  Sigla { get; protected set; }
        public bool Status { get; protected set; }

        
    }
}
