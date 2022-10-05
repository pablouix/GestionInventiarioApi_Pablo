using Microsoft.AspNetCore.Mvc;

namespace GestionInventiarioApi_Pablo.Controllers
{
    //direccion/articulos/Listar
    [ApiController]
    [Route("articulos")]
    public class ArticulosController : ControllerBase
    {
        [HttpGet]
        [Route("Listar")]
        public dynamic ListarArticulos()
        {


           // return new { id = 1, descripcion = "Celular"};



        }


        /*
        [HttpPost]
        [Route("Guardar")]
        public dynamic ListarArticulos()
        {

        }
        */

    }
}
