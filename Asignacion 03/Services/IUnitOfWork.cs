using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnicornDemoApi.Services
{
    public interface IUnitOfWork
    {
        IRepository <Usuario> Usuarios { get; }
        IRepository<Contacto> Contactos { get; }

        void Save();
    }

}
