using System.ComponentModel.DataAnnotations;

namespace Helpdesk.Models.Entity
{
    public class Arquivos
    {
        public string Id { get; protected set; }
        public bool Arquivado { get; protected set; }
        public string Empresa { get; protected set; }
        public string Registro { get; protected set; }
        public string Tipo { get; protected set; }
        public string Path { get; protected set; }
    }
}
