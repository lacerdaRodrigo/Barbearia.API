using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Barbearia.API.Models
{
    public class Servico
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Favor colocar um nome para o serviço")]
        [DisplayName("Nome Serviço")]
        public string NomeServico { get; set; }

        [DisplayName("Descrição")]
        public string Descicao { get; set; }

        [Range(10, 999, ErrorMessage = "A duração precisa ficar de 10 ate 999.")]
        public int DuracaoMin { get; set; }


        [Range(0.01, 999.00, ErrorMessage = "Preço deve ficar entre 0.01 ate 999.00")]
        public double Preco { get; set; }



    }
}
