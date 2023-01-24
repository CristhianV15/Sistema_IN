using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
using Entidades;

namespace Negocio
{
    public class NegocioMatricula
    {
      public static DataTable buscarPorNombre(string textoBuscar)
     {
           Matricula omatricula = new Matricula();
            omatricula.Nombrea = textoBuscar;
            DatosMatricula odmatricula = new DatosMatricula();
            return odmatricula.buscarnombre(omatricula);
        }
        public static DataTable mostrar()
        {
            return new DatosMatricula().mostrar();      
        }
    }
}
