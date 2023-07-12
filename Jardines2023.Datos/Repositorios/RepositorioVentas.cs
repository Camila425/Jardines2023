using Jardines2023.Comun.Interfaces;
using Jardines2023.Entidades.Dtos;
using Jardines2023.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardines2023.Datos.Repositorios
{
    public class RepositorioVentas : IRepositorioVentas
    {
        private readonly string cadenaConexion;
        public RepositorioVentas()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }

     
        public List<VentaDto> GetVentas()
        {
            try
            {
                List<VentaDto> lista = new List<VentaDto>();
                using (var conn = new SqlConnection(cadenaConexion))
                {
                    conn.Open();
                    string selectQuery = "SELECT VentaId, FechaVenta, c.Nombres,Total" +
                        "  FROM Ventas  v inner join Clientes c on v.ClienteId=c.ClienteId";
                    using (var comando = new SqlCommand(selectQuery, conn))
                    {
                        using (var reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var venta = ConsTruirVenta(reader);
                                lista.Add(venta);
                            }
                        }
                    }
                }
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private VentaDto ConsTruirVenta(SqlDataReader reader)
        {
            return new VentaDto()
            {
                VentaId=reader.GetInt32(0),
                Fecha=reader.GetDateTime(1),
                cliente=reader.GetString(2),
                total=reader.GetDecimal(3),
            };
        }
    }

}
