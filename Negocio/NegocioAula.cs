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
    public class NegocioAula
    {
        public static DataTable buscaraula (string textoBuscar)
        {
            Aula oaula = new Aula();
            oaula.Aulas = textoBuscar;
            DatosAula odaula = new DatosAula();
            return odaula.buscaraula(oaula);
        }
        public static DataTable mostrar()
        {
            return new DatosMatricula().mostrar();
        }
    }
}
