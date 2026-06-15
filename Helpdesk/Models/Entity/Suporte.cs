using System.ComponentModel.DataAnnotations;

namespace Helpdesk.Models.Entity
{
    public class Suporte
    {
        public string Id { get; protected set; }

        [Display(Name = "Nome do Cliente")]
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string NomeCliente { get; protected set; }

      
        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        public string NomeAtendente { get; protected set; }
        public string Empresa { get; protected set; }
        public string ChaveAtendimento { get; protected set; }
        [Display(Name = "Tipo Atendimento")]
        public string TipoAtendimento { get; protected set; }

        public string EntradaSuporte { get; protected set; }
        public string SaidaSuporte { get; protected set; }
        public string Registro { get; protected set; }
        public bool Status { get; protected set; }
    }
}
