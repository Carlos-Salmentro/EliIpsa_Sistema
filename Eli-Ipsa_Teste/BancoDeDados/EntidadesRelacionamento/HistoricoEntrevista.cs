using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eli_Ipsa_Teste.BancoDeDados.EntidadesRelacionamento
{
    [Table("HistoricoEntrevista")]
    public class HistoricoEntrevista
    {
        [Column("AlunoId")]
        [ForeignKey("Aluno")]
        [Required]
        public int AlunoId;
        [Column("EntrevistaId")]
        [ForeignKey("Entrevista")]
        [Required]
        public int EntrevistaId;

        public HistoricoEntrevista(int alunoId, int entrevistaId)
        {
            AlunoId = alunoId;
            EntrevistaId = entrevistaId;
        }
    }
}
