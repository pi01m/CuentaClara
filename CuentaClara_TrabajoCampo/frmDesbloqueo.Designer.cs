using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CuentaClara_TrabajoCampo
{
    partial class frmDesbloqueo
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
            lblTitulo = new System.Windows.Forms.Label();
            btnSalir = new System.Windows.Forms.Button();
            lblSubtitulo = new System.Windows.Forms.Label();
            dgvUsuariosBloqueados = new DataGridView();
            lblContrasena = new System.Windows.Forms.Label();
            txtContrasena = new System.Windows.Forms.TextBox();
            btnDesbloquear = new System.Windows.Forms.Button();
            pnlFooter = new Panel();
            lblUsuarioActivo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuariosBloqueados).BeginInit();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(18, 87, 150);
            lblTitulo.Location = new Point(35, 23);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(328, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Desbloqueo de Usuarios";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(921, 29);
            btnSalir.Margin = new Padding(4, 3, 4, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(129, 44);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitulo.Location = new Point(368, 104);
            lblSubtitulo.Margin = new Padding(4, 0, 4, 0);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(321, 21);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "USUARIOS ACTUALMENTE BLOQUEADOS";
            // 
            // dgvUsuariosBloqueados
            // 
            dgvUsuariosBloqueados.BackgroundColor = SystemColors.ButtonFace;
            dgvUsuariosBloqueados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuariosBloqueados.Location = new Point(41, 150);
            dgvUsuariosBloqueados.Margin = new Padding(4, 3, 4, 3);
            dgvUsuariosBloqueados.Name = "dgvUsuariosBloqueados";
            dgvUsuariosBloqueados.Size = new Size(1009, 346);
            dgvUsuariosBloqueados.TabIndex = 3;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblContrasena.Location = new Point(41, 537);
            lblContrasena.Margin = new Padding(4, 0, 4, 0);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(288, 19);
            lblContrasena.TabIndex = 4;
            lblContrasena.Text = "Ingresar su Contraseña de Administrador:";
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Segoe UI", 10F);
            txtContrasena.Location = new Point(356, 533);
            txtContrasena.Margin = new Padding(4, 3, 4, 3);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(291, 25);
            txtContrasena.TabIndex = 5;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // btnDesbloquear
            // 
            btnDesbloquear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDesbloquear.Location = new Point(840, 525);
            btnDesbloquear.Margin = new Padding(4, 3, 4, 3);
            btnDesbloquear.Name = "btnDesbloquear";
            btnDesbloquear.Size = new Size(210, 46);
            btnDesbloquear.TabIndex = 6;
            btnDesbloquear.Text = "Desbloquear Usuario";
            btnDesbloquear.UseVisualStyleBackColor = true;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(18, 87, 150);
            pnlFooter.Controls.Add(lblUsuarioActivo);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.ForeColor = Color.White;
            pnlFooter.Location = new Point(0, 611);
            pnlFooter.Margin = new Padding(4, 3, 4, 3);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1108, 35);
            pnlFooter.TabIndex = 7;
            // 
            // lblUsuarioActivo
            // 
            lblUsuarioActivo.AutoSize = true;
            lblUsuarioActivo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsuarioActivo.Location = new Point(12, 8);
            lblUsuarioActivo.Margin = new Padding(4, 0, 4, 0);
            lblUsuarioActivo.Name = "lblUsuarioActivo";
            lblUsuarioActivo.Size = new Size(210, 19);
            lblUsuarioActivo.TabIndex = 0;
            lblUsuarioActivo.Text = "Usuario activo: Administrador";
            // 
            // frmDesbloqueo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1108, 646);
            Controls.Add(pnlFooter);
            Controls.Add(btnDesbloquear);
            Controls.Add(txtContrasena);
            Controls.Add(lblContrasena);
            Controls.Add(dgvUsuariosBloqueados);
            Controls.Add(lblSubtitulo);
            Controls.Add(btnSalir);
            Controls.Add(lblTitulo);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmDesbloqueo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CuentaClara - Gestión de Desbloqueo";
            Load += frmDesbloqueo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuariosBloqueados).EndInit();
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.DataGridView dgvUsuariosBloqueados;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnDesbloquear;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblUsuarioActivo;

    }
}