using GrupoMok.BL;
using GrupoMok.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GrupoMok.Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class GrupoMok1Controller : ControllerBase
    {


        [HttpGet]
        [Route("Get/MensajeApi2")]
        public ActionResult<Response<string>> GetMensajeApi2()
        {
            var Result = GrupoMokBL.GetApi2();
            return Result;
        }


        [HttpGet]
        [Route("Get/Clientes")]
        public ActionResult<Response<ClientesResponse>> GetClientes()
        {
            var Result = GrupoMokBL.GetClientesBL();
            return Result;
        }


        [HttpPost]
        [Route("Post/ClienteId")]
        public ActionResult<Response<ClientesResponse>> GetClientesId(ClienteIdRequest Request)
        {
            var Result = GrupoMokBL.GetClientesBL_Id(Request);
            return Result;
        }


        [HttpDelete]
        [Route("Delete/Cliente")]
        public ActionResult<Response<long>> DeleteCliente(ClienteIdRequest Request)
        {
            var Result = GrupoMokBL.DeleteClienteBL(Request);
            return Result;
        }



    }
}
