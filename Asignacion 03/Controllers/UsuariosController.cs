using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnicornDemoApi.Services;

namespace UnicornDemoApi.Controllers
{
    [Route("api/v1/UnicornDemoApi/[Controller]")]
    public class UsuariosController : Controllers
    {
        private UnicornDemoContext _netCoreX = new UnicornDemoContext();
        private UnitOfWork unitOfWork = new UnitOfWork(new UnicornDemoContext());


        [HttpGet]
        public IActionResult GetAllUser()
        {
            var usuarios = _unitOfWork.Usuarios.Get();
            if (usuarios != null)
            {
                return Ok(usuarios);


            }
            else
            {


                return Ok();
            }
        }

                [HttpGet(Id)]

                public IActionResult GetById(int Lid)
                {
            Usuario usuario = _UnitOfWork.usuarios.GetById(id);

        if (usuario != null)
            {
                return Ok(usuario);


    }
            else
            {


                return BadRequest("No se ha encontrado un registro con este Id");
}
            }

        [HttPut]

        public IActionResut UpdateUser([FromBody] UsuarioController usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _unitOfWork.Usuarios.Update(usuario);

                    _unitOfWork.Save();
                    return Ok();
                }
                else
                    return BadRequest();

            }
            catch (DataException ex)
            {
                return BadRequest(ex);
            }
        }


            [HttpDelete("id")]

            public IActionResut DeleteUser(int id)

               {

                if (id != 0)
                {
                    _unitOfWork.Usuario.Delete(id);
                    _unitOfWork.Save();
                    return Ok("Usuario eliminado");
                }
                else
                {
                    return BadRequest("Usuario con id invalido");
                }

                }
            }
    }
    



   
    



    






