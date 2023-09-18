using System.Runtime.Serialization;

namespace GrupoMok.Entities
{
    /// <summary>
    ///     Instancia de respuesta generica del api
    /// </summary>
    /// <typeparam name="T">Tipo de objetos devueltos</typeparam>
    [DataContract]
    public class Response<T>
    {
        /// <summary>
        ///     Codigo de respuesta cadena
        /// </summary>
        [DataMember(Name = "code")]
        public string? Code { get; set; }

        /// <summary>
        ///     Descripcion del codigo de respuesta
        /// </summary>
        [DataMember(Name = "desc")]
        public string? Desc { get; set; }

        /// <summary>
        /// Tipo de dato devuelto como resultado
        /// </summary>
        [DataMember(Name = "results")]
        public T? Results { get; set; }
    }



}