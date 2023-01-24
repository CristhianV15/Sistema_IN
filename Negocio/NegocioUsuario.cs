using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
using System.Data;

namespace Negocio
{
    public class NegocioUsuario
    {
        public static DataTable login(string usuario, string password)
        {
            Usuarios ouser = new Usuarios();
            ouser.Usuario = usuario;
            ouser.Password = password;
            DatosUsuarios odu = new DatosUsuarios();
            return odu.login(ouser);
        }
    }
}
