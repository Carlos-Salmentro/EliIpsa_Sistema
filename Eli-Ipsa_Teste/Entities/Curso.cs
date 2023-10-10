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
        public NiveisCurso NivelCurso { get; private set; }
        [Column("IdentificadorCurso")]
        [Required]
        
        public string IdentificadorCurso { get; private set; }
        [Column("DataInicio")]
        public DateTime? DataInicio { get; private set; }
        [Column("DataTermino")]
        public DateTime? DataTermino { get; private set; }
        [Column("Ativo")]
        [Required]
        public bool Ativo { get; private set; }
        [Column("Observacao")]
        public string? Observacao { get; private set; }

        public Curso(NiveisCurso nivelCurso, string identificadorCurso, DateTime? dataInicio, DateTime? dataTermino, bool ativo, string? observacao)
        {
            ID = string.Concat(nivelCurso.ToString(), identificadorCurso);
            NivelCurso = nivelCurso;
            IdentificadorCurso = identificadorCurso;
            DataInicio = dataInicio;
            DataTermino = dataTermino;
            Ativo = ativo;
        }
    }
}
