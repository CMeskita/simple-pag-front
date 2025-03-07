using Dashboard.Models.Entity;

namespace Dashboard.Models.Dto
{
    public class DtoFormaPagamento
    {
        public string Nome { get;  set; }
  
        public int CodFinalizadora { get;  set; }
        public string Sigla { get;  set; }
        public bool Modalidade { get;  set; }


        public static implicit operator FormaPagamento(DtoFormaPagamento dto)
      => new FormaPagamento(dto.Nome, dto.Sigla, dto.CodFinalizadora,dto.Modalidade);


    }
}
