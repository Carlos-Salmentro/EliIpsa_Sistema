using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Eli_Ipsa_Teste.Entities.Enums;

namespace Eli_Ipsa_Teste.Entities
{
    [Table("Contatos")]
    public class Contato
    {
        [Key]
        [ForeignKey("AlunoId")]
        [Column("AlunoId")]
        public int AlunoId { get; private set; }
        [ForeignKey("TipoContato")]
        [Column("TipoContato")]
        public TipoContato TipoContato { get; private set; }
        [Column("Contato")]
        public string Contato_ { get; private set; }
       
        [Column("Ativo")]
        [Required]
        public bool Ativo { get; private set; }


        public Contato(int alunoId, string contato_, TipoContato tipoContato, bool ativo)
        {
            AlunoId = alunoId;
            Contato_ = contato_;
            TipoContato = tipoContato;
            Ativo = ativo;
        }
    }
}
