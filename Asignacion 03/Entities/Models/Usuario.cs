using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace UnicornDemoApi.Entities.Models
{
    public class Usuario
    {
        public  int id { get; set ; }
    public string nombre { get; set; }
    public string correo { get; set; }
    public int telefono { get; set; }
    public string nombreUsuario { get; set; }
    public Datetime nechaNacimiento { get; set; }
    public Datetime fechaIngreso  { get; set; }
    public string colorFavorito { get; set; }
    public string sexo { get; set; }
}
}
