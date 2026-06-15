using System.ComponentModel.DataAnnotations;

namespace Helpdesk.Models.Entity
{
    public class AuditoriaSuporte
    {
        public string Id { get;protected set; }
        public int Codigo { get; protected set; }
        public string Empresa { get; protected set; }

        [Display(Name = "Conteúdo inicial")]
        public string InicioAtendimento { get;protected set; }
        [Display(Name = "Solução")]
        public string FimAtendimento { get;protected set; }
        public string TempoCorrido { get; protected set; }

    }
}
