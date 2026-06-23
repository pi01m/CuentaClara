namespace CuentaClara_TrabajoCampo
{
    partial class FormCrearUsuario
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
            panelPrincipal = new Panel();
            lblTitulo = new Label();
            lblDNI = new Label();
            txtDNI = new TextBox();
            lblRol = new Label();
            cmbRol = new ComboBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            lblLogin = new Label();
            txtLogin = new TextBox();
            chkActivo = new CheckBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.White;
            panelPrincipal.BorderStyle = BorderStyle.FixedSingle;
            panelPrincipal.Controls.Add(lblTitulo);
            panelPrincipal.Controls.Add(lblDNI);
            panelPrincipal.Controls.Add(txtDNI);
            panelPrincipal.Controls.Add(lblRol);
            panelPrincipal.Controls.Add(cmbRol);
            panelPrincipal.Controls.Add(lblNombre);
            panelPrincipal.Controls.Add(txtNombre);
            panelPrincipal.Controls.Add(lblApellido);
            panelPrincipal.Controls.Add(txtApellido);
            panelPrincipal.Controls.Add(lblCorreo);
            panelPrincipal.Controls.Add(txtCorreo);
            panelPrincipal.Controls.Add(lblLogin);
            panelPrincipal.Controls.Add(txtLogin);
            panelPrincipal.Controls.Add(chkActivo);
            panelPrincipal.Controls.Add(btnCancelar);
            panelPrincipal.Controls.Add(btnGuardar);
            panelPrincipal.Location = new Point(22, 27);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(803, 605);
            panelPrincipal.TabIndex = 0;
            panelPrincipal.Paint += panelPrincipal_Paint;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(20, 70, 120);
            lblTitulo.Location = new Point(35, 33);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(617, 81);
            lblTitulo.TabIndex = 0;
            lblTitulo.Tag = "lbl_TituloCrearNuevoUsuario";
            lblTitulo.Text = "Crear Nuevo Usuario";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDNI.Location = new Point(53, 163);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(83, 46);
            lblDNI.TabIndex = 1;
            lblDNI.Tag = "lbl_DNI";
            lblDNI.Text = "DNI";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(53, 185);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(250, 52);
            txtDNI.TabIndex = 2;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRol.Location = new Point(433, 153);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(232, 46);
            lblRol.TabIndex = 3;
            lblRol.Tag = "lbl_RolAsignado";
            lblRol.Text = "Rol Asignado";
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.Items.AddRange(new object[] { "Admin", "Operador" });
            cmbRol.Location = new Point(433, 185);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(250, 53);
            cmbRol.TabIndex = 4;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombre.Location = new Point(53, 238);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(167, 46);
            lblNombre.TabIndex = 5;
            lblNombre.Tag = "lbl_Nombre";
            lblNombre.Text = "Nombres";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(53, 275);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 52);
            txtNombre.TabIndex = 6;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblApellido.Location = new Point(433, 249);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(170, 46);
            lblApellido.TabIndex = 7;
            lblApellido.Tag = "lbl_Apellido";
            lblApellido.Text = "Apellidos";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(433, 275);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(250, 52);
            txtApellido.TabIndex = 8;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCorreo.Location = new Point(53, 326);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(316, 46);
            lblCorreo.TabIndex = 9;
            lblCorreo.Tag = "lbl_Correo";
            lblCorreo.Text = "Correo Electrónico";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(53, 359);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(250, 52);
            txtCorreo.TabIndex = 10;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLogin.Location = new Point(433, 326);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(299, 46);
            lblLogin.TabIndex = 11;
            lblLogin.Tag = "lbl_NomdeLogin";
            lblLogin.Text = "Nombre de Login";
            // 
            // txtLogin
            // 
            txtLogin.Enabled = false;
            txtLogin.Location = new Point(433, 359);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(250, 52);
            txtLogin.TabIndex = 12;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            chkActivo.ForeColor = Color.FromArgb(20, 70, 120);
            chkActivo.Location = new Point(53, 431);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(454, 50);
            chkActivo.TabIndex = 15;
            chkActivo.Tag = "chk_Activo";
            chkActivo.Text = "Habilitar Acceso (Activo)";
            chkActivo.CheckedChanged += chkActivo_CheckedChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(18, 87, 150);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(18, 87, 150);
            btnCancelar.Location = new Point(83, 492);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(204, 52);
            btnCancelar.TabIndex = 16;
            btnCancelar.Tag = "btn_Cancelar";
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(18, 87, 150);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(433, 492);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(212, 52);
            btnGuardar.TabIndex = 17;
            btnGuardar.Tag = "btn_Guardar";
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FormCrearUsuario
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(856, 669);
            Controls.Add(panelPrincipal);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormCrearUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CuentaClara - Crear Usuario";
            FormClosed += FormCrearUsuario_FormClosed;
            Load += FormCrearUsuario_Load_1;
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;

        private Label lblTitulo;

        private Label lblDNI;
        private TextBox txtDNI;

        private Label lblNombre;
        private TextBox txtNombre;

        private Label lblApellido;
        private TextBox txtApellido;

        private Label lblCorreo;
        private TextBox txtCorreo;

        private Label lblLogin;
        private TextBox txtLogin;

        private Label lblRol;
        private ComboBox cmbRol;

        private CheckBox chkActivo;

        private Button btnGuardar;
        private Button btnCancelar;
    }
}