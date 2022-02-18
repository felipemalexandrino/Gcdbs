using System.ComponentModel.DataAnnotations;

namespace Gcdbs.Models
{
    public class Modelo
    {
        [Key]
        public int IdModelo { get; set; }

        [Display(Name="Nome Modelo")]
        public string NomeModelo { get; set; }
    }
}
