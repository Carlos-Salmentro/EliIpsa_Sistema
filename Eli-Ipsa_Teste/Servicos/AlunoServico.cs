using Eli_Ipsa_Teste.BancoDeDados;
using Eli_Ipsa_Teste.Entities;
using Microsoft.EntityFrameworkCore;

namespace Eli_Ipsa_Teste.Servicos
{
    public class AlunoServico
    {
        protected readonly AppDbContext _context;
        public AlunoServico(AppDbContext context)
        {
            _context = context;
        }
        
        public Aluno GetAlunoById (int alunoId)
        {
            Aluno aluno = _context.Alunos.FirstOrDefault(x => x.ID == alunoId);
            
            if(aluno != null)
            {
                return aluno;
            }

            throw new NullReferenceException("Nenhum aluno encontrado com o ID informado");
        }

        public string GetNomeAlunoById(int alunoId)
        {
            string nomeAluno = _context.Alunos.Where(x => x.ID == alunoId).Select(x => x.Nome).ToString();

            return nomeAluno;
        }
    }
}
