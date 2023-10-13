using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Eli_Ipsa_Teste.Entities.Enums;

namespace Eli_Ipsa_Teste.Entities
{
    [Table("Cursos")]
    public class Curso
    {
        [Key]
        [Column("ID")]
        public string ID { get; private set; }
        [Column("NivelCurso")]
        [ForeignKey("NiveisCurso")]
        [Required]
        public NiveisCurso NivelCurso { get; set; }
        [Column("Turma")]
        public string Turma { get; set; }
        [Column("Codigo")]
        [Required]
        public string Codigo { get; set; }
        [Column("DataInicio")]
        public DateTime? DataInicio { get; set; }
        [Column("DataTermino")]
        public DateTime? DataTermino { get; set; }
        [Column("Ativo")]
        [Required]
        public bool Ativo { get; set; }
        [Column("Observacao")]
        public string? Observacao { get; set; }

        public Curso(NiveisCurso nivelCurso, string turma, DateTime? dataInicio, DateTime? dataTermino, bool ativo, string? observacao)
        {
            ID = string.Concat(nivelCurso.ToString(), turma);
            NivelCurso = nivelCurso;
            Turma = turma;
            DataInicio = dataInicio;
            DataTermino = dataTermino;
            Ativo = ativo;
        }
    }
}
