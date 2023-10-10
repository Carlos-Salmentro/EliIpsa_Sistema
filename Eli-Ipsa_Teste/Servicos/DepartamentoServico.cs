using Eli_Ipsa_Teste.Entities;
using Eli_Ipsa_Teste.BancoDeDados;
using Eli_Ipsa_Teste.BancoDeDados.EntidadesRelacionamento;

namespace Eli_Ipsa_Teste.Servicos
{
    public class DepartamentoServico
    {
        private readonly AppDbContext _context;

        public DepartamentoServico(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IResult> AdicionarAlunoDepartamento(string departamentoId, int alunoId)
        {
            AlunosDepartamento alunoDepartamento = new AlunosDepartamento(departamentoId, alunoId);
            await _context.AddAsync(alunoDepartamento);
            await _context.SaveChangesAsync();

            return Results.Ok(alunoDepartamento);
        }

        public async Task<IResult> RemoverAlunoDepartamento(string departamentoId, int alunoId)
        {
            AlunosDepartamento alunoDepartamento = new AlunosDepartamento(departamentoId, alunoId);
            _context.Remove(alunoDepartamento);
            await _context.SaveChangesAsync();

            return Results.Ok(alunoDepartamento);
        }

        public async Task<IResult> AlterarResponsavelDepartamento(string departamentoId, int responsavelId)
        {
            Departamento departamento = _context.Departamentos.Single(x => x.Nome == departamentoId);
            departamento.Responsavel = responsavelId;
            //IQueryable<int> IdResponsavel = _context.Departamentos.Where(x => x.Nome == departamentoId).Select(x => x.Responsavel);
            await _context.SaveChangesAsync();

            return Results.Ok(new { departamentoId, responsavelId });
        }

        public async Task<IResult> CriarDepartamento()
        {
            return Results.Ok();
        }

    }
}
