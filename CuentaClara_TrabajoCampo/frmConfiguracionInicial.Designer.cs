namespace IU
{
    partial class frmConfiguracionInicial
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
            btnInstalar = new Button();
            txtServidor = new TextBox();
            lblNombre = new Label();
            label1 = new Label();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // btnInstalar
            // 
            btnInstalar.BackColor = Color.White;
            btnInstalar.FlatStyle = FlatStyle.Flat;
            btnInstalar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnInstalar.ForeColor = Color.FromArgb(18, 87, 150);
            btnInstalar.Location = new Point(78, 191);
            btnInstalar.Name = "btnInstalar";
            btnInstalar.Size = new Size(234, 43);
            btnInstalar.TabIndex = 20;
            btnInstalar.Tag = "btn_Limpiar";
            btnInstalar.Text = "Instalar";
            btnInstalar.UseVisualStyleBackColor = false;
            btnInstalar.Click += btnInstalar_Click_1;
            // 
            // txtServidor
            // 
            txtServidor.BorderStyle = BorderStyle.FixedSingle;
            txtServidor.Location = new Point(78, 147);
            txtServidor.Name = "txtServidor";
            txtServidor.Size = new Size(234, 23);
            txtServidor.TabIndex = 21;
            txtServidor.TextChanged += txtServidor_TextChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombre.Location = new Point(12, 65);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(102, 19);
            lblNombre.TabIndex = 22;
            lblNombre.Tag = "lbl_Nombre";
            lblNombre.Text = "Bienvenida/o ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(12, 94);
            label1.Name = "label1";
            label1.Size = new Size(371, 38);
            label1.TabIndex = 23;
            label1.Tag = "lbl_Nombre";
            label1.Text = "Para comenzar, necesitamos preparar tu entorno. \r\nPor favor, ingresa el nombre de tu servidor SQL local.";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(20, 70, 120);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Margin = new Padding(1, 0, 1, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(152, 32);
            lblTitulo.TabIndex = 25;
            lblTitulo.Text = "CuentaClara";
            // 
            // frmConfiguracionInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(392, 256);
            Controls.Add(lblTitulo);
            Controls.Add(label1);
            Controls.Add(lblNombre);
            Controls.Add(txtServidor);
            Controls.Add(btnInstalar);
            MaximizeBox = false;
            Name = "frmConfiguracionInicial";
            Text = "CuentaClara";
            Load += frmConfiguracionInicial_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInstalar;
        private TextBox txtServidor;
        private Label lblNombre;
        private Label label1;
        private Label lblTitulo;
    }
}