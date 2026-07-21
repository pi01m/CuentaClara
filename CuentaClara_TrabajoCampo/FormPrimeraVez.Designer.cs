namespace IU
{
    partial class FormPrimeraVez
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
            btnBuscar = new Button();
            listaServidores = new ListBox();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBuscar.BackColor = Color.White;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.FromArgb(18, 87, 150);
            btnBuscar.Location = new Point(1070, 192);
            btnBuscar.Margin = new Padding(0);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(260, 118);
            btnBuscar.TabIndex = 43;
            btnBuscar.Tag = "";
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // listaServidores
            // 
            listaServidores.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listaServidores.FormattingEnabled = true;
            listaServidores.ItemHeight = 41;
            listaServidores.Location = new Point(44, 106);
            listaServidores.Margin = new Padding(0);
            listaServidores.Name = "listaServidores";
            listaServidores.Size = new Size(862, 865);
            listaServidores.TabIndex = 42;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGuardar.BackColor = Color.FromArgb(18, 87, 150);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(1070, 376);
            btnGuardar.Margin = new Padding(0);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(260, 118);
            btnGuardar.TabIndex = 41;
            btnGuardar.Tag = "";
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FormPrimeraVez
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1745, 1088);
            Controls.Add(btnBuscar);
            Controls.Add(listaServidores);
            Controls.Add(btnGuardar);
            Name = "FormPrimeraVez";
            Text = "FormPrimeraVez";
            Load += FormPrimeraVez_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnBuscar;
        private ListBox listaServidores;
        private Button btnGuardar;
    }
}