using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class DatosGrado
    {
        public DataTable mostrar()
        {
            DataTable dtResultado = new DataTable("grado");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                Conexion ocnx = new Conexion();
                sqlCon.ConnectionString = ocnx.getConexion();
                SqlCommand ocmd = new SqlCommand();
                ocmd.Connection = sqlCon;
                ocmd.CommandText = "SP_MOSTRARGRADO";
                ocmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter oda = new SqlDataAdapter(ocmd);
                oda.Fill(dtResultado);
            }
            catch (Exception ex)
            {
                dtResultado = null;
                throw;
            }

            return dtResultado;
        }

        public DataTable buscargrado(Grado ogrado)
        {

            DataTable dtResultado = new DataTable("grado");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                Conexion ocnx = new Conexion();
                sqlCon.ConnectionString = ocnx.getConexion();
                SqlCommand ocmd = new SqlCommand();
                ocmd.Connection = sqlCon;
                ocmd.CommandText = "SP_BUSCARXGRADO";
                ocmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parTextoBuscar = new SqlParameter();
                parTextoBuscar.ParameterName = "@texto";
                parTextoBuscar.SqlDbType = SqlDbType.VarChar;
                parTextoBuscar.Value = ogrado.Grados;
                ocmd.Parameters.Add(parTextoBuscar);
                SqlDataAdapter oda = new SqlDataAdapter(ocmd);
                oda.Fill(dtResultado);
            }
            catch (Exception ex)
            {
                dtResultado = null;
                throw;
            }

            return dtResultado;

        }
    }
}
