using System;
using System.ComponentModel.DataAnnotations;

namespace LanceCertoLite.Models
{
    public class Leilao
    {
        public int LeilaoId { get; set; }

        [Required]
        public string Titulo { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }
    }
}
