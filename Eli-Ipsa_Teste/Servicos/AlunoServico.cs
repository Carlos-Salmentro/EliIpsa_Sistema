using Eli_Ipsa_Teste.BancoDeDados;
using Eli_Ipsa_Teste.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace Eli_Ipsa_Teste.Servicos
{
    public class AlunoServico
    {
        protected readonly AppDbContext _context;
        public AlunoServico(AppDbContext context)
        {
            _context = context;
        }
        
        public Aluno GetAlunoPorId (int alunoId)
        {
            if(alunoId == 0)
            {
                throw new ArgumentNullException("O ID do aluno deve ser diferente de 0");
            }

            Aluno aluno = _context.Alunos.FirstOrDefault(x => x.ID == alunoId);
            
            if(aluno != null)
            {
                return aluno;
            }

            throw new NullReferenceException("Nenhum aluno encontrado com o ID informado");
        }

        public string GetNomeAlunoPorId(int? alunoId)
        {
            if(alunoId == null)
            {
                throw new ArgumentNullException("ERRO: Id inforado é nulo.");
            }
            string nomeAluno = _context.Alunos.Where(x => x.ID == alunoId).Select(x => x.Nome).ToString();

            return nomeAluno;
        }
    }
}
