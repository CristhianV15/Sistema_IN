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
    public class NegocioNivel
    {
        public static DataTable buscarpornivel (string textoBuscar)
        {
            Nivel onivel = new Nivel();
            onivel.Niveles = textoBuscar;
            DatosNivel odnivel = new DatosNivel();
            return odnivel.buscarnivel(onivel);
        }
        public static DataTable mostrar()
        {
            return new DatosMatricula().mostrar();
        }
    }
}
