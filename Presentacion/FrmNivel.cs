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
    public partial class FrmNivel : Form
    {
        public FrmNivel()
        {
            InitializeComponent();
        }
        
        private void mostrar()
        {
           dgvNivelEstudio.DataSource = NegocioMatricula.mostrar();
            //lblTotal.Text = "Total de registros:" + Convert.ToString(dgvCliente.Rows.Count - 1);
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            dgvNivelEstudio.DataSource = NegocioNivel.buscarpornivel(txtNombre.Text);
        
    }
    }
}
