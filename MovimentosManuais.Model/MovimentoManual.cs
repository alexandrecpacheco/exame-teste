using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovimentosManuais.Model
{
    public class MovimentoManual
    {
        public MovimentoManual()
        {
                
        }

        List<ProdutoCosif> produtoCosifs = new List<ProdutoCosif>();

        [Required(ErrorMessage = "Mes eh obrigatorio")]
        public string DatMes { get; set; }
        [Required(ErrorMessage = "Ano eh obrigatorio")]
        public string DatAno { get; set; }
        [Required(ErrorMessage = "Numero Lancamento eh obrigatorio")]
        public double NumLancamento { get; set; }
        [Required(ErrorMessage = "Codigo Produto eh obrigatorio")]
        public string CodProduto { get; set; }
        [Required(ErrorMessage = "Codigo Cosif eh obrigatorio")]
        public string CodCosif { get; set; }

        [Required(ErrorMessage = "Descricao Produto eh obrigatoria")]
        public string DesProduto { get; set; }

        public string DesDescricao { get; set; }
        public DateTime DatMovimento { get; set; }
        public string CodUsuario { get; set; }
        public double ValValor { get; set; }

        public List<ProdutoCosif> ProdutoCosifs { get => produtoCosifs; set => produtoCosifs = value; }
    }
}
