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
    public partial class FrmGrado : Form
    {
        public FrmGrado()
        {
            InitializeComponent();
        }

        private void btnMostar_Click(object sender, EventArgs e)
        {
            dgvGrado.DataSource = NegocioGrado.buscargrado(txtNombre.Text);
        } 
    private void mostrar()
    {
        dgvGrado.DataSource = NegocioMatricula.mostrar();
        //lblTotal.Text = "Total de registros:" + Convert.ToString(dgvCliente.Rows.Count - 1);
    }
}
}
