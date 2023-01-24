using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;

namespace Datos
{
    public class DatosAlumno
    {
       public DataTable buscarAlumno(Alumno oalu)
        {
            DataTable dtResultado = new DataTable("Alumno");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                Conexion ocnx = new Conexion();
                sqlCon.ConnectionString = ocnx.getConexion();
                SqlCommand ocmd = new SqlCommand();
                ocmd.Connection = sqlCon;
                ocmd.CommandText = "SP_BuscarAlumno";//agregar a la bd
                ocmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parTextoBuscar = new SqlParameter();
                parTextoBuscar.ParameterName = "@DNI";
                parTextoBuscar.SqlDbType = SqlDbType.Char;
                parTextoBuscar.Size = 8;
                parTextoBuscar.Value = oalu.Dni;
                ocmd.Parameters.Add(parTextoBuscar);
                SqlDataAdapter oda = new SqlDataAdapter();
                oda.Fill(dtResultado);
            }
            catch (Exception ex)//(JUSTO AQUI ES EL MOMENTO DONDE APARECE MI EX :'( :V
            {
                dtResultado = null;
                throw;//Lanza la pava pe xd 
                
            }
            return dtResultado;


        }

        public DataTable buscarAlumnoMatriculado(Alumno oalu)
        {
            DataTable dtResultado = new DataTable("Alumno");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                Conexion ocnx = new Conexion();
                sqlCon.ConnectionString = ocnx.getConexion();
                SqlCommand ocmd = new SqlCommand();
                ocmd.Connection = sqlCon;
                ocmd.CommandText = "SP_BuscarAlumnoMatriculado";//agregar a la bd
                ocmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parTextoBuscar = new SqlParameter();
                parTextoBuscar.ParameterName = "@DNI";
                parTextoBuscar.SqlDbType = SqlDbType.Char;
                parTextoBuscar.Size = 8;
                parTextoBuscar.Value = oalu.Dni;
                ocmd.Parameters.Add(parTextoBuscar);
                SqlDataAdapter oda = new SqlDataAdapter();
                oda.Fill(dtResultado);
            }
            catch (Exception ex)//(JUSTO AQUI ES EL MOMENTO DONDE APARECE MI EX :'( :V
            {
                dtResultado = null;
                throw;//Lanza la pava pe xd 

            }
            return dtResultado;


        }
    }
}

