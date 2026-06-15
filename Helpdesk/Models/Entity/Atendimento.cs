using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Helpdesk.Models.Entity
{
    [Table("Atendimentos")]
    public class Atendimento
    {
        [Key]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O título/assunto é obrigatório.")]
        [StringLength(150, ErrorMessage = "O título deve ter no máximo 150 caracteres.")]
        [Display(Name = "Título / Assunto")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Selecione uma categoria para o problema.")]
        [StringLength(50)]
        [Display(Name = "Categoria")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "Defina o nível de prioridade.")]
        [StringLength(20)]
        [Display(Name = "Prioridade")]
        public string Prioridade { get; set; }

        [Required(ErrorMessage = "A descrição detalhada é obrigatória.")]
        [DataType(DataType.Text)]
        [Display(Name = "Descrição do Incidente")]
        public string Descricao { get; set; }

        [StringLength(255)]
        [Display(Name = "Caminho do Anexo")]
        public string? AnexoPath { get; set; } // Armazena o caminho/nome do arquivo salvo no servidor

        [Required]
        [Display(Name = "Data de Abertura")]
        public DateTime DataAbertura { get; set; } = DateTime.Now;

        [Display(Name = "Data de Encerramento")]
        public DateTime? DataFechamento { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; } = "Aberto"; // Status iniciais comuns: Aberto, Em Atendimento, Resolvido, Cancelado

        // --- RELACIONAMENTOS (Chaves Estrangeiras) ---

        [Required(ErrorMessage = "O solicitante deve ser informado.")]
        [Display(Name = "Solicitante")]
        public string Solicitante { get; set; }
        [Required(ErrorMessage = "Cliente Afetado.")]
        [Display(Name = "Cliente")]
        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public virtual Usuario? Usuario { get; set; } // O usuário que abriu o chamado

        // Opcional: Técnico responsável pelo atendimento
        [Display(Name = "Técnico Responsável")]
        public int? TecnicoId { get; set; }

        [ForeignKey("TecnicoId")]
        public virtual Usuario? Tecnico { get; set; }
        // Adicione este campo dentro da sua classe Atendimento.cs
        [Display(Name = "Solução Aplicada")]
        [DataType(DataType.Text)]
        public string Solucao { get; set; }

        public bool Resolvido { get; set; }
    }
}
