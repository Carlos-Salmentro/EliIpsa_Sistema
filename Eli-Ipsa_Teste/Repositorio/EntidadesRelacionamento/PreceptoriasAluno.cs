using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eli_Ipsa_Teste.Repositorio.EntidadesRelacionamento
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
        [Column("Observacoes")]
        public string Observacoes { get; set; }

        public PreceptoriasAluno (int alunoId, string preceptoriaId, string observacoes)
        {
            AlunoId = alunoId;
            PreceptoriaId = preceptoriaId;
            Observacoes = observacoes;
        }
    }
}
