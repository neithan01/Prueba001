using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaBLL.Models
{
    public class Contacto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public ICollection<Telefono> Telefonos { get; set; }
        public ICollection<Agenda> Agendas { get; set; }
    }
}
