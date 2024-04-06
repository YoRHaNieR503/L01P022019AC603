using System.ComponentModel.DataAnnotations;

namespace L01P022019AC603.Models
{
    public class facultades
    {

        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }
        [Display(Name = "Nombre de la facultad")]
        public string? facultad { get; set; }

    }
}
