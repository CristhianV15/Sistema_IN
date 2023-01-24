﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class FrmSeccion : Form
    {
        public FrmSeccion()
        {
            InitializeComponent();
        }
        private void mostrar()
        {
            dgvSeccion.DataSource = NegocioSeccion.mostrar();
            //lblTotal.Text = "Total de registros:" + Convert.ToString(dgvCliente.Rows.Count - 1);
        }
       
          
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvSeccion.DataSource = NegocioSeccion.buscarporseccion(txtNombre.Text);
        }
    }
}
