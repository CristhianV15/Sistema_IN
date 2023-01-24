using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DatosUsuarios
    {
        public DataTable login(Usuarios ouser)
        {
            DataTable dtResultado = new DataTable("usuarios");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                Conexion ocnx = new Conexion();
                sqlCon.ConnectionString = ocnx.getConexion();
                SqlCommand ocmd = new SqlCommand();
                ocmd.Connection = sqlCon;
                ocmd.CommandText = "SP_LOGIN";
                ocmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parlogin = new SqlParameter();
                parlogin.ParameterName = "@USUARIO";
                parlogin.SqlDbType = SqlDbType.VarChar;
                parlogin.Size = 20;
                parlogin.Value = ouser.Usuario;
                ocmd.Parameters.Add(parlogin);

                SqlParameter parClave = new SqlParameter();
                parClave.ParameterName = "@PASSWORD";
                parClave.SqlDbType = SqlDbType.VarChar;
                parClave.Size = 20;
                parClave.Value = ouser.Password;
                ocmd.Parameters.Add(parClave);

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
