using System.Net;

namespace GrupoMok.BL.Api
{
    public class ApiOpen
    {
        public async Task<string> GetUrl(string Url)
        {
            WebRequest Request = WebRequest.Create(Url);            
            WebResponse Response = Request.GetResponse();
            StreamReader Reader = new StreamReader(Response.GetResponseStream());
            return await Reader.ReadToEndAsync();
        }
    }
}
