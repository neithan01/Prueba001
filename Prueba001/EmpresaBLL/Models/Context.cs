using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EmpresaBLL.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=Prueba01;Integrated Security=true;")
                .EnableSensitiveDataLogging(true);
        }

        public DbSet<Contacto> Contactos {get; set;}
        public DbSet<Telefono> Telefonos { get; set; }
    }
}
