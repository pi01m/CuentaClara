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
            radioBtnTodosUser = new RadioButton();
            radioBtnUserActivos = new RadioButton();
            txtRol = new TextBox();
            lblDNI = new Label();
            txtDNI = new TextBox();
            lblRol = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            lblLogin = new Label();
            txtLogin = new TextBox();
            chkActivo = new CheckBox();
            lblTitulo = new Label();
            dgvUsuarios = new DataGridView();
            btnCrear = new Button();
            btnDesbloquear = new Button();
            btnModificar = new Button();
            btnActivarDesactivar = new Button();
            btnAplicar = new Button();
            btnCancelar = new Button();
            btnSalir = new Button();
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
            panelContenedor.Controls.Add(radioBtnTodosUser);
            panelContenedor.Controls.Add(radioBtnUserActivos);
            panelContenedor.Controls.Add(txtRol);
            panelContenedor.Controls.Add(lblDNI);
            panelContenedor.Controls.Add(txtDNI);
            panelContenedor.Controls.Add(lblRol);
            panelContenedor.Controls.Add(lblNombre);
            panelContenedor.Controls.Add(txtNombre);
            panelContenedor.Controls.Add(lblApellido);
            panelContenedor.Controls.Add(txtApellido);
            panelContenedor.Controls.Add(lblCorreo);
            panelContenedor.Controls.Add(txtCorreo);
            panelContenedor.Controls.Add(lblLogin);
            panelContenedor.Controls.Add(txtLogin);
            panelContenedor.Controls.Add(chkActivo);
            panelContenedor.Controls.Add(lblTitulo);
            panelContenedor.Controls.Add(dgvUsuarios);
            panelContenedor.Controls.Add(btnCrear);
            panelContenedor.Controls.Add(btnDesbloquear);
            panelContenedor.Controls.Add(btnModificar);
            panelContenedor.Controls.Add(btnActivarDesactivar);
            panelContenedor.Controls.Add(btnAplicar);
            panelContenedor.Controls.Add(btnCancelar);
            panelContenedor.Controls.Add(btnSalir);
            panelContenedor.Controls.Add(lblCantidadUsuarios);
            panelContenedor.Controls.Add(lblTotalUsuarios);
            panelContenedor.Controls.Add(lstMensajes);
            panelContenedor.Location = new Point(49, 55);
            panelContenedor.Margin = new Padding(7, 8, 7, 8);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(3055, 2012);
            panelContenedor.TabIndex = 0;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // radioBtnTodosUser
            // 
            radioBtnTodosUser.AutoSize = true;
            radioBtnTodosUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            radioBtnTodosUser.ForeColor = Color.FromArgb(15, 45, 75);
            radioBtnTodosUser.Location = new Point(525, 186);
            radioBtnTodosUser.Margin = new Padding(7, 8, 7, 8);
            radioBtnTodosUser.Name = "radioBtnTodosUser";
            radioBtnTodosUser.Size = new Size(300, 50);
            radioBtnTodosUser.TabIndex = 33;
            radioBtnTodosUser.TabStop = true;
            radioBtnTodosUser.Text = "Todos Usuarios";
            radioBtnTodosUser.UseVisualStyleBackColor = true;
            radioBtnTodosUser.CheckedChanged += radioBtnTodosUser_CheckedChanged;
            // 
            // radioBtnUserActivos
            // 
            radioBtnUserActivos.AutoSize = true;
            radioBtnUserActivos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            radioBtnUserActivos.ForeColor = Color.FromArgb(15, 45, 75);
            radioBtnUserActivos.Location = new Point(95, 186);
            radioBtnUserActivos.Margin = new Padding(7, 8, 7, 8);
            radioBtnUserActivos.Name = "radioBtnUserActivos";
            radioBtnUserActivos.Size = new Size(322, 50);
            radioBtnUserActivos.TabIndex = 32;
            radioBtnUserActivos.TabStop = true;
            radioBtnUserActivos.Text = "Usuarios Activos";
            radioBtnUserActivos.UseVisualStyleBackColor = true;
            radioBtnUserActivos.CheckedChanged += radioBtnUserActivos_CheckedChanged;
            // 
            // txtRol
            // 
            txtRol.Location = new Point(449, 1807);
            txtRol.Margin = new Padding(7, 8, 7, 8);
            txtRol.Name = "txtRol";
            txtRol.Size = new Size(502, 47);
            txtRol.TabIndex = 31;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDNI.Location = new Point(85, 1222);
            lblDNI.Margin = new Padding(7, 0, 7, 0);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(83, 46);
            lblDNI.TabIndex = 16;
            lblDNI.Text = "DNI";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(449, 1222);
            txtDNI.Margin = new Padding(7, 8, 7, 8);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(502, 47);
            txtDNI.TabIndex = 17;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRol.Location = new Point(97, 1818);
            lblRol.Margin = new Padding(7, 0, 7, 0);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(232, 46);
            lblRol.TabIndex = 18;
            lblRol.Text = "Rol Asignado";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombre.Location = new Point(85, 1328);
            lblNombre.Margin = new Padding(7, 0, 7, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(167, 46);
            lblNombre.TabIndex = 20;
            lblNombre.Text = "Nombres";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(449, 1328);
            txtNombre.Margin = new Padding(7, 8, 7, 8);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(502, 47);
            txtNombre.TabIndex = 21;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblApellido.Location = new Point(85, 1435);
            lblApellido.Margin = new Padding(7, 0, 7, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(170, 46);
            lblApellido.TabIndex = 22;
            lblApellido.Text = "Apellidos";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(449, 1435);
            txtApellido.Margin = new Padding(7, 8, 7, 8);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(502, 47);
            txtApellido.TabIndex = 23;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCorreo.Location = new Point(90, 1561);
            lblCorreo.Margin = new Padding(7, 0, 7, 0);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(316, 46);
            lblCorreo.TabIndex = 24;
            lblCorreo.Text = "Correo Electrónico";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(449, 1550);
            txtCorreo.Margin = new Padding(7, 8, 7, 8);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(502, 47);
            txtCorreo.TabIndex = 25;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLogin.Location = new Point(97, 1670);
            lblLogin.Margin = new Padding(7, 0, 7, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(299, 46);
            lblLogin.TabIndex = 26;
            lblLogin.Text = "Nombre de Login";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(449, 1684);
            txtLogin.Margin = new Padding(7, 8, 7, 8);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(502, 47);
            txtLogin.TabIndex = 27;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            chkActivo.ForeColor = Color.FromArgb(20, 70, 120);
            chkActivo.Location = new Point(449, 1897);
            chkActivo.Margin = new Padding(7, 8, 7, 8);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(454, 50);
            chkActivo.TabIndex = 30;
            chkActivo.Text = "Habilitar Acceso (Activo)";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(20, 70, 120);
            lblTitulo.Location = new Point(73, 55);
            lblTitulo.Margin = new Padding(7, 0, 7, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(661, 89);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Usuarios";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AllowUserToResizeRows = false;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.BackgroundColor = Color.FromArgb(18, 87, 150);
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
            dgvUsuarios.ColumnHeadersHeight = 58;
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
            dgvUsuarios.Location = new Point(85, 287);
            dgvUsuarios.Margin = new Padding(7, 8, 7, 8);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.RowHeadersWidth = 102;
            dgvUsuarios.RowTemplate.Height = 32;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(2365, 875);
            dgvUsuarios.TabIndex = 1;
            dgvUsuarios.SelectionChanged += dgvUsuarios_SelectionChanged;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.FromArgb(18, 87, 150);
            btnCrear.FlatAppearance.BorderSize = 0;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCrear.ForeColor = Color.White;
            btnCrear.Location = new Point(2594, 364);
            btnCrear.Margin = new Padding(7, 8, 7, 8);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(340, 115);
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
            btnDesbloquear.Location = new Point(2594, 558);
            btnDesbloquear.Margin = new Padding(7, 8, 7, 8);
            btnDesbloquear.Name = "btnDesbloquear";
            btnDesbloquear.Size = new Size(340, 115);
            btnDesbloquear.TabIndex = 3;
            btnDesbloquear.Text = "Desbloquear";
            btnDesbloquear.UseVisualStyleBackColor = false;
            btnDesbloquear.Click += btnDesbloquear_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.White;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnModificar.ForeColor = Color.FromArgb(18, 87, 150);
            btnModificar.Location = new Point(2594, 749);
            btnModificar.Margin = new Padding(7, 8, 7, 8);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(340, 115);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnActivarDesactivar
            // 
            btnActivarDesactivar.BackColor = Color.White;
            btnActivarDesactivar.FlatStyle = FlatStyle.Flat;
            btnActivarDesactivar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnActivarDesactivar.ForeColor = Color.FromArgb(18, 87, 150);
            btnActivarDesactivar.Location = new Point(2594, 924);
            btnActivarDesactivar.Margin = new Padding(7, 8, 7, 8);
            btnActivarDesactivar.Name = "btnActivarDesactivar";
            btnActivarDesactivar.Size = new Size(340, 139);
            btnActivarDesactivar.TabIndex = 5;
            btnActivarDesactivar.Text = "Activar / Desactivar";
            btnActivarDesactivar.UseVisualStyleBackColor = false;
            btnActivarDesactivar.Click += btnActivarDesactivar_Click;
            // 
            // btnAplicar
            // 
            btnAplicar.BackColor = Color.FromArgb(18, 87, 150);
            btnAplicar.FlatAppearance.BorderSize = 0;
            btnAplicar.FlatStyle = FlatStyle.Flat;
            btnAplicar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAplicar.ForeColor = Color.White;
            btnAplicar.Location = new Point(1365, 1818);
            btnAplicar.Margin = new Padding(7, 8, 7, 8);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(340, 115);
            btnAplicar.TabIndex = 6;
            btnAplicar.Text = "Aplicar";
            btnAplicar.UseVisualStyleBackColor = false;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(18, 87, 150);
            btnCancelar.Location = new Point(2004, 1818);
            btnCancelar.Margin = new Padding(7, 8, 7, 8);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(340, 115);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.White;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(18, 87, 150);
            btnSalir.Location = new Point(2618, 1818);
            btnSalir.Margin = new Padding(7, 8, 7, 8);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(340, 115);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblCantidadUsuarios
            // 
            lblCantidadUsuarios.AutoSize = true;
            lblCantidadUsuarios.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCantidadUsuarios.ForeColor = Color.FromArgb(15, 45, 75);
            lblCantidadUsuarios.Location = new Point(1897, 202);
            lblCantidadUsuarios.Margin = new Padding(7, 0, 7, 0);
            lblCantidadUsuarios.Name = "lblCantidadUsuarios";
            lblCantidadUsuarios.Size = new Size(304, 46);
            lblCantidadUsuarios.TabIndex = 4;
            lblCantidadUsuarios.Text = "Total de Usuarios:";
            // 
            // lblTotalUsuarios
            // 
            lblTotalUsuarios.AutoSize = true;
            lblTotalUsuarios.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalUsuarios.ForeColor = Color.FromArgb(18, 87, 150);
            lblTotalUsuarios.Location = new Point(2283, 202);
            lblTotalUsuarios.Margin = new Padding(7, 0, 7, 0);
            lblTotalUsuarios.Name = "lblTotalUsuarios";
            lblTotalUsuarios.Size = new Size(60, 46);
            lblTotalUsuarios.TabIndex = 5;
            lblTotalUsuarios.Text = "15";
            // 
            // lstMensajes
            // 
            lstMensajes.BorderStyle = BorderStyle.FixedSingle;
            lstMensajes.Font = new Font("Segoe UI", 9F);
            lstMensajes.FormattingEnabled = true;
            lstMensajes.ItemHeight = 41;
            lstMensajes.Location = new Point(1343, 1249);
            lstMensajes.Margin = new Padding(7, 8, 7, 8);
            lstMensajes.Name = "lstMensajes";
            lstMensajes.Size = new Size(1612, 494);
            lstMensajes.TabIndex = 6;
            // 
            // panelInferior
            // 
            panelInferior.BackColor = Color.FromArgb(18, 87, 150);
            panelInferior.Controls.Add(lblUsuarioActivo);
            panelInferior.Dock = DockStyle.Bottom;
            panelInferior.Location = new Point(0, 1999);
            panelInferior.Margin = new Padding(7, 8, 7, 8);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(3164, 109);
            panelInferior.TabIndex = 0;
            // 
            // lblUsuarioActivo
            // 
            lblUsuarioActivo.AutoSize = true;
            lblUsuarioActivo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsuarioActivo.ForeColor = Color.White;
            lblUsuarioActivo.Location = new Point(49, 33);
            lblUsuarioActivo.Margin = new Padding(7, 0, 7, 0);
            lblUsuarioActivo.Name = "lblUsuarioActivo";
            lblUsuarioActivo.Size = new Size(440, 41);
            lblUsuarioActivo.TabIndex = 0;
            lblUsuarioActivo.Text = "Usuario activo: Administrador";
            // 
            // FormGestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(3164, 2108);
            Controls.Add(panelInferior);
            Controls.Add(panelContenedor);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(7, 8, 7, 8);
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

        private System.Windows.Forms.Label lblCantidadUsuarios;
        private System.Windows.Forms.Label lblTotalUsuarios;

        private System.Windows.Forms.ListBox lstMensajes;

        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Label lblUsuarioActivo;
        private Label lblDNI;
        private TextBox txtDNI;
        private Label lblRol;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblCorreo;
        private TextBox txtCorreo;
        private Label lblLogin;
        private TextBox txtLogin;
        private CheckBox chkActivo;
        private TextBox txtRol;
        private RadioButton radioBtnUserActivos;
        private RadioButton radioBtnTodosUser;
    }
}