﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Data.Entities
{
    public class City
    {
        public int Id { get; set; }

       // [Display(Name = "Ciudad")]
       // [MaxLength(50, ErrorMessage = "El campo {0} debe tener {1} caracteres")]
        
        public string Name { get; set; }

        public State State{ get; set; }
    }
}
