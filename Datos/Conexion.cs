using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Conexion
    {
        private string cnx;
        public string getConexion()
        {

            cnx = @"Data Source =DESKTOP-932IDPP\SQLEXPRESS; Initial Catalog = DB_IEP; User ID = sa; Password = sql753";
            return cnx;
        }
    }
}
    
