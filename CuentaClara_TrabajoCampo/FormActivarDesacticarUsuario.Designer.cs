namespace CuentaClara_TrabajoCampo
{
    partial class FormActivarDesacticarUsuario
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelContenedor = new Panel();
            lblTitulo = new Label();
            dgvUsuarios = new DataGridView();
            btnActivar = new Button();
            btnDesactivar = new Button();
            panelInferior = new Panel();
            lblUsuarioActivo = new Label();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            panelInferior.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.White;
            panelContenedor.Controls.Add(lblTitulo);
            panelContenedor.Controls.Add(dgvUsuarios);
            panelContenedor.Controls.Add(btnActivar);
            panelContenedor.Controls.Add(btnDesactivar);
            panelContenedor.Location = new Point(25, 20);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(950, 520);
            panelContenedor.TabIndex = 0;
            
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(20, 70, 120);
            lblTitulo.Location = new Point(28, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(316, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Activar Desactivar Usuario";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AllowUserToResizeRows = false;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.BackgroundColor = Color.White;
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dgvUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(18, 87, 150);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(18, 87, 150);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(15, 45, 75);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(220, 230, 240);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.GridColor = Color.FromArgb(230, 230, 230);
            dgvUsuarios.Location = new Point(34, 75);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.RowTemplate.Height = 32;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(880, 330);
            dgvUsuarios.TabIndex = 1;
            // 
            // btnActivar
            // 
            btnActivar.BackColor = Color.FromArgb(18, 87, 150);
            btnActivar.FlatAppearance.BorderSize = 0;
            btnActivar.FlatStyle = FlatStyle.Flat;
            btnActivar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnActivar.ForeColor = Color.White;
            btnActivar.Location = new Point(612, 435);
            btnActivar.Name = "btnActivar";
            btnActivar.Size = new Size(140, 42);
            btnActivar.TabIndex = 2;
            btnActivar.Text = "Activar";
            btnActivar.UseVisualStyleBackColor = false;
            // 
            // btnDesactivar
            // 
            btnDesactivar.BackColor = Color.White;
            btnDesactivar.FlatStyle = FlatStyle.Flat;
            btnDesactivar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDesactivar.ForeColor = Color.FromArgb(18, 87, 150);
            btnDesactivar.Location = new Point(774, 435);
            btnDesactivar.Name = "btnDesactivar";
            btnDesactivar.Size = new Size(140, 42);
            btnDesactivar.TabIndex = 3;
            btnDesactivar.Text = "Desactivar";
            btnDesactivar.UseVisualStyleBackColor = false;
            // 
            // panelInferior
            // 
            panelInferior.BackColor = Color.FromArgb(18, 87, 150);
            panelInferior.Controls.Add(lblUsuarioActivo);
            panelInferior.Dock = DockStyle.Bottom;
            panelInferior.Location = new Point(0, 560);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(1000, 40);
            panelInferior.TabIndex = 1;
            panelInferior.Paint += panelInferior_Paint;
            // 
            // lblUsuarioActivo
            // 
            lblUsuarioActivo.AutoSize = true;
            lblUsuarioActivo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsuarioActivo.ForeColor = Color.White;
            lblUsuarioActivo.Location = new Point(20, 12);
            lblUsuarioActivo.Name = "lblUsuarioActivo";
            lblUsuarioActivo.Size = new Size(171, 15);
            lblUsuarioActivo.TabIndex = 0;
            lblUsuarioActivo.Text = "Usuario activo: Administrador";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Apellido";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "DNI";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Rol";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Login";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // FormActivarDesacticarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(1000, 600);
            Controls.Add(panelInferior);
            Controls.Add(panelContenedor);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormActivarDesacticarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CuentaClara - Gestión de Usuarios";
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            panelInferior.ResumeLayout(false);
            panelInferior.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.Button btnDesactivar;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Label lblUsuarioActivo;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}