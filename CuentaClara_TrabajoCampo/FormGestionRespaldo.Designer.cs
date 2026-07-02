namespace IU
{
    partial class FormGestionRespaldo
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
            btnAplicar = new Button();
            button1 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            textBox1 = new TextBox();
            progresoBackup = new ProgressBar();
            btnSeleccionar = new Button();
            SuspendLayout();
            // 
            // btnAplicar
            // 
            btnAplicar.BackColor = Color.FromArgb(18, 87, 150);
            btnAplicar.FlatAppearance.BorderSize = 0;
            btnAplicar.FlatStyle = FlatStyle.Flat;
            btnAplicar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAplicar.ForeColor = Color.White;
            btnAplicar.Location = new Point(40, 226);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(140, 42);
            btnAplicar.TabIndex = 7;
            btnAplicar.Tag = "btn_Aplicar";
            btnAplicar.Text = "Restaurar\r\n";
            btnAplicar.UseVisualStyleBackColor = false;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(18, 87, 150);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(248, 226);
            button1.Name = "button1";
            button1.Size = new Size(140, 42);
            button1.TabIndex = 8;
            button1.Tag = "btn_Aplicar";
            button1.Text = "BackUp\r\n";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(348, 23);
            textBox1.TabIndex = 9;
            // 
            // progresoBackup
            // 
            progresoBackup.Location = new Point(40, 140);
            progresoBackup.Name = "progresoBackup";
            progresoBackup.Size = new Size(348, 23);
            progresoBackup.TabIndex = 10;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.BackColor = Color.White;
            btnSeleccionar.FlatStyle = FlatStyle.Flat;
            btnSeleccionar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSeleccionar.ForeColor = Color.FromArgb(18, 87, 150);
            btnSeleccionar.Location = new Point(40, 291);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(140, 42);
            btnSeleccionar.TabIndex = 11;
            btnSeleccionar.Tag = "btn_Cancelar";
            btnSeleccionar.Text = "Seleccionar\r\n";
            btnSeleccionar.UseVisualStyleBackColor = false;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // FormGestionRespaldo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 364);
            Controls.Add(btnSeleccionar);
            Controls.Add(progresoBackup);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(btnAplicar);
            Name = "FormGestionRespaldo";
            Text = "FormGestionRespaldo";
            Load += FormGestionRespaldo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAplicar;
        private Button button1;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox textBox1;
        private ProgressBar progresoBackup;
        private Button btnSeleccionar;
    }
}