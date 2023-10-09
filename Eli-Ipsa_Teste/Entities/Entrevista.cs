using Eli_Ipsa_Teste.Entities.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eli_Ipsa_Teste.Entities
{
    [Table("Entrevistas")]
    public class Entrevista
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [ForeignKey("CandidatoId")]
        [Column("CandidatoId")]
        [Required]
        public int CandidatoId { get; set; }
        [ForeignKey("AlunoId")]
        [Column("Entrevistador")]
        [Required]
        public int Entrevistador { get; set; }
        [ForeignKey("AlunoId")]
        [Column("CoEntrevistador")]
        public int CoEntrevistador { get; set; }
        [Column("DataDaEntrevista")]
        public DateTime DataDaEntrevista { get; set; }
        [Column("Ativa")]
        [Required]
        public bool Ativa { get; set; }
        [Column("Resultado")]
        public PossiveisResultadosEntrevista? Resultado { get; set; }

        public Entrevista(int candidatoId, int entrevistador, int coEntrevistador, DateTime dataDaEntrevista, bool ativa, PossiveisResultadosEntrevista? resultado)
        {
            CandidatoId = candidatoId;
            Entrevistador = entrevistador;
            CoEntrevistador = coEntrevistador;
            DataDaEntrevista = dataDaEntrevista;
            Ativa = ativa;
            Resultado = resultado;
        }
    }
}
