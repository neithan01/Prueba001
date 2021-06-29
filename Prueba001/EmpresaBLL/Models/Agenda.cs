using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaBLL.Models
{
    public class Agenda
    {
        public int Id { get; set; }
        public Contacto contacto { get; set; }
        public Telefono telefono { get; set; }
    }
}
