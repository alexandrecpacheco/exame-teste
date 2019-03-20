using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovimentosManuais.Model
{
    public class ProdutoCosif
    {
        List<Produto> produtos = new List<Produto>();

        [Required(ErrorMessage = "Codigo Produto eh obrigatorio")]
        public Produto CodProduto { get; set; }
        [Required(ErrorMessage = "Codigo Cosif eh obrigatorio")]
        public string CodCosif { get; set; }

        public string CodClassificacao { get; set; }
        public string StaStatus { get; set; }

        public List<Produto> Produtos { get => Produtos; set => Produtos = value; }
    }
}
