using Helpdesk.Models.Util;

namespace Helpdesk.Models.Entity
{
    public class Perfil
    {
        public Perfil()
        {
            
        }
        public string Id { get; set; }
        public string Nome { get; set; }
        public string CodigoPerfil { get; set; }
        public Perfil(string nome,int codigo)
        {
            Nome = nome.ToUpper().Trim();
            CodigoPerfil = GeradorCodigos.GerarCodigoPerfil();
            
        }

    }
}
