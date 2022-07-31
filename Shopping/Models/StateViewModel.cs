using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Models
{
    public class StateViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Departamento/Estado")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener {1} caracteres")]
        [Required(ErrorMessage = "El Campo [0] es obligatorio")]
        public string Name { get; set; }

        public int CountryId { get; set; }
    }
}
