
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Barbearia.API.DTO;
using Barbearia.API.Models;

namespace Barbearia.API.DTO
{
    public class AgendamentoDTO
    {

        public int AgendamentoID { get; set; }

        [Required]
        public DateTime Data { get; set; }

        public string Observacoes { get; set; }

        [Required]
        public int Status { get; set; }

        [Required]
        public int ClienteID { get; set; }

        public Cliente Cliente { get; set; }

        public virtual ICollection<Servico> Servicos { get; set; }

    }
}




