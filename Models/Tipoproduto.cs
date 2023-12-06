using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Projeto_Login.Models
{
    [Table("Tipoproduto")]
    public class Tipoproduto
    {
        [Column("Id")]
        [Display(Name = "Tipo do Produto")]
        public int Id { get; set; }

        [Column("TipoProdutoDescricao")]
        [Display(Name = "Descrição do Tipo de Produto")]
        public string TipoProdutoDescricao { get; set; } = string.Empty;
    }
}
