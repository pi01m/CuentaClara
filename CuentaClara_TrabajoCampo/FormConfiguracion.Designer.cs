namespace IU
{
    partial class FormConfiguracion
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
            button1 = new Button();
            btnGuardarr = new Button();
            cmbIdioma = new ComboBox();
            picLogo = new PictureBox();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelLogin.BackColor = Color.White;
            panelLogin.BorderStyle = BorderStyle.FixedSingle;
            panelLogin.Controls.Add(button1);
            panelLogin.Controls.Add(btnGuardarr);
            panelLogin.Controls.Add(cmbIdioma);
            panelLogin.Controls.Add(picLogo);
            panelLogin.Dock = DockStyle.Fill;
            panelLogin.Location = new Point(0, 0);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(877, 504);
            panelLogin.TabIndex = 1;
            panelLogin.Paint += panelLogin_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.FromArgb(18, 87, 150);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(18, 87, 150);
            button1.Location = new Point(686, 422);
            button1.Name = "button1";
            button1.Size = new Size(163, 69);
            button1.TabIndex = 10;
            button1.Tag = "btn_Salir";
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnGuardarr
            // 
            btnGuardarr.BackColor = Color.White;
            btnGuardarr.FlatAppearance.BorderColor = Color.FromArgb(18, 87, 150);
            btnGuardarr.FlatStyle = FlatStyle.Flat;
            btnGuardarr.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardarr.ForeColor = Color.FromArgb(18, 87, 150);
            btnGuardarr.Location = new Point(446, 217);
            btnGuardarr.Name = "btnGuardarr";
            btnGuardarr.Size = new Size(344, 109);
            btnGuardarr.TabIndex = 9;
            btnGuardarr.Tag = "btn_Guardar";
            btnGuardarr.Text = "Guardar";
            btnGuardarr.UseVisualStyleBackColor = false;
            btnGuardarr.Click += btnGuardarr_Click;
            // 
            // cmbIdioma
            // 
            cmbIdioma.FormattingEnabled = true;
            cmbIdioma.Location = new Point(85, 237);
            cmbIdioma.Name = "cmbIdioma";
            cmbIdioma.Size = new Size(288, 49);
            cmbIdioma.TabIndex = 8;
            cmbIdioma.SelectedIndexChanged += cmbIdioma_SelectedIndexChanged;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.White;
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Location = new Point(32, 16);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(58, 46);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // FormConfiguracion
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 504);
            Controls.Add(panelLogin);
            Name = "FormConfiguracion";
            Text = "FormConfiguracion";
            FormClosed += FormConfiguracion_FormClosed;
            Load += FormConfiguracion_Load;
            panelLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogin;
        private ComboBox cmbIdioma;
        private PictureBox picLogo;
        private Button btnGuardarr;
        private Button button1;
    }
}