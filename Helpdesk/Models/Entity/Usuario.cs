

using Helpdesk.Models.Util;
using System;
using System.ComponentModel.DataAnnotations;

namespace Helpdesk.Models.Entity
{
    public class Usuario
    {
        public Usuario( string nome, string email, string chavePrivada,string perfil,string setor)
        {
            Id = Guid.NewGuid().ToString().ToUpper();
            Nome = nome;
            Email = email;
            ChavePrivada = chavePrivada;
            Perfil = perfil;
            Setor = setor;
            Registro = DateTime.UtcNow.ToString("dd-MM-yyyy");
            Status = true;
            Codigo = GeradorCodigos.GerarCodigoUsuario();
        }
        public Usuario(string id,string nome, string email)
        {
            Id = id;
            Nome = nome;
            Email = email;
        }
        public void setUsuario(string nome,string email) 
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
        public string Id { get;protected set; }
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; protected set; }
        public string  Codigo { get; protected set; }

        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        public string Email { get; protected set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "O campo Senha é obrigatório.")]
        public string ChavePrivada { get; protected set; }
        public string Registro { get; protected set; }
        public bool Status { get; protected set; } = false;
        [Required(ErrorMessage = "O campo  é obrigatório.")]
        public string Perfil { get; set; }
        [Required(ErrorMessage = "O campo  é obrigatório.")]
        public string Setor { get; set; }
        [Required(ErrorMessage = "Você deve aceitar os termos de privacidade e LGPD.")]
        [Display(Name = "Aceite da LGPD")]
        public bool Lgpd { get; set; }


    }
}
