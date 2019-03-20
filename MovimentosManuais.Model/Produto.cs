
using System.ComponentModel.DataAnnotations;

namespace MovimentosManuais.Model
{
    public class Produto
    {
        [Required(ErrorMessage = "Codigo Produto e necessario")]
        public string CodProduto { get; set; }
        public string DesProduto { get; set; }
        public string StaStatus { get; set; }

    }
}
