using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace myfinance_web_dotnet_o8.Models
{
    public class PlanoContaModel
    {
        [Key]
        public int? Id { get; set; }
        
        [Required(ErrorMessage="* Descrição do item de Plano de Conta é obrigatória!")]
	    public required String Nome { get; set; }

        [Required(ErrorMessage="* Tipo do item de Plano de Conta é obrigatório!")]
	    public required String Tipo { get; set; }

    }
}