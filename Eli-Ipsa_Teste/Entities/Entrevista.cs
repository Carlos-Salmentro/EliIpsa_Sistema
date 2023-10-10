using Eli_Ipsa_Teste.Entities.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eli_Ipsa_Teste.Entities
{
    [Table("AgendamentoEntrevistas")]
    public class Entrevista
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Column("NomeEntrevistado")]
        [Required]
        public string NomeEntrevistado { get; set; }
        [Column("ContatoEntrevistado")]
        [Required]
        public string ContatoEntrevistado { get; set; }
        [Column("TipoContato")]
        [Required]
        public TipoContato TipoContato { get; set; }
        [Column("Indicacao")]
        public string Indicacao { get; set; }
        [ForeignKey("AlunoId")]
        [Column("Entrevistador")]
        public int Entrevistador { get; set; }
        [Column("DataDaEntrevista")]
        [Required]
        public DateTime DataDaEntrevista { get; set; }

        [Column("Resultado")]
        public PossiveisResultadosEntrevista? Resultado { get; set; }
        [Column("ReEntrevista")]
        [Required]
        public bool ReEntrevista { get; set; }
        [Column("Ativa")]
        [Required]
        public bool Ativa { get; set; }
        [Column("AlunoAntigo")]
        [ForeignKey("Aluno")]
        public int? AlunoId { get; set; }


        public Entrevista(string nomeEntrevistado, string contatoEntrevistado, TipoContato tipoContato, string indicacao, int entrevistador, 
            DateTime dataDaEntrevista, bool ativa, PossiveisResultadosEntrevista? resultado, bool reentrevista)
        {
            NomeEntrevistado = nomeEntrevistado;
            ContatoEntrevistado = contatoEntrevistado;
            TipoContato = tipoContato;
            Indicacao = indicacao;
            Entrevistador = entrevistador;
            DataDaEntrevista = dataDaEntrevista;
            Ativa = ativa;
            Resultado = resultado;
            ReEntrevista = reentrevista;
        }
    }
}
