using Eli_Ipsa_Teste.BancoDeDados;
using Eli_Ipsa_Teste.Entities;
using Eli_Ipsa_Teste.Servicos.Responses;
using Microsoft.EntityFrameworkCore;

namespace Eli_Ipsa_Teste.Servicos
{
    public class EntrevistaServico
    {
        protected readonly AppDbContext _context;

        public EntrevistaServico(AppDbContext context)
        {
            _context = context;
        }

        public List<EntrevistaResponse> GetAllEntrevistas()
        {
            List<Entrevista> ListaEntrevista = _context.Entrevistas.Where(x => x.Ativa == true).ToList();
            List<EntrevistaResponse> EntrevistaResponse = new List<EntrevistaResponse>();
            List<string> CoEntrevistadores = new List<string>();

            foreach (Entrevista x in ListaEntrevista)
            {
                string nomeEntrevistador = GetEntrevistadorEntrevista(x);
                CoEntrevistadores = GetCoEntrevistadoresEntrevista(x);

                if (x.AlunoId == null)
                {
                    return EntrevistaResponse response = new EntrevistaResponse(x.ID, x.NomeEntrevistado, x.ContatoEntrevistado, x.TipoContato, x.Indicacao, nomeEntrevistador, CoEntrevistadores,
                    x.DataDaEntrevista, x.Resultado, x.ReEntrevista, x.Ativa, null);
                }

                string nomeAlunoAntigo = AlunoServico.GetNomeAlunoById(x.AlunoId);

                EntrevistaResponse.Add(response);
            }

            return EntrevistaResponse;
        }

        public string GetEntrevistadorEntrevista(Entrevista entrevista)
        {

            string entrevistador = _context.Alunos.Where(a => a.ID == entrevista.Entrevistador).Select(a => a.Nome).ToString();
            return entrevistador;
        }

        public List<string> GetCoEntrevistadoresEntrevista(Entrevista x)
        {
            List<int> coEntrevistadoresId = _context.CoEntrevistadoresEntrevista.Where(c => c.EntrevistaId == x.ID).Select(c => c.AlunoId).ToList();
            List<string> nomeCoEntrevistadores = new List<string>();

            foreach (int id in coEntrevistadoresId)
            {
                string nome = _context.Alunos.Where(a => a.ID == id).Select(a => a.Nome).ToString();
                nomeCoEntrevistadores.Add(nome);
            }

            return nomeCoEntrevistadores;
        }

        public EntrevistaResponse GetEntrevista(int entrevistaId)
        {
            Entrevista entrevista = _context.Entrevistas.SingleOrDefault(a => a.ID == entrevistaId);

            string entrevistador = GetEntrevistadorEntrevista(entrevista);
            List<string> Coentrevistadores = GetCoEntrevistadoresEntrevista(entrevista);

            if (!string.IsNullOrEmpty(entrevista.AlunoId.ToString()))
            {
                string nomeAlunoAntigo = _context.Alunos.SingleOrDefault(x => x.ID == entrevista.AlunoId).ToString();

                EntrevistaResponse entrevistaResponse = new EntrevistaResponse(entrevista.ID, entrevista.NomeEntrevistado, entrevista.ContatoEntrevistado, entrevista.TipoContato,
                entrevista.Indicacao, entrevistador, Coentrevistadores, entrevista.DataDaEntrevista, entrevista.Resultado, entrevista.ReEntrevista, entrevista.Ativa, nomeAlunoAntigo);

                return entrevistaResponse;
            }

            EntrevistaResponse response = new EntrevistaResponse(entrevista.ID, entrevista.NomeEntrevistado, entrevista.ContatoEntrevistado, entrevista.TipoContato,
                entrevista.Indicacao, entrevistador, Coentrevistadores, entrevista.DataDaEntrevista, entrevista.Resultado, entrevista.ReEntrevista, entrevista.Ativa, null);

            return response;

        }

    }
}
