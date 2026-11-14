using System.Net.Http.Json;
using IBGE_Data_Insights.Models;

namespace IBGE_Data_Insights.Services
{
    public class IbgeService
    {
        private readonly HttpClient _httpClient;

        public IbgeService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<Estado>> GetEstadosAsync()
        {
            var url = "https://servicodados.ibge.gov.br/api/v1/localidades/estados";
            var response = await _httpClient.GetFromJsonAsync<List<Estado>>(url);

            return response?.OrderBy(e => e.nome).ToList() ?? new List<Estado>();
        }

        public async Task<List<NomeRanking>> GetNomesPorLocalidadeAsync(int idLocalidade, string sexo = "")
        {
            var url = $"https://servicodados.ibge.gov.br/api/v2/censos/nomes/ranking?localidade={idLocalidade}";

            if (!string.IsNullOrEmpty(sexo))
            
                url += $"&sexo={sexo}";
            }

            try
            {
                var response = await _httpClient.GetFromJsonAsync<List<NomeResult>>(url);
                return response?.FirstOrDefault()?.res ?? new List<NomeRanking>();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Erro na API: {ex.Message}");
                return new List<NomeRanking>();
            }
        }
    }
}
