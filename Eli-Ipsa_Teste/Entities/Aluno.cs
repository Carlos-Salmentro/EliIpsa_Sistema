using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eli_Ipsa_Teste.Entities
{
    [Table("Alunos")]
    public class Aluno
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Column("Nome")]
        [Required]
        public string Nome { get; set; }
        [Column("Endereço")]
        [Required]
        public string Endereço { get; set; }
        [Column("Ativo")]
        [Required]
        public bool Ativo { get; set; }
        [Column("Preceptor")]
        [Required]
        public bool Preceptor { get; set; }
        [Column("CoPreceptor")]
        [Required]
        public bool CoPreceptor { get; set; }
        [Column("Entrevistador")]
        [Required]
        public bool Entrevistador { get; set; }
        [Column("Observacoes")]
        public string Observacoes { get; set; }

        public Aluno(int id, string nome, string endereco, bool ativo, bool preceptor, bool entrevistador, string? observacoes)
        {
            ID = id;
            Nome = nome;
            Endereço = endereco;
            Ativo = ativo;
            Preceptor = preceptor;
            Entrevistador = entrevistador;
            Observacoes = observacoes;
        }

    }
}
