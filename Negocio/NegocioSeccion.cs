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
    public class NegocioSeccion
    {
        public static DataTable buscarporseccion(string textoBuscar)
        {
            Seccion oseccion = new Seccion();
            oseccion.Secciones = textoBuscar;
            DatosSeccion odseccion = new DatosSeccion();
            return odseccion.buscarporseccion(oseccion);
        }
        public static DataTable mostrar()
        {
            return new DatosMatricula().mostrar();
        }
    }
}
