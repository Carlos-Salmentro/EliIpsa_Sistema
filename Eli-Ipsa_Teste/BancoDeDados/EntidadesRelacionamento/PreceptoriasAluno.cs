using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eli_Ipsa_Teste.BancoDeDados.EntidadesRelacionamento
{
    [Table("PreceptoriasAluno")]
    public class PreceptoriasAluno
    {
        [Key]
        [ForeignKey("AlunoId")]
        [Column("AlunoId")]
        public int AlunoId { get; set; }

        [Key]
        [ForeignKey("PreceptoriaId")]
        [Column("PreceptoriaId")]
        public string PreceptoriaId { get; set; }
        [Column("Ativa")]
        [Required]
        public bool Ativa { get; set; }
        [Column("Observacoes")]
        public string? Observacoes { get; set; }

        public PreceptoriasAluno (int alunoId, string preceptoriaId, bool ativa, string? observacoes)
        {
            AlunoId = alunoId;
            PreceptoriaId = preceptoriaId;
            Ativa = ativa;
            Observacoes = observacoes;
        }
    }
}
