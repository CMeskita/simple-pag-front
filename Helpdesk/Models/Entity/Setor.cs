using Helpdesk.Models.Util;

namespace Helpdesk.Models.Entity
{
    public class Setor
    {
        public Setor()
        {
            
        }
        public string Id { get; set; }
        public string Nome { get; set; }
        public string CodigoSetor { get; set; }
        public Setor(string nome, int codigo)
        {
            Nome = nome.ToUpper().Trim();
            CodigoSetor = GeradorCodigos.GerarCodigoSetor();

        }
    }
}
