namespace CuentaClara_TrabajoCampo
{
    partial class frmLogOut
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
            btnIngresar = new Button();
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
            panelLogin.Controls.Add(btnIngresar);
            panelLogin.Location = new Point(64, 33);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(440, 340);
            panelLogin.TabIndex = 1;
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
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(18, 87, 150);
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(104, 169);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(234, 64);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Log-Out";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // frmLogOut
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 402);
            Controls.Add(panelLogin);
            Name = "frmLogOut";
            Text = "frmLogOut";
            Load += frmLogOut_Load;
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogin;
        private PictureBox picLogo;
        private Label lblTitulo;
        private Button btnIngresar;
    }
}