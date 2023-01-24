namespace Presentacion
{
    partial class FrmBuscarConceptoPago
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvBuscarConceptoPago = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rbOpcionales = new System.Windows.Forms.RadioButton();
            this.rbPrincipales = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarConceptoPago)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBuscarConceptoPago
            // 
            this.dgvBuscarConceptoPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarConceptoPago.Location = new System.Drawing.Point(23, 193);
            this.dgvBuscarConceptoPago.MultiSelect = false;
            this.dgvBuscarConceptoPago.Name = "dgvBuscarConceptoPago";
            this.dgvBuscarConceptoPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuscarConceptoPago.Size = new System.Drawing.Size(741, 196);
            this.dgvBuscarConceptoPago.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.rbOpcionales);
            this.groupBox1.Controls.Add(this.rbPrincipales);
            this.groupBox1.Location = new System.Drawing.Point(63, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por Tipo de Concepto de Pago";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(488, 29);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(130, 47);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // rbOpcionales
            // 
            this.rbOpcionales.AutoSize = true;
            this.rbOpcionales.Location = new System.Drawing.Point(244, 45);
            this.rbOpcionales.Name = "rbOpcionales";
            this.rbOpcionales.Size = new System.Drawing.Size(78, 17);
            this.rbOpcionales.TabIndex = 1;
            this.rbOpcionales.Text = "Opcionales";
            this.rbOpcionales.UseVisualStyleBackColor = true;
            // 
            // rbPrincipales
            // 
            this.rbPrincipales.AutoSize = true;
            this.rbPrincipales.Checked = true;
            this.rbPrincipales.Location = new System.Drawing.Point(127, 45);
            this.rbPrincipales.Name = "rbPrincipales";
            this.rbPrincipales.Size = new System.Drawing.Size(76, 17);
            this.rbPrincipales.TabIndex = 0;
            this.rbPrincipales.TabStop = true;
            this.rbPrincipales.Text = "Principales";
            this.rbPrincipales.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar Concepto de Pago";
            // 
            // FrmBuscarConceptoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 437);
            this.Controls.Add(this.dgvBuscarConceptoPago);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBuscarConceptoPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBuscarConceptoPago";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarConceptoPago)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuscarConceptoPago;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RadioButton rbOpcionales;
        private System.Windows.Forms.RadioButton rbPrincipales;
        private System.Windows.Forms.Label label1;
    }
}