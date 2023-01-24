using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Matricula
    {
        private string nombrea, apellidosa;

        public string Apellidosa
        {
            get
            {
                return apellidosa;
            }

            set
            {
                apellidosa = value;
            }
        }

        public string Nombrea
        {
            get
            {
                return nombrea;
            }

            set
            {
                nombrea = value;
            }
        }
    }
}
