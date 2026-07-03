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
            btn_RecalcularDv = new Button();
            SuspendLayout();
            // 
            // btnAplicar
            // 
            btnAplicar.BackColor = Color.FromArgb(18, 87, 150);
            btnAplicar.FlatAppearance.BorderSize = 0;
            btnAplicar.FlatStyle = FlatStyle.Flat;
            btnAplicar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAplicar.ForeColor = Color.White;
            btnAplicar.Location = new Point(97, 618);
            btnAplicar.Margin = new Padding(7, 8, 7, 8);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(340, 115);
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
            button1.Location = new Point(602, 618);
            button1.Margin = new Padding(7, 8, 7, 8);
            button1.Name = "button1";
            button1.Size = new Size(340, 115);
            button1.TabIndex = 8;
            button1.Tag = "btn_Aplicar";
            button1.Text = "BackUp\r\n";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(97, 265);
            textBox1.Margin = new Padding(7, 8, 7, 8);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(839, 47);
            textBox1.TabIndex = 9;
            // 
            // progresoBackup
            // 
            progresoBackup.Location = new Point(97, 383);
            progresoBackup.Margin = new Padding(7, 8, 7, 8);
            progresoBackup.Name = "progresoBackup";
            progresoBackup.Size = new Size(845, 63);
            progresoBackup.TabIndex = 10;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.BackColor = Color.White;
            btnSeleccionar.FlatStyle = FlatStyle.Flat;
            btnSeleccionar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSeleccionar.ForeColor = Color.FromArgb(18, 87, 150);
            btnSeleccionar.Location = new Point(97, 795);
            btnSeleccionar.Margin = new Padding(7, 8, 7, 8);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(340, 115);
            btnSeleccionar.TabIndex = 11;
            btnSeleccionar.Tag = "btn_Cancelar";
            btnSeleccionar.Text = "Seleccionar\r\n";
            btnSeleccionar.UseVisualStyleBackColor = false;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // btn_RecalcularDv
            // 
            btn_RecalcularDv.BackColor = Color.FromArgb(18, 87, 150);
            btn_RecalcularDv.FlatAppearance.BorderSize = 0;
            btn_RecalcularDv.FlatStyle = FlatStyle.Flat;
            btn_RecalcularDv.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_RecalcularDv.ForeColor = Color.White;
            btn_RecalcularDv.Location = new Point(602, 795);
            btn_RecalcularDv.Margin = new Padding(7, 8, 7, 8);
            btn_RecalcularDv.Name = "btn_RecalcularDv";
            btn_RecalcularDv.Size = new Size(340, 115);
            btn_RecalcularDv.TabIndex = 12;
            btn_RecalcularDv.Tag = "btn_Aplicar";
            btn_RecalcularDv.Text = "Recalcular Dígitos Verificadores";
            btn_RecalcularDv.UseVisualStyleBackColor = false;
            btn_RecalcularDv.Click += btn_RecalcularDv_Click;
            // 
            // FormGestionRespaldo
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 995);
            Controls.Add(btn_RecalcularDv);
            Controls.Add(btnSeleccionar);
            Controls.Add(progresoBackup);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(btnAplicar);
            Margin = new Padding(7, 8, 7, 8);
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
        private Button btn_RecalcularDv;
    }
}