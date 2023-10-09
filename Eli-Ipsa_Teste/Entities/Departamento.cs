using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eli_Ipsa_Teste.Entities
{
    [Table("Departamentos")]
    public class Departamento
    {
        [Key]
        [Column("ID")]
        public string Nome { get; set; }
        [Column("Responsavel")]
        [Required]
        public int Responsavel { get; set; }
        [Column("Observacoes")]
        public string Observacoes;

        public Departamento (string nome, int responsavel, string observacoes)
        {
            Nome = nome;
            Responsavel = responsavel;
            Observacoes = observacoes;
        }
        
    }
}
