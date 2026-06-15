namespace IU
{
    partial class FormGestionIdioma
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            lblSeccionIdioma = new Label();
            cboIdiomas = new ComboBox();
            dgvEtiquetas = new DataGridView();
            lblClave = new Label();
            txtClave = new TextBox();
            lblTexto = new Label();
            txtTexto = new TextBox();
            panelInferior = new Panel();
            lblUsuarioLogueado = new Label();
            btnNuevoIdioma = new Button();
            btnAgregarEtiqueta = new Button();
            btnModificarEtiqueta = new Button();
            btnSalir = new Button();
            btnAplicar = new Button();
            listBox1 = new ListBox();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEtiquetas).BeginInit();
            panelInferior.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(12, 74, 144);
            lblTitulo.Location = new Point(100, 79);
            lblTitulo.Margin = new Padding(7, 0, 7, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(710, 99);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Idiomas";
            // 
            // lblSeccionIdioma
            // 
            lblSeccionIdioma.AutoSize = true;
            lblSeccionIdioma.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSeccionIdioma.ForeColor = Color.FromArgb(12, 74, 144);
            lblSeccionIdioma.Location = new Point(107, 284);
            lblSeccionIdioma.Margin = new Padding(7, 0, 7, 0);
            lblSeccionIdioma.Name = "lblSeccionIdioma";
            lblSeccionIdioma.Size = new Size(390, 50);
            lblSeccionIdioma.TabIndex = 1;
            lblSeccionIdioma.Text = "Seleccione el Idioma:";
            // 
            // cboIdiomas
            // 
            cboIdiomas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboIdiomas.Font = new Font("Segoe UI", 11F);
            cboIdiomas.FormattingEnabled = true;
            cboIdiomas.Location = new Point(580, 273);
            cboIdiomas.Margin = new Padding(7, 8, 7, 8);
            cboIdiomas.Name = "cboIdiomas";
            cboIdiomas.Size = new Size(616, 58);
            cboIdiomas.TabIndex = 2;
            cboIdiomas.SelectedIndexChanged += cboIdiomas_SelectedIndexChanged;
            // 
            // dgvEtiquetas
            // 
            dgvEtiquetas.AllowUserToAddRows = false;
            dgvEtiquetas.AllowUserToDeleteRows = false;
            dgvEtiquetas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEtiquetas.BackgroundColor = Color.FromArgb(12, 74, 144);
            dgvEtiquetas.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(12, 74, 144);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEtiquetas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEtiquetas.ColumnHeadersHeight = 30;
            dgvEtiquetas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(220, 230, 242);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvEtiquetas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEtiquetas.EnableHeadersVisualStyles = false;
            dgvEtiquetas.Location = new Point(109, 441);
            dgvEtiquetas.Margin = new Padding(7, 8, 7, 8);
            dgvEtiquetas.MultiSelect = false;
            dgvEtiquetas.Name = "dgvEtiquetas";
            dgvEtiquetas.ReadOnly = true;
            dgvEtiquetas.RowHeadersVisible = false;
            dgvEtiquetas.RowHeadersWidth = 102;
            dgvEtiquetas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEtiquetas.Size = new Size(2125, 883);
            dgvEtiquetas.TabIndex = 3;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblClave.Location = new Point(100, 1402);
            lblClave.Margin = new Padding(7, 0, 7, 0);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(114, 46);
            lblClave.TabIndex = 4;
            lblClave.Text = "Clave:";
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Segoe UI", 10F);
            txtClave.Location = new Point(109, 1473);
            txtClave.Margin = new Padding(7, 8, 7, 8);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(842, 52);
            txtClave.TabIndex = 5;
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTexto.Location = new Point(100, 1607);
            lblTexto.Margin = new Padding(7, 0, 7, 0);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(117, 46);
            lblTexto.TabIndex = 6;
            lblTexto.Text = "Texto:";
            // 
            // txtTexto
            // 
            txtTexto.Font = new Font("Segoe UI", 10F);
            txtTexto.Location = new Point(109, 1678);
            txtTexto.Margin = new Padding(7, 8, 7, 8);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(842, 52);
            txtTexto.TabIndex = 7;
            // 
            // panelInferior
            // 
            panelInferior.BackColor = Color.FromArgb(12, 74, 144);
            panelInferior.Controls.Add(lblUsuarioLogueado);
            panelInferior.Dock = DockStyle.Bottom;
            panelInferior.Location = new Point(0, 1924);
            panelInferior.Margin = new Padding(7, 8, 7, 8);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(2820, 126);
            panelInferior.TabIndex = 13;
            // 
            // lblUsuarioLogueado
            // 
            lblUsuarioLogueado.AutoSize = true;
            lblUsuarioLogueado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsuarioLogueado.ForeColor = Color.White;
            lblUsuarioLogueado.Location = new Point(41, 33);
            lblUsuarioLogueado.Margin = new Padding(7, 0, 7, 0);
            lblUsuarioLogueado.Name = "lblUsuarioLogueado";
            lblUsuarioLogueado.Size = new Size(500, 46);
            lblUsuarioLogueado.TabIndex = 0;
            lblUsuarioLogueado.Text = "Usuario activo: Administrador";
            // 
            // btnNuevoIdioma
            // 
            btnNuevoIdioma.BackColor = Color.FromArgb(12, 74, 144);
            btnNuevoIdioma.FlatStyle = FlatStyle.Flat;
            btnNuevoIdioma.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNuevoIdioma.ForeColor = Color.White;
            btnNuevoIdioma.Location = new Point(2295, 426);
            btnNuevoIdioma.Margin = new Padding(7, 8, 7, 8);
            btnNuevoIdioma.Name = "btnNuevoIdioma";
            btnNuevoIdioma.Size = new Size(396, 142);
            btnNuevoIdioma.TabIndex = 8;
            btnNuevoIdioma.Text = "Nuevo Idioma";
            btnNuevoIdioma.UseVisualStyleBackColor = false;
            btnNuevoIdioma.Click += btnNuevoIdioma_Click;
            // 
            // btnAgregarEtiqueta
            // 
            btnAgregarEtiqueta.BackColor = Color.White;
            btnAgregarEtiqueta.FlatStyle = FlatStyle.Flat;
            btnAgregarEtiqueta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAgregarEtiqueta.ForeColor = Color.FromArgb(12, 74, 144);
            btnAgregarEtiqueta.Location = new Point(2295, 631);
            btnAgregarEtiqueta.Margin = new Padding(7, 8, 7, 8);
            btnAgregarEtiqueta.Name = "btnAgregarEtiqueta";
            btnAgregarEtiqueta.Size = new Size(396, 142);
            btnAgregarEtiqueta.TabIndex = 9;
            btnAgregarEtiqueta.Text = "Agregar Etiqueta";
            btnAgregarEtiqueta.UseVisualStyleBackColor = false;
            btnAgregarEtiqueta.Click += btnAgregarEtiqueta_Click;
            // 
            // btnModificarEtiqueta
            // 
            btnModificarEtiqueta.BackColor = Color.White;
            btnModificarEtiqueta.FlatStyle = FlatStyle.Flat;
            btnModificarEtiqueta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnModificarEtiqueta.ForeColor = Color.FromArgb(12, 74, 144);
            btnModificarEtiqueta.Location = new Point(2295, 836);
            btnModificarEtiqueta.Margin = new Padding(7, 8, 7, 8);
            btnModificarEtiqueta.Name = "btnModificarEtiqueta";
            btnModificarEtiqueta.Size = new Size(396, 142);
            btnModificarEtiqueta.TabIndex = 10;
            btnModificarEtiqueta.Text = "Modificar Etiqueta";
            btnModificarEtiqueta.UseVisualStyleBackColor = false;
            btnModificarEtiqueta.Click += btnModificarEtiqueta_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.White;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(12, 74, 144);
            btnSalir.Location = new Point(2365, 1643);
            btnSalir.Margin = new Padding(7, 8, 7, 8);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(311, 120);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnAplicar
            // 
            btnAplicar.BackColor = Color.White;
            btnAplicar.FlatStyle = FlatStyle.Flat;
            btnAplicar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAplicar.ForeColor = Color.FromArgb(12, 74, 144);
            btnAplicar.Location = new Point(1219, 1640);
            btnAplicar.Margin = new Padding(7, 8, 7, 8);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(311, 120);
            btnAplicar.TabIndex = 11;
            btnAplicar.Text = "Aplicar";
            btnAplicar.UseVisualStyleBackColor = false;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 41;
            listBox1.Location = new Point(1202, 1380);
            listBox1.Margin = new Padding(2, 3, 2, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1031, 209);
            listBox1.TabIndex = 14;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(12, 74, 144);
            btnCancelar.Location = new Point(1566, 1640);
            btnCancelar.Margin = new Padding(7, 8, 7, 8);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(311, 120);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // FormGestionIdioma
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(2820, 2050);
            Controls.Add(btnCancelar);
            Controls.Add(listBox1);
            Controls.Add(panelInferior);
            Controls.Add(btnSalir);
            Controls.Add(btnAplicar);
            Controls.Add(btnModificarEtiqueta);
            Controls.Add(btnAgregarEtiqueta);
            Controls.Add(btnNuevoIdioma);
            Controls.Add(txtTexto);
            Controls.Add(lblTexto);
            Controls.Add(txtClave);
            Controls.Add(lblClave);
            Controls.Add(dgvEtiquetas);
            Controls.Add(cboIdiomas);
            Controls.Add(lblSeccionIdioma);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(7, 8, 7, 8);
            MaximizeBox = false;
            Name = "FormGestionIdioma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CuentaClara - Gestión de Idioma";
            Load += FormGestionIdioma_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEtiquetas).EndInit();
            panelInferior.ResumeLayout(false);
            panelInferior.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSeccionIdioma;
        private System.Windows.Forms.ComboBox cboIdiomas;
        private System.Windows.Forms.DataGridView dgvEtiquetas;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button btnNuevoIdioma;
        private System.Windows.Forms.Button btnAgregarEtiqueta;
        private System.Windows.Forms.Button btnModificarEtiqueta;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Label lblUsuarioLogueado;
        private ListBox listBox1;
        private Button btnCancelar;
    }
}