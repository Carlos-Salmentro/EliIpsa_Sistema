using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eli_Ipsa_Teste.BancoDeDados.EntidadesRelacionamento
{
    [Table("AlunosDepartamento")]
    public class AlunosDepartamento
    {
        [Key]
        [ForeignKey("DepartamentoId")]
        [Column("Departamento")]
        public string Departamento { get; set; }

        [Key]
        [ForeignKey("AlunoId")]
        [Column("Aluno")]
        public int AlunoId {get; set;}
        
        public AlunosDepartamento(string departamento, int alunoId)
        {
            Departamento = departamento;
            AlunoId = alunoId;
        }
    }
}
