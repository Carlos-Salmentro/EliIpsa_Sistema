using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eli_Ipsa_Teste.BancoDeDados.EntidadesRelacionamento
{
    [Table("HistoricoCursosAluno")]
    public class CursosAluno
    {
        [Key]
        [ForeignKey("AlunoId")]
        [Column("AlunoId")]
        public int AlunoId { get; set; }

        [Key]
        [ForeignKey("CursoId")]
        [Column("CursoId")]
        public int CursoId { get; set; }

        [Column("Observacoes")]
        public string? Observacoes { get; set; }

        public CursosAluno(int alunoId, int cursoId, string? observacoes)
        {
            AlunoId = alunoId;
            CursoId = cursoId;
            Observacoes = observacoes;
        }
    }
}
