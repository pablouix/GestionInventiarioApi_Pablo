using Microsoft.AspNetCore.Mvc;
using GestionInventiarioApi_Pablo.Models;

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

            List<Articulos> articulos = new List<Articulos>
            {
                new Articulos
                {
                    articuloId = 1,
                    descripcion = "Moto",
                    marca = "GT",
                    existencia = 1
                },

                new Articulos
                {
                    articuloId = 1,
                    descripcion = "Moto",
                    marca = "HL",
                    existencia = 23
                }

            };


            return articulos;
        }


        
        [HttpPost]
        [Route("Guardar")]
        public dynamic ListarArticulos(Articulos articulos)
        {
             articulos.articuloId = 3;

            return new
            {
                success = true,
                message = "Articulo registrado..",
                result = articulos
                
            };
        }
        

    }
}
