using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myfinance_web_dotnet_o8.Domain
{
    public class Transacao
    {
        public int? Id { get; set; }
        public String Historico { get; set; }
        public DateTime Data { get; set; }

        public decimal Valor { get; set; }

        public int? PlanoContaId { get; set; }

        public PlanoConta? ItemPlanoConta { get; set; }
    }
}