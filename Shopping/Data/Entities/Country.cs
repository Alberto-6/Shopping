using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name = "Pais")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener {1} caracteres")]
        [Required(ErrorMessage = "El Campo [0] es obligatorio")]
        public string Name { get; set; }
    }
}
