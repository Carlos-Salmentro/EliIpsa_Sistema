using Eli_Ipsa_Teste.Entities;
using Eli_Ipsa_Teste.BancoDeDados;
using System.Linq;

namespace Eli_Ipsa_Teste.Servicos
{
    public class PreceptoriaServico
    {

        private readonly AppDbContext _context;

        public PreceptoriaServico(AppDbContext context)
        {
            _context = context;
        }

        public string CriarPreceptoriaId(int alunoId, string cursoId)
        {
            string nomePreceptor = _context.Alunos.Where(x => x.ID == alunoId)
                .Select(x => x.Nome).ToString();
            
            return cursoId + nomePreceptor;
            
        }
        
    }
}
