using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Model
{
    public class Film
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string director { get; set; }
        public DateTime release { get; set; }
    }
}
