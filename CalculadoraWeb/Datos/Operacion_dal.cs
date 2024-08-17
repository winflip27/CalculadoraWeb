using CalculadoraWeb.Vistas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace CalculadoraWeb.Datos
{
    public class Operacion_dal
    {
        private readonly string _connectionString = "LAPTOP-LEVCK5RM\\SQLEXPRESS";

        public void RegistrarOperacion(Operacion operacion)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_RegistrarOperacion", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TipoOperacion", operacion.TipoOperacion);
                cmd.Parameters.AddWithValue("@Numero1", operacion.Numero1);
                cmd.Parameters.AddWithValue("@Numero2", operacion.Numero2);
                cmd.Parameters.AddWithValue("@Resultado", operacion.Resultado);
                cmd.Parameters.AddWithValue("@Fecha", operacion.Fecha);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }