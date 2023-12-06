using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Projeto_Login.Models
{
    [Table("Fornecedor")]
    public class Fornecedor
    {
        [Column("Id")]
        [Display(Name = "Identificação do fornecedor")]
        public int Id { get; set; }

        [Column("FornecedorNome")]
        [Display(Name = "Nome do fornecedor")]
        public string FornecedorNome { get; set; } = string.Empty;

        [Column("FornecedorEmail")]
        [Display(Name = "E-mail do fornecedor")]
        public string FornecedorEmail { get; set; } = string.Empty;

        [Column("FornecedorCnpj")]
        [Display(Name = "Cnpj do fornecedor")]
        public string FornecedorCnpj { get; set; } = string.Empty;
    }
}