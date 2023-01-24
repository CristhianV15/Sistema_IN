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
    public class NegocioGrado
    {
        public static DataTable buscargrado(string textoBuscar)
        {
            Grado ogrado = new Grado();
            ogrado.Grados = textoBuscar;
            DatosGrado odgrado = new DatosGrado();
            return odgrado.buscargrado(ogrado);
        }
        public static DataTable mostrar()
        {
            return new DatosMatricula().mostrar();
        }
    }
}
