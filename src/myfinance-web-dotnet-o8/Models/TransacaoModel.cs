using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using myfinance_web_dotnet_o8.Services;

namespace myfinance_web_dotnet_o8.Models
{
    public class TransacaoModel
    {        
        [Key]        
        public int? Id { get; set; }

        [Required(ErrorMessage = "* Histórico da Transação é obrigatório!")]
        public String Historico { get; set; }

        [Required(ErrorMessage = "* Data da Transação é obrigatória!")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "* Valor da Transação é obrigatório!")]
        public decimal Valor { get; set; }
        
        public int? PlanoContaId { get; set; }

        public String? Tipo { get; set; } 
        
        public IEnumerable<SelectListItem>? PlanoContas {get; set; }
    }
}