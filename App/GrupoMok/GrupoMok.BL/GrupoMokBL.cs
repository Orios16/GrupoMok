using GrupoMok.DA;
using GrupoMok.BL.Api;
using GrupoMok.Entities;

namespace GrupoMok.BL
{
    public class GrupoMokBL
    {

        readonly static string Url = "http://localhost:5241/";
        readonly static ApiOpen ApiOpen = new();

        public static Response<string> GetApi2()
        {
            var Result = new Response<string>
            {
                Code = "0",
                Desc = "OK"
            };
            var ResponseApi = ApiOpen.GetUrl(Url + "Get/Mensaje/");
            Result.Desc = ResponseApi.Result.ToString();
            return Result;
        }


        public static Response<ClientesResponse> GetClientesBL()
        {
            var Result = GrupoMokDA.GetClientesDa();
            return Result;
        }


        public static Response<ClientesResponse> GetClientesBL_Id(ClienteIdRequest Request)
        {
            var Result = GrupoMokDA.GetClientesDa_Id(Request);
            return Result;
        }


        public static Response<long> DeleteClienteBL(ClienteIdRequest Request)
        {

            Response<long> _Response = new();

            var Result_Id = GrupoMokDA.GetClientesDa_Id(Request);

            if (Result_Id.Code == "0")
            {
                _Response.Code = "0";
                _Response.Desc = "El registro a eliminar no existe";
                return _Response;
            }

            var Result = GrupoMokDA.DeleteClienteDA(Request);
            return Result;
        }





    }
}