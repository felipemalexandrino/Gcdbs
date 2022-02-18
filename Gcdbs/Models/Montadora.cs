using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gcdbs.Models
{
    public class Montadora
    {
        [Key]
        public int IdMontadora { get; set; }

        [Display(Name = "Nome Montadora")]
        public string NomeMontadora { get; set; }
        public List<Modelo> Modelos { get; set; }
    }
}
