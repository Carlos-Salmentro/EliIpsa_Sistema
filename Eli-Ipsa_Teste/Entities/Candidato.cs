using Eli_Ipsa_Teste.Entities.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eli_Ipsa_Teste.Entities
{
    [Table("Candidatos")]
    public class Candidato
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int ID { get; private set; }

        [Column("Nome")]
        public string Nome { get; private set; }

        [Column("Contato")]
        public int Contato { get; private set; }
        [Column("TipoContato")]
        [Required]
        public TipoContato Tipo_Contato { get; private set; }

        [Column("Indicacao")]
        public string Indicacao { get; private set; }

        [Column("Ativo")]
        public bool Ativo { get; private set; }

        public Candidato(string nome, int contato, string indicacao)
        {
            Nome = nome;
            Contato = contato;
            Indicacao = indicacao;
            Ativo = true;
        }
        public Candidato(string nome, int contato, TipoContato tipoContato, string indicacao, bool ativo)
        {
            Nome = nome;
            Contato = contato;
            Tipo_Contato = tipoContato;
            Indicacao = indicacao;
            Ativo = ativo;
        }
        
    }
}
