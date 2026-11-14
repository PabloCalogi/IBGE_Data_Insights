using System.Collections.Generic;

namespace IBGE_Data_Insights.Models
{
    public class NomeRanking
    {
        public string nome { get; set; }
        public int frequencia { get; set; }
        public int ranking { get; set; }
    }

    public class NomeResult
    {
        public string localidade { get; set; }
        public string sexo { get; set; }
        public List<NomeRanking> res { get; set; }
    }
}