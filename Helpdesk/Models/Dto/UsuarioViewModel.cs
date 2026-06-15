
using Helpdesk.Models.Entity;
using Helpdesk.Models.Util;
using System.ComponentModel.DataAnnotations;

namespace Dashboard.Models.Dto
{
    public class UsuarioViewModel
    {

        public string Nome { get; set; }
     
        public string Email { get; set; }

        public string Perfil { get; set; }
        public string Setor { get; set; }
        public bool Lgpd { get; set; }
        public string ChavePrivada { get; set; }


        public static implicit operator Usuario(UsuarioViewModel dto)
       => new Usuario(dto.Nome, dto.Email, dto.ChavePrivada,dto.Perfil,dto.Setor);


    }
    public class DtoUsuarioUpdate
    {
        public string Id { get; set; }
        public string Nome { get; set; }
     
        public string Email { get; set; }
        public bool Lgpd { get; set; }

        public static implicit operator Usuario(DtoUsuarioUpdate dto)
       => new Usuario(dto.Id,dto.Nome, dto.Email);


    }
}
