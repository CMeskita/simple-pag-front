using Dashboard.Models.Dto;
using Helpdesk.Models.Entity;
using System.ComponentModel.DataAnnotations;

namespace Helpdesk.Models.Dto
{
    public class ClienteViewModel
    {
        [Required(ErrorMessage = "O nome é obrigatório para o acesso.")]
        public string Nome { get;  set; }
        [Required(ErrorMessage = "O e-mail é obrigatório para o acesso.")]
        [EmailAddress(ErrorMessage = "Insira um endereço de e-mail válido.")]
        public string Email { get;  set; }
     
        public bool Lgpd { get; set; }
        [Required(ErrorMessage = "O empresa é obrigatório para o acesso.")]
        public string Empresa { get;  set; }
        public string CodigoEmpresa { get;  set; }

        public static implicit operator Cliente(ClienteViewModel dto)
       => new Cliente(dto.Nome, dto.Email,dto.CodigoEmpresa,dto.Empresa);
    }
    public class ClienteViewModelUpdate
    {
        public string Id { get; set; }
        public string Nome { get; set; }

        public string Email { get; set; }
        public string Empresa { get; set; }
        public string CodigoEmpresa { get; set; }

        public static implicit operator Cliente(ClienteViewModelUpdate dto)
       => new Cliente(dto.Id, dto.Nome, dto.Email,dto.CodigoEmpresa,dto.Empresa);


    }
}
