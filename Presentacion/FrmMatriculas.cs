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
    public partial class FrmMatriculas : Form
    {
        public FrmMatriculas()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
        private void mostrar()
        {
            dgvMatriculas.DataSource = NegocioMatricula.mostrar();
            //lblTotal.Text = "Total de registros:" + Convert.ToString(dgvCliente.Rows.Count - 1);
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscarAlumnoMatriculado frm = new FrmBuscarAlumnoMatriculado();
            frm.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarMatricula_Click(object sender, EventArgs e)
        {
            dgvMatriculas.DataSource = NegocioMatricula.buscarPorNombre(txtBuscar.Text);
            //lblTotal.Text = "Total de registros:" + Convert.ToString(dgvMatriculas.Rows.Count - 1);
        }

        private void FrmMatriculas_Load(object sender, EventArgs e)
        {

        }
    }
}
