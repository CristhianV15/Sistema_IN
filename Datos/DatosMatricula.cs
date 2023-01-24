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
    public class DatosMatricula
    {
        public DataTable mostrar()
        {
            DataTable dtResultado = new DataTable("matricula");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                Conexion ocnx = new Conexion();
                sqlCon.ConnectionString = ocnx.getConexion();
                SqlCommand ocmd = new SqlCommand();
                ocmd.Connection = sqlCon;
                ocmd.CommandText = "SP_MOSTRARMATRICULA";
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
       
        public DataTable buscarnombre(Matricula omatricula)
        {

            DataTable dtResultado = new DataTable("matricula");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                Conexion ocnx = new Conexion();
                sqlCon.ConnectionString = ocnx.getConexion();
                SqlCommand ocmd = new SqlCommand();
                ocmd.Connection = sqlCon;
                ocmd.CommandText = "SP_BUSCARXNOMBRE";
                ocmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parTextoBuscar = new SqlParameter();
                parTextoBuscar.ParameterName = "@texto";
                parTextoBuscar.SqlDbType = SqlDbType.VarChar;
                parTextoBuscar.Value = omatricula.Nombrea;
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

