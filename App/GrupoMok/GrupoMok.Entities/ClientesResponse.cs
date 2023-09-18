using System.Runtime.Serialization;

namespace GrupoMok.Entities
{

    [DataContract]
    public class ClientesResponse
    {
        [DataMember(Name = "Cur_ClientesResponse")]
        public List<Cur_ClientesResponse>? Cur_ClientesResponse { get; set; }
    }


    public class Cur_ClientesResponse
    {
        [DataMember(Name = "Id_Persona")]
        public string? Id_Persona { get; set; }

        [DataMember(Name = "Nom_Persona")]
        public string? Nom_Persona { get; set; }

        [DataMember(Name = "Nom_Ciudad")]
        public string? Nom_Ciudad { get; set; }

        [DataMember(Name = "Nom_Producto")]
        public string? Nom_Producto { get; set; }

        [DataMember(Name = "Nom_Banco")]
        public string? Nom_Banco { get; set; }

    }
}
