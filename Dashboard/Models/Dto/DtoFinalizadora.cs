using Dashboard.Models.Entity;


namespace Dashboard.Models.Dto
{
    public class DtoFinalizadora
    {
        public decimal Valor { get;  set; }
        public int QtdParcelas { get;  set; }
        public string Modalidade { get;  set; }
        public string Vencimento { get;  set; }


        public static implicit operator Finalizadora(DtoFinalizadora dto)
       => new Finalizadora(dto.Valor, dto.QtdParcelas, dto.Modalidade,dto.Vencimento);
    }
}
