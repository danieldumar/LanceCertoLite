using System;
using System.ComponentModel.DataAnnotations;

namespace LanceCertoLite.Models
{
    public class Leilao
    {
        public int LeilaoId { get; set; }

        [Required]
        public string Titulo { get; set; }

        [Display(Name = "Nome do Imóvel")]
        [Required]
        public string NomeImovel { get; set; }

        [Display(Name = "Nome do Dono")]
        [Required]
        public string NomeDono { get; set; }

        [Display(Name = "Valor Inicial (R$)")]
        [DataType(DataType.Currency)]
        [Range(0.01, double.MaxValue, ErrorMessage = "O valor inicial deve ser maior que zero.")]
        public decimal ValorInicial { get; set; }

        [Display(Name = "Início do Leilão")]
        public DateTime DataInicio { get; set; }

        [Display(Name = "Fim do Leilão")]
        public DateTime DataFim { get; set; }
    }
}
