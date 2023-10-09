using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Eli_Ipsa_Teste.Repositorio;
using Eli_Ipsa_Teste.Servicos;

namespace Eli_Ipsa_Teste.Entities
{
    [Table("Preceptorias")]
    public class Preceptoria
    {
        private readonly ServicoPreceptoria _servicoPreceptoria;
        public Preceptoria(ServicoPreceptoria servicoPreceptoria)
        {
            _servicoPreceptoria = servicoPreceptoria;
        }

        [Key]
        [Column("ID")]
        public string ID { get; private set; }
        [Column("Curso")]
        [ForeignKey("Curso")]
        public string Curso { get; private set; }
        [Column("Preceptor")]
        [ForeignKey("AlunoId")]
        public int Preceptor { get; set; }
        [Column("Ativa")]
        public bool Ativa { get; private set; }

        public Preceptoria(string curso, int preceptor, bool ativa)
        {
            ID = _servicoPreceptoria.CriarPreceptoriaId(preceptor, curso);
            Curso = curso;
            Preceptor = preceptor;
            Ativa = ativa;
        }
    }
}
