//using Eli_Ipsa_Teste.Entities.Enums;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace Eli_Ipsa_Teste.Entities
//{
//    [Table("Candidatos")]
//    public class Candidato
//    {
//        [Key]
//        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
//        [Column("ID")]
//        public int ID { get; private set; }

//        [Column("Nome")]
//        [Required]
//        public string NomeEntrevistado { get; private set; }

//        [Column("Contato")]
//        public int ContatoEntrevistado { get; private set; }
//        [Column("TipoContato")]
//        [Required]
//        public TipoContato Tipo_Contato { get; private set; }

//        [Column("Indicacao")]
//        public string Indicacao { get; private set; }
//        [Column("Entrevistador")]
//        [ForeignKey("Aluno")]
//        public int Entrevistador { get; private set; }
//        [Column("ResultadoEntrevista")]
//        [ForeignKey("PossiveisResultadosEntrevista")]
//        public PossiveisResultadosEntrevista Resultado { get; set; }

//        [Column("Ativo")]
//        public bool Ativo { get; private set; }

//        public Candidato(string nome, int contato, string indicacao)
//        {
//            NomeEntrevistado = nome;
//            ContatoEntrevistado = contato;
//            Indicacao = indicacao;
//            Ativo = true;
//        }
                
//    }
//}
