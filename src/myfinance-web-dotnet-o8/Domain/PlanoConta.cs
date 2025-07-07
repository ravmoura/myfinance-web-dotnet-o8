using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace myfinance_web_dotnet_o8.Domain
{
    public class PlanoConta
    {        
        public int? Id { get; set; }
        [Required]
	    public required String Nome { get; set; }
        [Required]
	    public required String Tipo { get; set; }
    }
}