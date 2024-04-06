using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace L01P022019AC603.Models
{
    public class departamentos
    {

        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }
        [Display(Name = "Departamento")]
        public string? departamento { get; set; }

    }
}
