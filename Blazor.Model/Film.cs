using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Model
{
    public class Film
    {
        public int id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string titulo { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string director { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public DateTime release { get; set; }
    }
}
