
namespace Dashboard.Models.Dto
{
    public class DtoUsuario
    {

        public string Nome { get; set; }
        public string Email { get; set; }
        public string ChavePrivada { get; set; }

        public static implicit operator Usuario(DtoUsuario dto)
       => new Usuario(dto.Nome, dto.Email, dto.ChavePrivada);


    }
}
