using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Projeto_Login.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("Id")]
        [Display(Name = "Código do Usuário")]
        public int Id { get; set; }

        [Column("NomeUsuario")]
        [Display(Name = "Nome do Usuário")]
        public string NomeUsuario { get; set; } = string.Empty;

        [Column("Email")]
        [Display(Name = "Email")]
        public string Email { get; set; } = string.Empty;

        [Column("Senha")]
        [Display(Name = "Senha")]
        public string Senha { get; set; } = string.Empty;
    }
}
