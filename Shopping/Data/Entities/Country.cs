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

        //[Display(Name = "País")]
        //[MaxLength(50, ErrorMessage = "El campo {0} debe tener {1} caracteres")]
       
        public string Name { get; set; }

        public ICollection<State> States { get; set; }

       // [Display(Name = "Departamento/Estado")]
        public int StatesNumber => States == null ? 0 : States.Count;
    }
}
