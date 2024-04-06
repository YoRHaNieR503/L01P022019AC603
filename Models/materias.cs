using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace L01P022019AC603.Models
{
    public class materias
    {
        [Key]
        [Display(Name ="ID")]
        public int id { get; set; }
        [Display(Name = "Nombre de la materia")]
        public string? materia { get; set; }
        [Display(Name = "Unidades valorativas")]
        public int? unidades_valorativas { get; set; }
        [Display(Name = "Estado")]
        public string? estado { get; set; }
    }
}
