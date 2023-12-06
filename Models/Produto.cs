using Projeto_Login.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Projeto_Login.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("Id")]
        [Display(Name = "Identificação do produto")]
        public int Id { get; set; }

        [Column("ProdutoNome")]
        [Display(Name = "Nome do produto")]
        public string ProdutoNome { get; set; } = string.Empty;

        [Column("ProdutoQuantidade")]
        [Display(Name = "Quantidade em estoque")]
        public int ProdutoQuantidade { get; set; }

        [ForeignKey("TipoprodutoId")]
        [Display(Name = "Tipo de produto")]
        public int TipoprodutoId { get; set; }
        public Tipoproduto? Tipoproduto { get; set; }

        [ForeignKey("FornecedorId")]
        [Display(Name = "Fornecedor")]
        public int FornecedorId { get; set; }
        public Fornecedor? Fornecedor { get; set; }
    }
}