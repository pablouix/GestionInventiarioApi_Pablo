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


        [HttpGet]
        [Route("ListarId")]
        public dynamic ListarArticulosId(int id)
        {
            return new Articulos
            {
                articuloId = id,
                descripcion = "Moto",
                marca = "GP",
                existencia = 3
            };
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


        [HttpPost]
        [Route("Eliminar")]
        public dynamic eliminarArticulo(Articulos artoculos)
        {
          string token =  Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value;

            if(token != "2")
            {
                return new
                {
                    success = true,
                    message = "token incorrecto..",
                    result = ""

                };
            }

            return new
            {
                success = true,
                message = "Articulo eliminado..",
                result = ""

            };
        }



    }
}
