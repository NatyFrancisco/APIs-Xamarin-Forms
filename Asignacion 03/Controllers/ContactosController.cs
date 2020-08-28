using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnicornDemoApi.Services;

namespace UnicornDemoApi.Controllers
{
    [Route("api/v1/UnicornDemoApi/[Controller]")]

    public class ContactosController : Controller
    {
        
        private UnitOfWork unitOfWork = new UnitOfWork(new UnicornDemoContext());


        [HttpGet("idUsuario")]
        public IActionResult GetContactos(int idUsuario)

        {if (idUsuario != 0)
            {
                var user = unitOfWork.Usuarios.Get(x => x.Id == idUsuario);
                if (user != null)
                {
                    var contactos = UnitOfWork.Contactos.Get(x => x.IdUsuario == idUsuario);
                    var result = CreateMappedObject(contactos, idUsuario);
                    var serializedlist = JsonConvert.SerializeObject(result, Formatting.Idented,
                        new JsonSereializerSettings()
                        {
                            RefferenceLoopHandling = ReferenceLoopHandling.Serialize
                        });
                    return Ok(serializedList);


                
            }
                else
                    return BadRequest();
        }
                else
                    return BadRequest();
    }

        private  ContactoList CreateMappedObject(IEnumerable<Contacto> contactos, int idUsuario)
        {
            ContactoList listaAmigos = new ContactoList();
            foreach (var item in contactos)
            {
                Usuario contactoAmigo = unitOfWork.Usuarios.GetById(item.IdContacto);
                listaAmigos.contactosAgregados.Add(contactoAmigo);
            }
            listaAmigos.idUser = idUsuario;
            return listaAmigos;
        }
            

    }
}
