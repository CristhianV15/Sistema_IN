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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            DataTable Datos = NegocioUsuario.login(txtUsuario.Text, txtContraseña.Text);
            if (Datos.Rows.Count == 0)
            {
                MessageBox.Show("No tiene acceso al sistema", "Sistema | I.E.P ISAAC NEWTON", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Principal frm1 = new Principal();
                frm1.Visible = true;
                Visible = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
