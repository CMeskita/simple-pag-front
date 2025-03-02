

using System;

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

        public string Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string ChavePrivada { get; set; }
        public string Registro { get; set; }
        public bool Status { get; set; }




    }
}
