using System;
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
    public partial class FrmAula : Form
    {
        public FrmAula()
        {
            InitializeComponent();
        }


    
        private void mostrar()
        {
            dgvAula.DataSource = NegocioAula.mostrar();
            //lblTotal.Text = "Total de registros:" + Convert.ToString(dgvCliente.Rows.Count - 1);
        }
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            dgvAula.DataSource = NegocioAula.buscaraula(txtaula.Text);
        }
    }
}
