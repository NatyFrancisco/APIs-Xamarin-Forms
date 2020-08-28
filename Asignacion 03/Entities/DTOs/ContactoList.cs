using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnicornDemoApi.Entities.DTOs
{
    public class ContactoList
    {
        public int idUser { get; set; }

        public ContactoList<Usuario> contactosAgregados { get; set; }
    }
}
