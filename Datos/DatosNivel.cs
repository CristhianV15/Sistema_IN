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
    public class DatosNivel
    {
        public DataTable mostrar()
        {
            DataTable dtResultado = new DataTable("nivel");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                Conexion ocnx = new Conexion();
                sqlCon.ConnectionString = ocnx.getConexion();
                SqlCommand ocmd = new SqlCommand();
                ocmd.Connection = sqlCon;
                ocmd.CommandText = "SP_MOSTRARNIVEL";
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

        public DataTable buscarnivel(Nivel onivel)
        {

            DataTable dtResultado = new DataTable("nivel");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                Conexion ocnx = new Conexion();
                sqlCon.ConnectionString = ocnx.getConexion();
                SqlCommand ocmd = new SqlCommand();
                ocmd.Connection = sqlCon;
                ocmd.CommandText = "SP_BUSCARXNIVEL";
                ocmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parTextoBuscar = new SqlParameter();
                parTextoBuscar.ParameterName = "@texto";
                parTextoBuscar.SqlDbType = SqlDbType.VarChar;
                parTextoBuscar.Value = onivel.Niveles;
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
