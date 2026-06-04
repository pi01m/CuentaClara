namespace CuentaClara_TrabajoCampo
{
    partial class FormGestionUsuarios
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
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            btnCrear = new Button();
            btnDesbloquear = new Button();
            btnModificar = new Button();
            btnActivarDesactivar = new Button();
            btnAplicar = new Button();
            btnCancelar = new Button();
            btnSalir = new Button();
            chkUsuariosActivos = new CheckBox();
            chkTodosUsuarios = new CheckBox();
            lblCantidadUsuarios = new Label();
            lblTotalUsuarios = new Label();
            lstMensajes = new ListBox();
            panelInferior = new Panel();
            lblUsuarioActivo = new Label();
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
            panelContenedor.Controls.Add(btnCrear);
            panelContenedor.Controls.Add(btnDesbloquear);
            panelContenedor.Controls.Add(btnModificar);
            panelContenedor.Controls.Add(btnActivarDesactivar);
            panelContenedor.Controls.Add(btnAplicar);
            panelContenedor.Controls.Add(btnCancelar);
            panelContenedor.Controls.Add(btnSalir);
            panelContenedor.Controls.Add(chkUsuariosActivos);
            panelContenedor.Controls.Add(chkTodosUsuarios);
            panelContenedor.Controls.Add(lblCantidadUsuarios);
            panelContenedor.Controls.Add(lblTotalUsuarios);
            panelContenedor.Controls.Add(lstMensajes);
            panelContenedor.Location = new Point(20, 20);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1240, 680);
            panelContenedor.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(20, 70, 120);
            lblTitulo.Location = new Point(30, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(272, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Usuarios";
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
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(220, 230, 240);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.GridColor = Color.FromArgb(230, 230, 230);
            dgvUsuarios.Location = new Point(35, 105);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.RowTemplate.Height = 32;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(1165, 320);
            dgvUsuarios.TabIndex = 1;
            dgvUsuarios.AutoGenerateColumns = false;
           
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
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Estado";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.FromArgb(18, 87, 150);
            btnCrear.FlatAppearance.BorderSize = 0;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCrear.ForeColor = Color.White;
            btnCrear.Location = new Point(35, 565);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(140, 42);
            btnCrear.TabIndex = 2;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnDesbloquear
            // 
            btnDesbloquear.BackColor = Color.White;
            btnDesbloquear.FlatStyle = FlatStyle.Flat;
            btnDesbloquear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDesbloquear.ForeColor = Color.FromArgb(18, 87, 150);
            btnDesbloquear.Location = new Point(190, 565);
            btnDesbloquear.Name = "btnDesbloquear";
            btnDesbloquear.Size = new Size(140, 42);
            btnDesbloquear.TabIndex = 3;
            btnDesbloquear.Text = "Desbloquear";
            btnDesbloquear.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.White;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnModificar.ForeColor = Color.FromArgb(18, 87, 150);
            btnModificar.Location = new Point(345, 565);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(140, 42);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnActivarDesactivar
            // 
            btnActivarDesactivar.BackColor = Color.White;
            btnActivarDesactivar.FlatStyle = FlatStyle.Flat;
            btnActivarDesactivar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnActivarDesactivar.ForeColor = Color.FromArgb(18, 87, 150);
            btnActivarDesactivar.Location = new Point(500, 565);
            btnActivarDesactivar.Name = "btnActivarDesactivar";
            btnActivarDesactivar.Size = new Size(180, 42);
            btnActivarDesactivar.TabIndex = 5;
            btnActivarDesactivar.Text = "Activar / Desactivar";
            btnActivarDesactivar.UseVisualStyleBackColor = false;
            // 
            // btnAplicar
            // 
            btnAplicar.BackColor = Color.FromArgb(18, 87, 150);
            btnAplicar.FlatAppearance.BorderSize = 0;
            btnAplicar.FlatStyle = FlatStyle.Flat;
            btnAplicar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAplicar.ForeColor = Color.White;
            btnAplicar.Location = new Point(835, 565);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(140, 42);
            btnAplicar.TabIndex = 6;
            btnAplicar.Text = "Aplicar";
            btnAplicar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(18, 87, 150);
            btnCancelar.Location = new Point(990, 565);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 42);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.White;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(18, 87, 150);
            btnSalir.Location = new Point(1145, 565);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(90, 42);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // chkUsuariosActivos
            // 
            chkUsuariosActivos.AutoSize = true;
            chkUsuariosActivos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            chkUsuariosActivos.ForeColor = Color.FromArgb(15, 45, 75);
            chkUsuariosActivos.Location = new Point(40, 70);
            chkUsuariosActivos.Name = "chkUsuariosActivos";
            chkUsuariosActivos.Size = new Size(138, 23);
            chkUsuariosActivos.TabIndex = 2;
            chkUsuariosActivos.Text = "Usuarios Activos";
            chkUsuariosActivos.UseVisualStyleBackColor = true;
            // 
            // chkTodosUsuarios
            // 
            chkTodosUsuarios.AutoSize = true;
            chkTodosUsuarios.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            chkTodosUsuarios.ForeColor = Color.FromArgb(15, 45, 75);
            chkTodosUsuarios.Location = new Point(220, 70);
            chkTodosUsuarios.Name = "chkTodosUsuarios";
            chkTodosUsuarios.Size = new Size(129, 23);
            chkTodosUsuarios.TabIndex = 3;
            chkTodosUsuarios.Text = "Todos Usuarios";
            chkTodosUsuarios.UseVisualStyleBackColor = true;
            // 
            // lblCantidadUsuarios
            // 
            lblCantidadUsuarios.AutoSize = true;
            lblCantidadUsuarios.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCantidadUsuarios.ForeColor = Color.FromArgb(15, 45, 75);
            lblCantidadUsuarios.Location = new Point(960, 73);
            lblCantidadUsuarios.Name = "lblCantidadUsuarios";
            lblCantidadUsuarios.Size = new Size(128, 19);
            lblCantidadUsuarios.TabIndex = 4;
            lblCantidadUsuarios.Text = "Total de Usuarios:";
            // 
            // lblTotalUsuarios
            // 
            lblTotalUsuarios.AutoSize = true;
            lblTotalUsuarios.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalUsuarios.ForeColor = Color.FromArgb(18, 87, 150);
            lblTotalUsuarios.Location = new Point(1105, 73);
            lblTotalUsuarios.Name = "lblTotalUsuarios";
            lblTotalUsuarios.Size = new Size(25, 19);
            lblTotalUsuarios.TabIndex = 5;
            lblTotalUsuarios.Text = "15";
            // 
            // lstMensajes
            // 
            lstMensajes.BorderStyle = BorderStyle.FixedSingle;
            lstMensajes.Font = new Font("Segoe UI", 9F);
            lstMensajes.FormattingEnabled = true;
            lstMensajes.ItemHeight = 15;
            lstMensajes.Location = new Point(35, 445);
            lstMensajes.Name = "lstMensajes";
            lstMensajes.Size = new Size(1165, 92);
            lstMensajes.TabIndex = 6;
            // 
            // panelInferior
            // 
            panelInferior.BackColor = Color.FromArgb(18, 87, 150);
            panelInferior.Controls.Add(lblUsuarioActivo);
            panelInferior.Dock = DockStyle.Bottom;
            panelInferior.Location = new Point(0, 720);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(1280, 40);
            panelInferior.TabIndex = 0;
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
            // FormGestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(1280, 760);
            Controls.Add(panelInferior);
            Controls.Add(panelContenedor);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormGestionUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CuentaClara - Gestión de Usuarios";
            Load += FormGestionUsuarios_Load_1;
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

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnDesbloquear;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnActivarDesactivar;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;

        private System.Windows.Forms.CheckBox chkUsuariosActivos;
        private System.Windows.Forms.CheckBox chkTodosUsuarios;

        private System.Windows.Forms.Label lblCantidadUsuarios;
        private System.Windows.Forms.Label lblTotalUsuarios;

        private System.Windows.Forms.ListBox lstMensajes;

        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Label lblUsuarioActivo;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}