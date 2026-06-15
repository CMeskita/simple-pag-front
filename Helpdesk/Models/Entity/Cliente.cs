using Helpdesk.Models.Util;
using System;
using System.ComponentModel.DataAnnotations;

namespace Helpdesk.Models.Entity
{
    public class Cliente
    {
        public Cliente()
        {
            
        }
        public Cliente(string nome, string email,string codigoempresa, string empresa)
        {
            Id = Guid.NewGuid().ToString().ToUpper();
            Nome = nome;
            Email = email;
            CodigoEmpresa = codigoempresa;
            Empresa = empresa;
            Registro = DateTime.UtcNow.ToString("dd-MM-yyyy");
            Status = true;
       
        }
        public Cliente(string id, string nome, string email,string codigoempresa, string empresa)
        {
            Id = id;
            Nome = nome;
            Email = email;
            CodigoEmpresa= codigoempresa;
            Empresa = empresa;

        }
        public void setCliente(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
        public void SetStatus(bool status)
        {
            Status = status;
        }
        public void SetAceiteLgpd()
        {
            Lgpd = true;
        }
        public string Id { get; protected set; }
        [Required(ErrorMessage = "O campo  é obrigatório.")]
        public string Nome { get; protected set; }
        [Required(ErrorMessage = "O campo  é obrigatório.")]
        public string Email { get; protected set; }

        [Required(ErrorMessage = "O campo  é obrigatório.")]
        public string Empresa { get; protected set; }
        [Required(ErrorMessage = "O campo  é obrigatório.")]
        public string CodigoEmpresa { get; protected set; }
        public string Registro { get; protected set; }
        public bool Status { get; protected set; }
        [Required(ErrorMessage = "Você deve aceitar os termos de privacidade e LGPD.")]
        [Display(Name = "Aceite da LGPD")]
        public bool Lgpd { get; set; }

    }
}
