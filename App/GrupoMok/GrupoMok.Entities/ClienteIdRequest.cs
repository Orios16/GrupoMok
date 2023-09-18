using System.Runtime.Serialization;

namespace GrupoMok.Entities
{

    [DataContract]
    public class ClienteIdRequest
    {
        [DataMember(Name = "Id_Persona")]
        public string? Id_Persona { get; set; }
    }

}
