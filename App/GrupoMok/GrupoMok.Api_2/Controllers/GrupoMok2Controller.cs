using Microsoft.AspNetCore.Mvc;

namespace GrupoMok.Api_2.Controllers
{
    public class GrupoMok2Controller : Controller
    {

        [HttpGet]
        [Route("Get/Mensaje")]
        public ActionResult GetMensaje()
        {            
            return Content("Conexion Exitosa");
        }


    }
}
