namespace CuentaClara_TrabajoCampo
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelMenu = new Panel();
            picLogo = new PictureBox();
            lblTitulo = new Label();
            btnInicio = new Button();
            btnTransacciones = new Button();
            btnCategorias = new Button();
            btnVencimientos = new Button();
            btnSaldos = new Button();
            btnGraficos = new Button();
            panelUsuario = new Panel();
            lblUsuario = new Label();
            lblBD = new Label();
            panelMovimientos = new Panel();
            lblHistorial = new Label();
            dgvMovimientos = new DataGridView();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            btnNuevoIngreso = new Button();
            btnNuevoEgreso = new Button();
            lblEstadoSaldos = new Label();
            lblSaldoGeneral = new Label();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panelUsuario.SuspendLayout();
            panelMovimientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.White;
            panelMenu.Controls.Add(picLogo);
            panelMenu.Controls.Add(lblTitulo);
            panelMenu.Controls.Add(btnInicio);
            panelMenu.Controls.Add(btnTransacciones);
            panelMenu.Controls.Add(btnCategorias);
            panelMenu.Controls.Add(btnVencimientos);
            panelMenu.Controls.Add(btnSaldos);
            panelMenu.Controls.Add(btnGraficos);
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(300, 1001);
            panelMenu.TabIndex = 2;
            // 
            // picLogo
            // 
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Location = new Point(20, 47);
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
            lblTitulo.Location = new Point(112, 66);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(173, 37);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "CuentaClara";
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.White;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnInicio.Location = new Point(20, 180);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(260, 50);
            btnInicio.TabIndex = 2;
            btnInicio.Text = "INICIO";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.UseVisualStyleBackColor = false;
            // 
            // btnTransacciones
            // 
            btnTransacciones.BackColor = Color.White;
            btnTransacciones.FlatAppearance.BorderSize = 0;
            btnTransacciones.FlatStyle = FlatStyle.Flat;
            btnTransacciones.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTransacciones.Location = new Point(20, 240);
            btnTransacciones.Name = "btnTransacciones";
            btnTransacciones.Size = new Size(260, 50);
            btnTransacciones.TabIndex = 3;
            btnTransacciones.Text = "TRANSACCIONES";
            btnTransacciones.TextAlign = ContentAlignment.MiddleLeft;
            btnTransacciones.UseVisualStyleBackColor = false;
            // 
            // btnCategorias
            // 
            btnCategorias.BackColor = Color.White;
            btnCategorias.FlatAppearance.BorderSize = 0;
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCategorias.Location = new Point(20, 300);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(260, 50);
            btnCategorias.TabIndex = 4;
            btnCategorias.Text = "CATEGORÍAS";
            btnCategorias.TextAlign = ContentAlignment.MiddleLeft;
            btnCategorias.UseVisualStyleBackColor = false;
            // 
            // btnVencimientos
            // 
            btnVencimientos.BackColor = Color.White;
            btnVencimientos.FlatAppearance.BorderSize = 0;
            btnVencimientos.FlatStyle = FlatStyle.Flat;
            btnVencimientos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnVencimientos.Location = new Point(20, 360);
            btnVencimientos.Name = "btnVencimientos";
            btnVencimientos.Size = new Size(260, 50);
            btnVencimientos.TabIndex = 5;
            btnVencimientos.Text = "VENCIMIENTOS";
            btnVencimientos.TextAlign = ContentAlignment.MiddleLeft;
            btnVencimientos.UseVisualStyleBackColor = false;
            // 
            // btnSaldos
            // 
            btnSaldos.BackColor = Color.White;
            btnSaldos.FlatAppearance.BorderSize = 0;
            btnSaldos.FlatStyle = FlatStyle.Flat;
            btnSaldos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSaldos.Location = new Point(20, 420);
            btnSaldos.Name = "btnSaldos";
            btnSaldos.Size = new Size(260, 50);
            btnSaldos.TabIndex = 6;
            btnSaldos.Text = "SALDOS CRUZADOS";
            btnSaldos.TextAlign = ContentAlignment.MiddleLeft;
            btnSaldos.UseVisualStyleBackColor = false;
            // 
            // btnGraficos
            // 
            btnGraficos.BackColor = Color.White;
            btnGraficos.FlatAppearance.BorderSize = 0;
            btnGraficos.FlatStyle = FlatStyle.Flat;
            btnGraficos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGraficos.Location = new Point(20, 480);
            btnGraficos.Name = "btnGraficos";
            btnGraficos.Size = new Size(260, 50);
            btnGraficos.TabIndex = 7;
            btnGraficos.Text = "GRÁFICOS";
            btnGraficos.TextAlign = ContentAlignment.MiddleLeft;
            btnGraficos.UseVisualStyleBackColor = false;
            // 
            // panelUsuario
            // 
            panelUsuario.BackColor = Color.FromArgb(18, 87, 150);
            panelUsuario.Controls.Add(lblUsuario);
            panelUsuario.Controls.Add(lblBD);
            panelUsuario.Dock = DockStyle.Bottom;
            panelUsuario.Location = new Point(0, 1001);
            panelUsuario.Name = "panelUsuario";
            panelUsuario.Size = new Size(1841, 60);
            panelUsuario.TabIndex = 3;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 11F);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(20, 20);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(323, 20);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario Activo: Devora (Rol: Usuario Operativo)";
            // 
            // lblBD
            // 
            lblBD.Location = new Point(0, 0);
            lblBD.Name = "lblBD";
            lblBD.Size = new Size(100, 23);
            lblBD.TabIndex = 1;
            // 
            // panelMovimientos
            // 
            panelMovimientos.BackColor = Color.White;
            panelMovimientos.Controls.Add(lblHistorial);
            panelMovimientos.Controls.Add(dgvMovimientos);
            panelMovimientos.Controls.Add(btnNuevoIngreso);
            panelMovimientos.Controls.Add(btnNuevoEgreso);
            panelMovimientos.Controls.Add(lblEstadoSaldos);
            panelMovimientos.Location = new Point(340, 120);
            panelMovimientos.Name = "panelMovimientos";
            panelMovimientos.Size = new Size(1401, 881);
            panelMovimientos.TabIndex = 0;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHistorial.Location = new Point(25, 20);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(368, 30);
            lblHistorial.TabIndex = 0;
            lblHistorial.Text = "Historial Reciente de Movimientos";
            // 
            // dgvMovimientos
            // 
            dgvMovimientos.AllowUserToAddRows = false;
            dgvMovimientos.AllowUserToDeleteRows = false;
            dgvMovimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMovimientos.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMovimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMovimientos.ColumnHeadersHeight = 30;
            dgvMovimientos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMovimientos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMovimientos.Location = new Point(78, 120);
            dgvMovimientos.Name = "dgvMovimientos";
            dgvMovimientos.ReadOnly = true;
            dgvMovimientos.RowHeadersVisible = false;
            dgvMovimientos.RowHeadersWidth = 102;
            dgvMovimientos.Size = new Size(951, 498);
            dgvMovimientos.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Concepto";
            dataGridViewTextBoxColumn4.MinimumWidth = 12;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Descripción";
            dataGridViewTextBoxColumn5.MinimumWidth = 12;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Valor";
            dataGridViewTextBoxColumn6.MinimumWidth = 12;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // btnNuevoIngreso
            // 
            btnNuevoIngreso.FlatStyle = FlatStyle.Flat;
            btnNuevoIngreso.Font = new Font("Segoe UI", 11F);
            btnNuevoIngreso.Location = new Point(1119, 191);
            btnNuevoIngreso.Name = "btnNuevoIngreso";
            btnNuevoIngreso.Size = new Size(240, 60);
            btnNuevoIngreso.TabIndex = 2;
            btnNuevoIngreso.Text = "Registrar Nuevo Ingreso +";
            // 
            // btnNuevoEgreso
            // 
            btnNuevoEgreso.FlatStyle = FlatStyle.Flat;
            btnNuevoEgreso.Font = new Font("Segoe UI", 11F);
            btnNuevoEgreso.Location = new Point(1119, 323);
            btnNuevoEgreso.Name = "btnNuevoEgreso";
            btnNuevoEgreso.Size = new Size(240, 60);
            btnNuevoEgreso.TabIndex = 3;
            btnNuevoEgreso.Text = "Registrar Nuevo Egreso -";
            // 
            // lblEstadoSaldos
            // 
            lblEstadoSaldos.AutoSize = true;
            lblEstadoSaldos.Font = new Font("Segoe UI", 11F);
            lblEstadoSaldos.Location = new Point(42, 808);
            lblEstadoSaldos.Name = "lblEstadoSaldos";
            lblEstadoSaldos.Size = new Size(343, 20);
            lblEstadoSaldos.TabIndex = 4;
            lblEstadoSaldos.Text = "Saldos Conciliados: Hogar en Equilibrio y Armonía";
            // 
            // lblSaldoGeneral
            // 
            lblSaldoGeneral.AutoSize = true;
            lblSaldoGeneral.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblSaldoGeneral.ForeColor = Color.FromArgb(15, 45, 75);
            lblSaldoGeneral.Location = new Point(340, 35);
            lblSaldoGeneral.Name = "lblSaldoGeneral";
            lblSaldoGeneral.Size = new Size(736, 32);
            lblSaldoGeneral.TabIndex = 1;
            lblSaldoGeneral.Text = "Saldo Líquido General del Hogar: $732.500,75 [Estado: Estable]";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Concepto";
            dataGridViewTextBoxColumn1.MinimumWidth = 12;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Descripción";
            dataGridViewTextBoxColumn2.MinimumWidth = 12;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Valor";
            dataGridViewTextBoxColumn3.MinimumWidth = 12;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 250;
            // 
            // FormMenu
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(1841, 1061);
            Controls.Add(panelMovimientos);
            Controls.Add(lblSaldoGeneral);
            Controls.Add(panelMenu);
            Controls.Add(panelUsuario);
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CuentaClara - Gestión Financiera Familiar";
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panelUsuario.ResumeLayout(false);
            panelUsuario.PerformLayout();
            panelMovimientos.ResumeLayout(false);
            panelMovimientos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelMenu;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;

        private PictureBox picLogo;
        private Label lblTitulo;

        private Button btnInicio;
        private Button btnTransacciones;
        private Button btnCategorias;
        private Button btnVencimientos;
        private Button btnSaldos;
        private Button btnGraficos;

        private Panel panelUsuario;
        private Label lblUsuario;
        private Label lblBD;

        private Panel panelMovimientos;
        private Label lblHistorial;

        private DataGridView dgvMovimientos;

        private Button btnNuevoIngreso;
        private Button btnNuevoEgreso;

        private Label lblEstadoSaldos;
        private Label lblSaldoGeneral;
    }
}
