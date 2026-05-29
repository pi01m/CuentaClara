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
            lblPassword = new Label();
            txtPassword = new TextBox();
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
            panelPrincipal.Controls.Add(lblPassword);
            panelPrincipal.Controls.Add(txtPassword);
            panelPrincipal.Controls.Add(chkActivo);
            panelPrincipal.Controls.Add(btnCancelar);
            panelPrincipal.Controls.Add(btnGuardar);
            panelPrincipal.Location = new Point(30, 30);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(660, 430);
            panelPrincipal.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(20, 70, 120);
            lblTitulo.Location = new Point(25, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(252, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Crear Nuevo Usuario";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDNI.Location = new Point(30, 90);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(34, 19);
            lblDNI.TabIndex = 1;
            lblDNI.Text = "DNI";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(30, 115);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(250, 25);
            txtDNI.TabIndex = 2;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRol.Location = new Point(360, 90);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(98, 19);
            lblRol.TabIndex = 3;
            lblRol.Text = "Rol Asignado";
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.Location = new Point(360, 115);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(250, 25);
            cmbRol.TabIndex = 4;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombre.Location = new Point(30, 160);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 19);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombres";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(30, 185);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 25);
            txtNombre.TabIndex = 6;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblApellido.Location = new Point(360, 160);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(72, 19);
            lblApellido.TabIndex = 7;
            lblApellido.Text = "Apellidos";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(360, 185);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(250, 25);
            txtApellido.TabIndex = 8;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCorreo.Location = new Point(30, 230);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(134, 19);
            lblCorreo.TabIndex = 9;
            lblCorreo.Text = "Correo Electrónico";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(30, 255);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(250, 25);
            txtCorreo.TabIndex = 10;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLogin.Location = new Point(360, 230);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(127, 19);
            lblLogin.TabIndex = 11;
            lblLogin.Text = "Nombre de Login";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(360, 255);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(250, 25);
            txtLogin.TabIndex = 12;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPassword.Location = new Point(30, 300);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(84, 19);
            lblPassword.TabIndex = 13;
            lblPassword.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(30, 325);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(250, 25);
            txtPassword.TabIndex = 14;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            chkActivo.ForeColor = Color.FromArgb(20, 70, 120);
            chkActivo.Location = new Point(360, 325);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(195, 23);
            chkActivo.TabIndex = 15;
            chkActivo.Text = "Habilitar Acceso (Activo)";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(18, 87, 150);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(18, 87, 150);
            btnCancelar.Location = new Point(360, 375);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 40);
            btnCancelar.TabIndex = 16;
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
            btnGuardar.Location = new Point(490, 375);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 40);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // FormCrearUsuario
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(720, 500);
            Controls.Add(panelPrincipal);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormCrearUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CuentaClara - Crear Usuario";
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

        private Label lblPassword;
        private TextBox txtPassword;

        private Label lblRol;
        private ComboBox cmbRol;

        private CheckBox chkActivo;

        private Button btnGuardar;
        private Button btnCancelar;
    }
}