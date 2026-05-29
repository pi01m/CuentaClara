namespace CuentaClara_TrabajoCampo
{
    partial class frmLogIn
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
            panelLogin = new Panel();
            picLogo = new PictureBox();
            lblTitulo = new Label();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblClave = new Label();
            txtClave = new TextBox();
            btnIngresar = new Button();
            btnSalir = new Button();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.White;
            panelLogin.BorderStyle = BorderStyle.FixedSingle;
            panelLogin.Controls.Add(picLogo);
            panelLogin.Controls.Add(lblTitulo);
            panelLogin.Controls.Add(lblUsuario);
            panelLogin.Controls.Add(txtUsuario);
            panelLogin.Controls.Add(lblClave);
            panelLogin.Controls.Add(txtClave);
            panelLogin.Controls.Add(btnIngresar);
            panelLogin.Controls.Add(btnSalir);
            panelLogin.Location = new Point(40, 30);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(440, 340);
            panelLogin.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Location = new Point(30, 25);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(86, 80);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(20, 70, 120);
            lblTitulo.Location = new Point(135, 45);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(173, 37);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "CuentaClara";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(50, 130);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(128, 17);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Nombre de Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(50, 155);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(330, 25);
            txtUsuario.TabIndex = 3;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClave.Location = new Point(50, 205);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(77, 17);
            lblClave.TabIndex = 4;
            lblClave.Text = "Contraseña";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(50, 230);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(330, 25);
            txtClave.TabIndex = 5;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(18, 87, 150);
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(200, 280);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(110, 40);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.White;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(18, 87, 150);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(18, 87, 150);
            btnSalir.Location = new Point(80, 280);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(110, 40);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // frmLogIn
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(520, 420);
            Controls.Add(panelLogin);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CuentaClara - Inicio de Sesión";
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogin;

        private PictureBox picLogo;

        private Label lblTitulo;

        private Label lblUsuario;
        private TextBox txtUsuario;

        private Label lblClave;
        private TextBox txtClave;

        private Button btnIngresar;
        private Button btnSalir;
    }
}