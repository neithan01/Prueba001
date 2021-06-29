using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaBLL.Models
{
    public class Telefono
    {
        public int Id { get; set; }
        public string compania { get; set; }
        public string numero { get; set; }
        public Contacto contacto { get; set; }
        public ICollection<Agenda> Agendas{ get; set; }
    }
}
