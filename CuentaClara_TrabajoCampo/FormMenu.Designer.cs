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
            button4 = new Button();
            button3 = new Button();
            btnCerrarSesion = new Button();
            button2 = new Button();
            button1 = new Button();
            picLogo = new PictureBox();
            lblTitulo = new Label();
            btnInicio = new Button();
            btnTransacciones = new Button();
            btnCategorias = new Button();
            btnVencimientos = new Button();
            btnSaldos = new Button();
            btnGraficos = new Button();
            panelUsuario = new Panel();
            lblUsuarioValor = new Label();
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
            panelMenu.Controls.Add(button4);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(btnCerrarSesion);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(picLogo);
            panelMenu.Controls.Add(lblTitulo);
            panelMenu.Controls.Add(btnInicio);
            panelMenu.Controls.Add(btnTransacciones);
            panelMenu.Controls.Add(btnCategorias);
            panelMenu.Controls.Add(btnVencimientos);
            panelMenu.Controls.Add(btnSaldos);
            panelMenu.Controls.Add(btnGraficos);
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(7, 8, 7, 8);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(568, 3572);
            panelMenu.TabIndex = 2;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.Location = new Point(49, 1809);
            button4.Margin = new Padding(7, 8, 7, 8);
            button4.Name = "button4";
            button4.Size = new Size(464, 131);
            button4.TabIndex = 12;
            button4.Tag = "btn_CambiarClave";
            button4.Text = "Cambiar Clave";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.Location = new Point(49, 2036);
            button3.Margin = new Padding(7, 8, 7, 8);
            button3.Name = "button3";
            button3.Size = new Size(464, 134);
            button3.TabIndex = 11;
            button3.Text = "Gestión Perfiles";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.White;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCerrarSesion.Location = new Point(49, 1651);
            btnCerrarSesion.Margin = new Padding(7, 8, 7, 8);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(464, 142);
            btnCerrarSesion.TabIndex = 10;
            btnCerrarSesion.Tag = "btn_CerrarSesion";
            btnCerrarSesion.Text = "CERRAR SESIÓN";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(49, 2337);
            button2.Margin = new Padding(7, 8, 7, 8);
            button2.Name = "button2";
            button2.Size = new Size(464, 107);
            button2.TabIndex = 9;
            button2.Text = "Gestión de Bitácora";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(49, 2187);
            button1.Margin = new Padding(7, 8, 7, 8);
            button1.Name = "button1";
            button1.Size = new Size(464, 134);
            button1.TabIndex = 8;
            button1.Text = "Gestión de Usuarios";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // picLogo
            // 
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Location = new Point(49, 128);
            picLogo.Margin = new Padding(7, 8, 7, 8);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(206, 215);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(20, 70, 120);
            lblTitulo.Location = new Point(29, 476);
            lblTitulo.Margin = new Padding(7, 0, 7, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(420, 89);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "CuentaClara";
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.White;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnInicio.Location = new Point(49, 724);
            btnInicio.Margin = new Padding(7, 8, 7, 8);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(401, 137);
            btnInicio.TabIndex = 2;
            btnInicio.Tag = "btn_Inicio";
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
            btnTransacciones.Location = new Point(49, 877);
            btnTransacciones.Margin = new Padding(7, 8, 7, 8);
            btnTransacciones.Name = "btnTransacciones";
            btnTransacciones.Size = new Size(464, 137);
            btnTransacciones.TabIndex = 3;
            btnTransacciones.Tag = "btn_Transacciones";
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
            btnCategorias.Location = new Point(49, 1000);
            btnCategorias.Margin = new Padding(7, 8, 7, 8);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(401, 137);
            btnCategorias.TabIndex = 4;
            btnCategorias.Tag = "btn_Categorias";
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
            btnVencimientos.Location = new Point(49, 1153);
            btnVencimientos.Margin = new Padding(7, 8, 7, 8);
            btnVencimientos.Name = "btnVencimientos";
            btnVencimientos.Size = new Size(401, 137);
            btnVencimientos.TabIndex = 5;
            btnVencimientos.Tag = "btn_Vencimientos";
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
            btnSaldos.Location = new Point(49, 1307);
            btnSaldos.Margin = new Padding(7, 8, 7, 8);
            btnSaldos.Name = "btnSaldos";
            btnSaldos.Size = new Size(464, 137);
            btnSaldos.TabIndex = 6;
            btnSaldos.Tag = "btn_SaldosCruzados";
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
            btnGraficos.Location = new Point(49, 1460);
            btnGraficos.Margin = new Padding(7, 8, 7, 8);
            btnGraficos.Name = "btnGraficos";
            btnGraficos.Size = new Size(464, 167);
            btnGraficos.TabIndex = 7;
            btnGraficos.Tag = "btn_Graficos";
            btnGraficos.Text = "GRÁFICOS";
            btnGraficos.TextAlign = ContentAlignment.MiddleLeft;
            btnGraficos.UseVisualStyleBackColor = false;
            // 
            // panelUsuario
            // 
            panelUsuario.BackColor = Color.FromArgb(18, 87, 150);
            panelUsuario.Controls.Add(lblUsuarioValor);
            panelUsuario.Controls.Add(lblUsuario);
            panelUsuario.Controls.Add(lblBD);
            panelUsuario.Dock = DockStyle.Bottom;
            panelUsuario.Location = new Point(0, 1928);
            panelUsuario.Margin = new Padding(7, 8, 7, 8);
            panelUsuario.Name = "panelUsuario";
            panelUsuario.Size = new Size(3164, 180);
            panelUsuario.TabIndex = 3;
            // 
            // lblUsuarioValor
            // 
            lblUsuarioValor.AutoSize = true;
            lblUsuarioValor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUsuarioValor.ForeColor = Color.White;
            lblUsuarioValor.Location = new Point(364, 55);
            lblUsuarioValor.Margin = new Padding(7, 0, 7, 0);
            lblUsuarioValor.Name = "lblUsuarioValor";
            lblUsuarioValor.Size = new Size(625, 54);
            lblUsuarioValor.TabIndex = 2;
            lblUsuarioValor.Tag = "";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(49, 55);
            lblUsuario.Margin = new Padding(7, 0, 7, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(922, 54);
            lblUsuario.TabIndex = 0;
            // 
            // lblBD
            // 
            lblBD.Location = new Point(0, 0);
            lblBD.Margin = new Padding(7, 0, 7, 0);
            lblBD.Name = "lblBD";
            lblBD.Size = new Size(243, 63);
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
            panelMovimientos.Location = new Point(670, 339);
            panelMovimientos.Margin = new Padding(7, 8, 7, 8);
            panelMovimientos.Name = "panelMovimientos";
            panelMovimientos.Size = new Size(2390, 2345);
            panelMovimientos.TabIndex = 0;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHistorial.Location = new Point(61, 55);
            lblHistorial.Margin = new Padding(7, 0, 7, 0);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(900, 72);
            lblHistorial.TabIndex = 0;
            lblHistorial.Tag = "lbl_Historial";
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
            dgvMovimientos.Location = new Point(61, 333);
            dgvMovimientos.Margin = new Padding(7, 8, 7, 8);
            dgvMovimientos.Name = "dgvMovimientos";
            dgvMovimientos.ReadOnly = true;
            dgvMovimientos.RowHeadersVisible = false;
            dgvMovimientos.RowHeadersWidth = 102;
            dgvMovimientos.Size = new Size(2055, 1184);
            dgvMovimientos.TabIndex = 1;
            dgvMovimientos.Tag = "dgv_Menu";
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
            btnNuevoIngreso.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNuevoIngreso.Location = new Point(1464, 1621);
            btnNuevoIngreso.Margin = new Padding(7, 8, 7, 8);
            btnNuevoIngreso.Name = "btnNuevoIngreso";
            btnNuevoIngreso.Size = new Size(651, 159);
            btnNuevoIngreso.TabIndex = 2;
            btnNuevoIngreso.Text = "Registrar Nuevo Ingreso +";
            // 
            // btnNuevoEgreso
            // 
            btnNuevoEgreso.FlatStyle = FlatStyle.Flat;
            btnNuevoEgreso.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNuevoEgreso.Location = new Point(61, 1621);
            btnNuevoEgreso.Margin = new Padding(7, 8, 7, 8);
            btnNuevoEgreso.Name = "btnNuevoEgreso";
            btnNuevoEgreso.Size = new Size(651, 159);
            btnNuevoEgreso.TabIndex = 3;
            btnNuevoEgreso.Text = "Registrar Nuevo Egreso -";
            // 
            // lblEstadoSaldos
            // 
            lblEstadoSaldos.AutoSize = true;
            lblEstadoSaldos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEstadoSaldos.Location = new Point(61, 2020);
            lblEstadoSaldos.Margin = new Padding(7, 0, 7, 0);
            lblEstadoSaldos.Name = "lblEstadoSaldos";
            lblEstadoSaldos.Size = new Size(963, 54);
            lblEstadoSaldos.TabIndex = 4;
            lblEstadoSaldos.Text = "Saldos Conciliados: Hogar en Equilibrio y Armonía";
            // 
            // lblSaldoGeneral
            // 
            lblSaldoGeneral.AutoSize = true;
            lblSaldoGeneral.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblSaldoGeneral.ForeColor = Color.FromArgb(15, 45, 75);
            lblSaldoGeneral.Location = new Point(670, 128);
            lblSaldoGeneral.Margin = new Padding(7, 0, 7, 0);
            lblSaldoGeneral.Name = "lblSaldoGeneral";
            lblSaldoGeneral.Size = new Size(985, 81);
            lblSaldoGeneral.TabIndex = 1;
            lblSaldoGeneral.Tag = "lbl_SaldoGeneral";
            lblSaldoGeneral.Text = "Saldo Líquido General del Hogar: \r\n";
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
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(3164, 2108);
            Controls.Add(panelUsuario);
            Controls.Add(panelMovimientos);
            Controls.Add(lblSaldoGeneral);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(7, 8, 7, 8);
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CuentaClara - Gestión Financiera Familiar";
            FormClosed += FormMenu_FormClosed;
            Load += FormMenu_Load;
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
        private Button button2;
        private Button button1;
        private Button btnCerrarSesion;
        private Button button3;
        private Button button4;
        private Label lblUsuarioValor;
    }
}
