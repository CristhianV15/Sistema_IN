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
    public class DatosSeccion
    {
        public DataTable mostrar()
        {
            DataTable dtResultado = new DataTable("seccion");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                Conexion ocnx = new Conexion();
                sqlCon.ConnectionString = ocnx.getConexion();
                SqlCommand ocmd = new SqlCommand();
                ocmd.Connection = sqlCon;
                ocmd.CommandText = "SP_MOSTRARSECCION";
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

        public DataTable buscarporseccion(Seccion oseccion)
        {

            DataTable dtResultado = new DataTable("seccion");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                Conexion ocnx = new Conexion();
                sqlCon.ConnectionString = ocnx.getConexion();
                SqlCommand ocmd = new SqlCommand();
                ocmd.Connection = sqlCon;
                ocmd.CommandText = "SP_BUSCARXSECCION";
                ocmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parTextoBuscar = new SqlParameter();
                parTextoBuscar.ParameterName = "@texto";
                parTextoBuscar.SqlDbType = SqlDbType.VarChar;
                parTextoBuscar.Value = oseccion.Secciones;
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
