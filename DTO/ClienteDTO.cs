
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Barbearia.API.DTO;

namespace Barbearia.API.DTO
{
    public class ClienteDTO
    {

        public int ClienteId { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Telefone { get; set; }

        [EmailAddress(ErrorMessage = "Favor digitar um email valido.")]
        public string Email { get; set; }

        // [Required]
        // [Display(Name = "Data Nascimento")]
        // public DateTime DataNascimento { get; set; }
    }
}




