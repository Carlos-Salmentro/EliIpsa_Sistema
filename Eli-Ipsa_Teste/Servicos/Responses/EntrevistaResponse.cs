using Eli_Ipsa_Teste.Entities;
using Eli_Ipsa_Teste.Entities.Enums;

namespace Eli_Ipsa_Teste.Servicos.Responses
{
    public record EntrevistaResponse(int id, string nomeEntrevistado, string contatoEntrevistado, TipoContato tipoContato, string? indicacao, string entrevistador,
       List<string>? CoEntrevistador, DateTime dataEntrevista, PossiveisResultadosEntrevista? resultado, bool reEntrevista, bool ativa, string? alunoAntigoId);

}
