

using System;
using System.ComponentModel.DataAnnotations;

namespace Dashboard.Models
{
    public class Usuario
    {
        public Usuario( string nome, string email, string chavePrivada)
        {
            Id = Guid.NewGuid().ToString().ToUpper();
            Nome = nome;
            Email = email;
            ChavePrivada = chavePrivada;
            Registro = DateTime.UtcNow.ToString("dd-MM-yyyy");
            Status = true;
        }
        public Usuario(string id,string nome, string email,string chavePrivada)
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
        public void Inativar() 
        {
            Status = false;
        }
        public string Id { get;protected set; }
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; protected set; }

        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        public string Email { get; protected set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "O campo Senha é obrigatório.")]
        public string ChavePrivada { get; protected set; }
        public string Registro { get; protected set; }
        public bool Status { get; protected set; }


    }
}
