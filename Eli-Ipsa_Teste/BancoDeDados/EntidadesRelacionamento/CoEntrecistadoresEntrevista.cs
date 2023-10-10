using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eli_Ipsa_Teste.BancoDeDados.EntidadesRelacionamento
{
    [Table("CoEntrevistadoresEntrevista")]
    public class CoEntrevistadoresEntrevista
    {
        [Column("EntrevistaId")]
        [ForeignKey("Entrevista")]
        [Required]
        public int EntrevistaId { get; set; }
        [Column("EntrevistadorId")]
        [ForeignKey("Aluno")]
        [Required]
        public int AlunoId { get; set; }

        public CoEntrevistadoresEntrevista(int alunoId, int entrevistaId)
        {
            AlunoId = alunoId;
            EntrevistaId = entrevistaId;
        }

    }
}
