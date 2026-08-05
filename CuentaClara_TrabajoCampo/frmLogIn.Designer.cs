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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            panelLogin = new Panel();
            ojo = new Button();
            picLogo = new PictureBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            lblTitulo = new Label();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblClave = new Label();
            txtContrasena = new TextBox();
            btnIngresar = new Button();
            btnSalir = new Button();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.Anchor = AnchorStyles.None;
            panelLogin.BackColor = Color.White;
            panelLogin.BorderStyle = BorderStyle.FixedSingle;
            panelLogin.Controls.Add(ojo);
            panelLogin.Controls.Add(picLogo);
            panelLogin.Controls.Add(label1);
            panelLogin.Controls.Add(comboBox1);
            panelLogin.Controls.Add(lblTitulo);
            panelLogin.Controls.Add(lblUsuario);
            panelLogin.Controls.Add(txtUsuario);
            panelLogin.Controls.Add(lblClave);
            panelLogin.Controls.Add(txtContrasena);
            panelLogin.Controls.Add(btnIngresar);
            panelLogin.Controls.Add(btnSalir);
            panelLogin.Location = new Point(68, 67);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(716, 771);
            panelLogin.TabIndex = 0;
            panelLogin.Paint += panelLogin_Paint;
            // 
            // ojo
            // 
            ojo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ojo.BackColor = Color.FromArgb(18, 87, 150);
            ojo.FlatAppearance.BorderSize = 0;
            ojo.FlatStyle = FlatStyle.Flat;
            ojo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ojo.ForeColor = Color.White;
            ojo.Location = new Point(586, 409);
            ojo.Name = "ojo";
            ojo.Size = new Size(55, 52);
            ojo.TabIndex = 11;
            ojo.Tag = "";
            ojo.UseVisualStyleBackColor = false;
            ojo.Click += button1_Click;
            // 
            // picLogo
            // 
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(46, 25);
            picLogo.Margin = new Padding(0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(103, 89);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 10;
            picLogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(100, 502);
            label1.Name = "label1";
            label1.Size = new Size(127, 45);
            label1.TabIndex = 9;
            label1.Tag = "lbl_LogInClave";
            label1.Text = "Idioma";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(99, 550);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(287, 53);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(20, 70, 120);
            lblTitulo.Location = new Point(152, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(420, 89);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "CuentaClara";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(99, 224);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(322, 45);
            lblUsuario.TabIndex = 2;
            lblUsuario.Tag = "lbl_LogInNombreUsuario";
            lblUsuario.Text = "Nombre de Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUsuario.Location = new Point(99, 272);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(456, 52);
            txtUsuario.TabIndex = 3;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClave.Location = new Point(100, 352);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(196, 45);
            lblClave.TabIndex = 4;
            lblClave.Tag = "lbl_LogInClave";
            lblClave.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            txtContrasena.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtContrasena.Location = new Point(100, 409);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(455, 52);
            txtContrasena.TabIndex = 5;
            txtContrasena.TextChanged += txtContrasena_TextChanged;
            // 
            // btnIngresar
            // 
            btnIngresar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnIngresar.BackColor = Color.FromArgb(18, 87, 150);
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(416, 670);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(184, 62);
            btnIngresar.TabIndex = 6;
            btnIngresar.Tag = "btn_Ingresar";
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSalir.BackColor = Color.White;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(18, 87, 150);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(18, 87, 150);
            btnSalir.Location = new Point(100, 670);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(153, 62);
            btnSalir.TabIndex = 7;
            btnSalir.Tag = "btn_Salir";
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmLogIn
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(848, 872);
            Controls.Add(panelLogin);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(497, 562);
            Name = "frmLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "lbl_FormLogin";
            Text = "CuentaClara - Inicio de Sesión";
            FormClosed += frmLogIn_FormClosed;
            Load += frmLogIn_Load_1;
            Resize += frmLogIn_Resize;
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogin;

        private Label lblTitulo;

        private Label lblUsuario;
        private TextBox txtUsuario;

        private Label lblClave;
        private TextBox txtContrasena;

        private Button btnIngresar;
        private Button btnSalir;
        private ComboBox comboBox1;
        private Label label1;
        private PictureBox picLogo;
        private Button ojo;
    }
}