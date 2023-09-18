using System.Data;
using GrupoMok.Entities;
using System.Data.SqlClient;

namespace GrupoMok.DA
{
    public class GrupoMokDA
    {

        internal const string Conex = "data source=ALGARCOL-CLARO1\\SQLEXPRESS;initial catalog=GrupoMok;user=GrupoMok;pwd=GrupoMok$2023*;TrustServerCertificate=True;";

        public static Response<ClientesResponse> GetClientesDa()
        {
            try
            {
                SqlConnection SqlConn = new(Conex);
                SqlConn.Open();

                SqlCommand Com = new()
                {
                    Connection = SqlConn,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "GetClientes"
                };

                SqlParameter NumRegistros = new("NumRegistros", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };

                Com.Parameters.Add(NumRegistros);

                var DataReader = Com.ExecuteReader();

                if (DataReader.HasRows)
                {
                    List<Cur_ClientesResponse> CurClientes = new();
                    var DataTable = new DataTable();
                    DataTable.Load(DataReader);

                    int Registros = Convert.ToInt32(Com.Parameters["NumRegistros"].Value);

                    for (int i = 0; i < Registros; i++)
                    {
                        CurClientes.Add(new Cur_ClientesResponse
                        {
                            Id_Persona = DataTable.Rows[i]["Id_Persona"].ToString(),
                            Nom_Banco = DataTable.Rows[i]["Nom_Banco"].ToString(),
                            Nom_Ciudad = DataTable.Rows[i]["Nom_Ciudad"].ToString(),
                            Nom_Persona = DataTable.Rows[i]["Nom_Persona"].ToString(),
                            Nom_Producto = DataTable.Rows[i]["Nom_Producto"].ToString()
                        });
                    }

                    return new Response<ClientesResponse>
                    {
                        Code = "1",
                        Desc = "Consulta Exitosa",
                        Results = new ClientesResponse
                        {
                            Cur_ClientesResponse = CurClientes
                        }
                    };
                }
                else
                {
                    return new Response<ClientesResponse>
                    {
                        Code = "0",
                        Desc = "No se Encontraron Datos"
                    };
                }
            }
            catch (Exception exception)
            {
                return new Response<ClientesResponse>
                {
                    Code = "0",
                    Desc = "Error en metodo(GrupoMok.DA-GetClientesDa) = " + exception.Message
                };
            }
        }


        public static Response<ClientesResponse> GetClientesDa_Id(ClienteIdRequest Request)
        {
            try
            {
                SqlConnection SqlConn = new(Conex);
                SqlConn.Open();

                SqlCommand Com = new()
                {
                    Connection = SqlConn,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "GetClientes_Id"
                };
                Com.Parameters.Add("@Id_Persona", SqlDbType.Int).Value = Request.Id_Persona;

                SqlParameter NumRegistros = new("NumRegistros", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };

                Com.Parameters.Add(NumRegistros);

                var DataReader = Com.ExecuteReader();

                if (DataReader.HasRows)
                {
                    List<Cur_ClientesResponse> CurClientes = new();
                    var DataTable = new DataTable();
                    DataTable.Load(DataReader);

                    int Registros = Convert.ToInt32(Com.Parameters["NumRegistros"].Value);

                    for (int i = 0; i < Registros; i++)
                    {
                        CurClientes.Add(new Cur_ClientesResponse
                        {
                            Id_Persona = DataTable.Rows[i]["Id_Persona"].ToString(),
                            Nom_Banco = DataTable.Rows[i]["Nom_Banco"].ToString(),
                            Nom_Ciudad = DataTable.Rows[i]["Nom_Ciudad"].ToString(),
                            Nom_Persona = DataTable.Rows[i]["Nom_Persona"].ToString(),
                            Nom_Producto = DataTable.Rows[i]["Nom_Producto"].ToString()
                        });
                    }

                    return new Response<ClientesResponse>
                    {
                        Code = "1",
                        Desc = "Consulta Exitosa",
                        Results = new ClientesResponse
                        {
                            Cur_ClientesResponse = CurClientes
                        }
                    };
                }
                else
                {
                    return new Response<ClientesResponse>
                    {
                        Code = "0",
                        Desc = "No se Encontraron Datos"
                    };
                }
            }
            catch (Exception exception)
            {
                return new Response<ClientesResponse>
                {
                    Code = "0",
                    Desc = "Error en metodo(GrupoMok.DA-GetClientesDa_Id) = " + exception.Message
                };
            }
        }


        public static Response<long> DeleteClienteDA(ClienteIdRequest Request)
        {
            try
            {
                SqlConnection SqlConn = new(Conex);
                SqlConn.Open();

                SqlCommand Com = new()
                {
                    Connection = SqlConn,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "DeleteCliente"
                };
                Com.Parameters.Add("@Id_Persona", SqlDbType.Int).Value = Request.Id_Persona;

                Com.ExecuteNonQuery();

                return new Response<long>
                {
                    Code = "1",
                    Desc = "Registro Eliminado"
                };

            }
            catch (Exception exception)
            {
                return new Response<long>
                {
                    Code = "0",
                    Desc = "Error en metodo(GrupoMok.DA-DeleteClienteDA) = " + exception.Message
                };
            }
        }



    }
}
