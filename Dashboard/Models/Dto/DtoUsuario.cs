
using System.ComponentModel.DataAnnotations;

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
    public class DtoUsuarioUpdate
    {
        public string Id { get; set; }
        public string Nome { get; set; }

        public string Email { get; set; }

        public string ChavePrivada { get; set; }

        public static implicit operator Usuario(DtoUsuarioUpdate dto)
       => new Usuario(dto.Id,dto.Nome, dto.Email, dto.ChavePrivada);


    }
}
