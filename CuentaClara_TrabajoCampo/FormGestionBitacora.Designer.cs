namespace CuentaClara_TrabajoCampo
{
    partial class FormGestionBitacora
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelContenedor = new Panel();
            lblTitulo = new Label();
            dgvBitacora = new DataGridView();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblLogin = new Label();
            cboLogin = new ComboBox();
            lblFechaInicio = new Label();
            dtpFechaInicio = new DateTimePicker();
            lblFechaFin = new Label();
            dtpFechaFin = new DateTimePicker();
            lblModulo = new Label();
            cboModulo = new ComboBox();
            lblEvento = new Label();
            cboEvento = new ComboBox();
            lblCriticidad = new Label();
            cboCriticidad = new ComboBox();
            lstMensajes = new ListBox();
            btnLimpiar = new Button();
            btnAplicar = new Button();
            btnImprimir = new Button();
            btnSalir = new Button();
            lblCantidadEventos = new Label();
            lblTotalEventos = new Label();
            panelInferior = new Panel();
            lblUsuarioActivo = new Label();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBitacora).BeginInit();
            panelInferior.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.White;
            panelContenedor.Controls.Add(lblTitulo);
            panelContenedor.Controls.Add(dgvBitacora);
            panelContenedor.Controls.Add(lblNombre);
            panelContenedor.Controls.Add(txtNombre);
            panelContenedor.Controls.Add(lblApellido);
            panelContenedor.Controls.Add(txtApellido);
            panelContenedor.Controls.Add(lblLogin);
            panelContenedor.Controls.Add(cboLogin);
            panelContenedor.Controls.Add(lblFechaInicio);
            panelContenedor.Controls.Add(dtpFechaInicio);
            panelContenedor.Controls.Add(lblFechaFin);
            panelContenedor.Controls.Add(dtpFechaFin);
            panelContenedor.Controls.Add(lblModulo);
            panelContenedor.Controls.Add(cboModulo);
            panelContenedor.Controls.Add(lblEvento);
            panelContenedor.Controls.Add(cboEvento);
            panelContenedor.Controls.Add(lblCriticidad);
            panelContenedor.Controls.Add(cboCriticidad);
            panelContenedor.Controls.Add(lstMensajes);
            panelContenedor.Controls.Add(btnLimpiar);
            panelContenedor.Controls.Add(btnAplicar);
            panelContenedor.Controls.Add(btnImprimir);
            panelContenedor.Controls.Add(btnSalir);
            panelContenedor.Controls.Add(lblCantidadEventos);
            panelContenedor.Controls.Add(lblTotalEventos);
            panelContenedor.Location = new Point(24, 27);
            panelContenedor.Margin = new Padding(7, 8, 7, 8);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(2623, 1695);
            panelContenedor.TabIndex = 1;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(20, 70, 120);
            lblTitulo.Location = new Point(73, 55);
            lblTitulo.Margin = new Padding(7, 0, 7, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(588, 81);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Bitácora de Eventos";
            // 
            // dgvBitacora
            // 
            dgvBitacora.AllowUserToAddRows = false;
            dgvBitacora.AllowUserToDeleteRows = false;
            dgvBitacora.AllowUserToResizeRows = false;
            dgvBitacora.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBitacora.BackgroundColor = Color.FromArgb(18, 87, 150);
            dgvBitacora.BorderStyle = BorderStyle.None;
            dgvBitacora.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBitacora.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(18, 87, 150);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBitacora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBitacora.ColumnHeadersHeight = 58;
            dgvBitacora.EnableHeadersVisualStyles = false;
            dgvBitacora.GridColor = Color.FromArgb(220, 220, 220);
            dgvBitacora.Location = new Point(73, 191);
            dgvBitacora.Margin = new Padding(7, 8, 7, 8);
            dgvBitacora.MultiSelect = false;
            dgvBitacora.Name = "dgvBitacora";
            dgvBitacora.ReadOnly = true;
            dgvBitacora.RowHeadersVisible = false;
            dgvBitacora.RowHeadersWidth = 102;
            dgvBitacora.RowTemplate.Height = 28;
            dgvBitacora.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBitacora.Size = new Size(2501, 656);
            dgvBitacora.TabIndex = 1;
            dgvBitacora.SelectionChanged += dgvBitacora_SelectionChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(15, 45, 75);
            lblNombre.Location = new Point(194, 902);
            lblNombre.Margin = new Padding(7, 0, 7, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(152, 46);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.Location = new Point(194, 970);
            txtNombre.Margin = new Padding(7, 8, 7, 8);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(434, 52);
            txtNombre.TabIndex = 3;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblApellido.ForeColor = Color.FromArgb(15, 45, 75);
            lblApellido.Location = new Point(729, 902);
            lblApellido.Margin = new Padding(7, 0, 7, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(155, 46);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.Font = new Font("Segoe UI", 10F);
            txtApellido.Location = new Point(729, 970);
            txtApellido.Margin = new Padding(7, 8, 7, 8);
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.Size = new Size(434, 52);
            txtApellido.TabIndex = 5;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLogin.ForeColor = Color.FromArgb(15, 45, 75);
            lblLogin.Location = new Point(73, 1121);
            lblLogin.Margin = new Padding(7, 0, 7, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(110, 46);
            lblLogin.TabIndex = 6;
            lblLogin.Text = "Login";
            // 
            // cboLogin
            // 
            cboLogin.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLogin.Font = new Font("Segoe UI", 10F);
            cboLogin.Location = new Point(73, 1189);
            cboLogin.Margin = new Padding(7, 8, 7, 8);
            cboLogin.Name = "cboLogin";
            cboLogin.Size = new Size(359, 53);
            cboLogin.TabIndex = 7;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFechaInicio.ForeColor = Color.FromArgb(15, 45, 75);
            lblFechaInicio.Location = new Point(510, 1121);
            lblFechaInicio.Margin = new Padding(7, 0, 7, 0);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(208, 46);
            lblFechaInicio.TabIndex = 8;
            lblFechaInicio.Text = "Fecha Inicio";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Font = new Font("Segoe UI", 10F);
            dtpFechaInicio.Location = new Point(510, 1189);
            dtpFechaInicio.Margin = new Padding(7, 8, 7, 8);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(431, 52);
            dtpFechaInicio.TabIndex = 9;
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFechaFin.ForeColor = Color.FromArgb(15, 45, 75);
            lblFechaFin.Location = new Point(1020, 1121);
            lblFechaFin.Margin = new Padding(7, 0, 7, 0);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(168, 46);
            lblFechaFin.TabIndex = 10;
            lblFechaFin.Text = "Fecha Fin";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Font = new Font("Segoe UI", 10F);
            dtpFechaFin.Location = new Point(1020, 1189);
            dtpFechaFin.Margin = new Padding(7, 8, 7, 8);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(431, 52);
            dtpFechaFin.TabIndex = 11;
            // 
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblModulo.ForeColor = Color.FromArgb(15, 45, 75);
            lblModulo.Location = new Point(1530, 1121);
            lblModulo.Margin = new Padding(7, 0, 7, 0);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(147, 46);
            lblModulo.TabIndex = 12;
            lblModulo.Text = "Módulo";
            // 
            // cboModulo
            // 
            cboModulo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboModulo.Font = new Font("Segoe UI", 10F);
            cboModulo.Items.AddRange(new object[] { "Administracion", "Seguridad" });
            cboModulo.Location = new Point(1530, 1189);
            cboModulo.Margin = new Padding(7, 8, 7, 8);
            cboModulo.Name = "cboModulo";
            cboModulo.Size = new Size(286, 53);
            cboModulo.TabIndex = 13;
            // 
            // lblEvento
            // 
            lblEvento.AutoSize = true;
            lblEvento.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEvento.ForeColor = Color.FromArgb(15, 45, 75);
            lblEvento.Location = new Point(1894, 1121);
            lblEvento.Margin = new Padding(7, 0, 7, 0);
            lblEvento.Name = "lblEvento";
            lblEvento.Size = new Size(129, 46);
            lblEvento.TabIndex = 14;
            lblEvento.Text = "Evento";
            // 
            // cboEvento
            // 
            cboEvento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEvento.Font = new Font("Segoe UI", 10F);
            cboEvento.Items.AddRange(new object[] { "Login Correcto", "Login Incorrecto", "Logout", "Usuario Desbloqueado", "Usuario Bloqueado o Inactivo", "Usuario Modificado", "Usuario Creado", "Modificar Usuario", "Activar Usuario", "Desactivar Usuario", "Imprimir", "Cambio Clave" });
            cboEvento.Location = new Point(1894, 1189);
            cboEvento.Margin = new Padding(7, 8, 7, 8);
            cboEvento.Name = "cboEvento";
            cboEvento.Size = new Size(286, 53);
            cboEvento.TabIndex = 15;
            // 
            // lblCriticidad
            // 
            lblCriticidad.AutoSize = true;
            lblCriticidad.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCriticidad.ForeColor = Color.FromArgb(15, 45, 75);
            lblCriticidad.Location = new Point(2259, 1121);
            lblCriticidad.Margin = new Padding(7, 0, 7, 0);
            lblCriticidad.Name = "lblCriticidad";
            lblCriticidad.Size = new Size(174, 46);
            lblCriticidad.TabIndex = 16;
            lblCriticidad.Text = "Criticidad";
            // 
            // cboCriticidad
            // 
            cboCriticidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCriticidad.Font = new Font("Segoe UI", 10F);
            cboCriticidad.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cboCriticidad.Location = new Point(2259, 1189);
            cboCriticidad.Margin = new Padding(7, 8, 7, 8);
            cboCriticidad.Name = "cboCriticidad";
            cboCriticidad.Size = new Size(286, 53);
            cboCriticidad.TabIndex = 17;
            // 
            // lstMensajes
            // 
            lstMensajes.BorderStyle = BorderStyle.FixedSingle;
            lstMensajes.Font = new Font("Segoe UI", 9F);
            lstMensajes.ItemHeight = 41;
            lstMensajes.Location = new Point(73, 1274);
            lstMensajes.Margin = new Padding(7, 8, 7, 8);
            lstMensajes.Name = "lstMensajes";
            lstMensajes.Size = new Size(2499, 125);
            lstMensajes.TabIndex = 18;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.FromArgb(18, 87, 150);
            btnLimpiar.Location = new Point(777, 1558);
            btnLimpiar.Margin = new Padding(7, 8, 7, 8);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(291, 104);
            btnLimpiar.TabIndex = 19;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnAplicar
            // 
            btnAplicar.BackColor = Color.FromArgb(18, 87, 150);
            btnAplicar.FlatAppearance.BorderSize = 0;
            btnAplicar.FlatStyle = FlatStyle.Flat;
            btnAplicar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAplicar.ForeColor = Color.White;
            btnAplicar.Location = new Point(1117, 1558);
            btnAplicar.Margin = new Padding(7, 8, 7, 8);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(291, 104);
            btnAplicar.TabIndex = 20;
            btnAplicar.Text = "Aplicar";
            btnAplicar.UseVisualStyleBackColor = false;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.White;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnImprimir.ForeColor = Color.FromArgb(18, 87, 150);
            btnImprimir.Location = new Point(1457, 1558);
            btnImprimir.Margin = new Padding(7, 8, 7, 8);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(291, 104);
            btnImprimir.TabIndex = 21;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.White;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(18, 87, 150);
            btnSalir.Location = new Point(2234, 55);
            btnSalir.Margin = new Padding(7, 8, 7, 8);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(340, 104);
            btnSalir.TabIndex = 22;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblCantidadEventos
            // 
            lblCantidadEventos.AutoSize = true;
            lblCantidadEventos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCantidadEventos.ForeColor = Color.FromArgb(15, 45, 75);
            lblCantidadEventos.Location = new Point(2089, 902);
            lblCantidadEventos.Margin = new Padding(7, 0, 7, 0);
            lblCantidadEventos.Name = "lblCantidadEventos";
            lblCantidadEventos.Size = new Size(153, 46);
            lblCantidadEventos.TabIndex = 23;
            lblCantidadEventos.Text = "Eventos:";
            // 
            // lblTotalEventos
            // 
            lblTotalEventos.AutoSize = true;
            lblTotalEventos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalEventos.ForeColor = Color.FromArgb(18, 87, 150);
            lblTotalEventos.Location = new Point(2283, 902);
            lblTotalEventos.Margin = new Padding(7, 0, 7, 0);
            lblTotalEventos.Name = "lblTotalEventos";
            lblTotalEventos.Size = new Size(40, 46);
            lblTotalEventos.TabIndex = 24;
            lblTotalEventos.Text = "0";
            // 
            // panelInferior
            // 
            panelInferior.BackColor = Color.FromArgb(18, 87, 150);
            panelInferior.Controls.Add(lblUsuarioActivo);
            panelInferior.Dock = DockStyle.Bottom;
            panelInferior.Location = new Point(0, 1776);
            panelInferior.Margin = new Padding(7, 8, 7, 8);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(2708, 96);
            panelInferior.TabIndex = 0;
            // 
            // lblUsuarioActivo
            // 
            lblUsuarioActivo.AutoSize = true;
            lblUsuarioActivo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsuarioActivo.ForeColor = Color.White;
            lblUsuarioActivo.Location = new Point(49, 27);
            lblUsuarioActivo.Margin = new Padding(7, 0, 7, 0);
            lblUsuarioActivo.Name = "lblUsuarioActivo";
            lblUsuarioActivo.Size = new Size(440, 41);
            lblUsuarioActivo.TabIndex = 0;
            lblUsuarioActivo.Text = "Usuario activo: Administrador";
            // 
            // FormGestionBitacora
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(2708, 1872);
            Controls.Add(panelInferior);
            Controls.Add(panelContenedor);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(7, 8, 7, 8);
            MaximizeBox = false;
            Name = "FormGestionBitacora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CuentaClara - Gestión de Bitácora";
            Load += FormGestionBitacora_Load_1;
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBitacora).EndInit();
            panelInferior.ResumeLayout(false);
            panelInferior.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;

        private System.Windows.Forms.Label lblTitulo;

        private System.Windows.Forms.DataGridView dgvBitacora;

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;

        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.ComboBox cboLogin;

        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;

        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;

        private System.Windows.Forms.Label lblModulo;
        private System.Windows.Forms.ComboBox cboModulo;

        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.ComboBox cboEvento;

        private System.Windows.Forms.Label lblCriticidad;
        private System.Windows.Forms.ComboBox cboCriticidad;

        private System.Windows.Forms.ListBox lstMensajes;

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSalir;

        private System.Windows.Forms.Label lblCantidadEventos;
        private System.Windows.Forms.Label lblTotalEventos;

        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Label lblUsuarioActivo;
    }
}