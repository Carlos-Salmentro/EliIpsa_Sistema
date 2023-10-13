using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eli_Ipsa_Teste.Entities
{
    [Table("Departamentos")]
    public class Departamento
    {
        [Key]
        [Column("ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Column("Nome")]
        [Required]
        public string Nome { get; set; }
        [Column("ResponsavelId")]
        public int ResponsavelId { get; set; }
        [Column("Observacoes")]
        public string Observacoes;

        public Departamento (string nome, int responsavelId, string observacoes)
        {
            Nome = nome;
            ResponsavelId = responsavelId;
            Observacoes = observacoes;
        }
        
    }
}
