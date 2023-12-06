using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Projeto_Login.Models;

namespace Projeto_Login.Models
{
    [Table("EntradaProduto")]
    public class EntradaProduto
    {
        [Column("Id")]
        [Display(Name = "Identificação da entrada do produto")]
        public int Id { get; set; }

        [ForeignKey("ProdutoId")]
        [Display(Name = "Produto")]
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }

        [Column("EntradaProdutoData")]
        [Display(Name = "Data da entrada do produto")]
        public DateTime EntradaProdutoData { get; set; }

        [Column("EntradaProdutoQuantidade")]
        [Display(Name = "Quantidade de produtos que entrou")]
        public int EntradaProdutoQuantidade { get; set; }
    }
}