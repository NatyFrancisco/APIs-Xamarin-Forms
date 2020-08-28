using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnicornDemoApi.Entities.Models
{
    public class Contacto
    {
        public  int id { get; set ; }
    public int idUsuario { get; set; }
    public int idContacto { get; set; }

    public Datetime fechaCreacion { get; set; }
}
}
