using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Projeto_Login.Models
{
    [Table("TipoSaida")]
    public class TipoSaida
    {
        [Column("Id")]
        [Display(Name = "Tipo de Saída")]
        public int Id { get; set; }

        [Column("TipoSaidaDescricao")]
        [Display(Name = "Descrição do Tipo de Saída")]
        public string TipoSaidaDescricao { get; set; } = string.Empty;
    }
}
