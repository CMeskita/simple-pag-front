namespace Helpdesk.Models.Dto
{
    public class DroSuporte
    {

       
        public string NomeCliente { get;  set; }
        public string Empresa { get; protected set; }
        public string NomeAtendente { get;  set; }
        public string ChaveAtendimento { get;  set; }
        public string TipoAtendimento { get;  set; }
        public string EntradaSuporte { get;  set; }
        public string SaidaSuporte { get;  set; }
    }
}
