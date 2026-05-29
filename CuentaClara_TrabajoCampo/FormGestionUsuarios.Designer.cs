namespace CuentaClara_TrabajoCampo
{
    partial class FormGestionUsuarios
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
            this.panelContenedor = new System.Windows.Forms.Panel();

            this.lblTitulo = new System.Windows.Forms.Label();

            this.dgvUsuarios = new System.Windows.Forms.DataGridView();

            this.btnCrear = new System.Windows.Forms.Button();
            this.btnDesbloquear = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnActivarDesactivar = new System.Windows.Forms.Button();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();

            this.chkUsuariosActivos = new System.Windows.Forms.CheckBox();
            this.chkTodosUsuarios = new System.Windows.Forms.CheckBox();

            this.lblCantidadUsuarios = new System.Windows.Forms.Label();
            this.lblTotalUsuarios = new System.Windows.Forms.Label();

            this.lstMensajes = new System.Windows.Forms.ListBox();

            this.panelInferior = new System.Windows.Forms.Panel();
            this.lblUsuarioActivo = new System.Windows.Forms.Label();

            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.panelInferior.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.White;
            this.panelContenedor.Controls.Add(this.lblTitulo);

            this.panelContenedor.Controls.Add(this.dgvUsuarios);

            this.panelContenedor.Controls.Add(this.btnCrear);
            this.panelContenedor.Controls.Add(this.btnDesbloquear);
            this.panelContenedor.Controls.Add(this.btnModificar);
            this.panelContenedor.Controls.Add(this.btnActivarDesactivar);
            this.panelContenedor.Controls.Add(this.btnAplicar);
            this.panelContenedor.Controls.Add(this.btnCancelar);
            this.panelContenedor.Controls.Add(this.btnSalir);

            this.panelContenedor.Controls.Add(this.chkUsuariosActivos);
            this.panelContenedor.Controls.Add(this.chkTodosUsuarios);

            this.panelContenedor.Controls.Add(this.lblCantidadUsuarios);
            this.panelContenedor.Controls.Add(this.lblTotalUsuarios);

            this.panelContenedor.Controls.Add(this.lstMensajes);

            this.panelContenedor.Location = new System.Drawing.Point(20, 20);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1240, 680);
            this.panelContenedor.TabIndex = 0;

            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(20, 70, 120);
            this.lblTitulo.Location = new System.Drawing.Point(30, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(291, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestión de Usuarios";

            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            this.dgvUsuarios.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(18, 87, 150);
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(18, 87, 150);

            this.dgvUsuarios.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvUsuarios.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(220, 230, 240);
            this.dgvUsuarios.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.GridColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.dgvUsuarios.Location = new System.Drawing.Point(35, 105);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowTemplate.Height = 32;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(1165, 320);
            this.dgvUsuarios.TabIndex = 1;

            // 
            // Columnas
            // 
            this.dgvUsuarios.Columns.Add("colNombre", "Nombre");
            this.dgvUsuarios.Columns.Add("colApellido", "Apellido");
            this.dgvUsuarios.Columns.Add("colDni", "DNI");
            this.dgvUsuarios.Columns.Add("colRol", "Rol");
            this.dgvUsuarios.Columns.Add("colLogin", "Login");
            this.dgvUsuarios.Columns.Add("colEstado", "Estado");

            // 
            // CheckBox Usuarios Activos
            // 
            this.chkUsuariosActivos.AutoSize = true;
            this.chkUsuariosActivos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.chkUsuariosActivos.ForeColor = System.Drawing.Color.FromArgb(15, 45, 75);
            this.chkUsuariosActivos.Location = new System.Drawing.Point(40, 70);
            this.chkUsuariosActivos.Name = "chkUsuariosActivos";
            this.chkUsuariosActivos.Size = new System.Drawing.Size(145, 23);
            this.chkUsuariosActivos.TabIndex = 2;
            this.chkUsuariosActivos.Text = "Usuarios Activos";
            this.chkUsuariosActivos.UseVisualStyleBackColor = true;

            // 
            // chkTodosUsuarios
            // 
            this.chkTodosUsuarios.AutoSize = true;
            this.chkTodosUsuarios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.chkTodosUsuarios.ForeColor = System.Drawing.Color.FromArgb(15, 45, 75);
            this.chkTodosUsuarios.Location = new System.Drawing.Point(220, 70);
            this.chkTodosUsuarios.Name = "chkTodosUsuarios";
            this.chkTodosUsuarios.Size = new System.Drawing.Size(138, 23);
            this.chkTodosUsuarios.TabIndex = 3;
            this.chkTodosUsuarios.Text = "Todos Usuarios";
            this.chkTodosUsuarios.UseVisualStyleBackColor = true;

            // 
            // lblCantidadUsuarios
            // 
            this.lblCantidadUsuarios.AutoSize = true;
            this.lblCantidadUsuarios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCantidadUsuarios.ForeColor = System.Drawing.Color.FromArgb(15, 45, 75);
            this.lblCantidadUsuarios.Location = new System.Drawing.Point(960, 73);
            this.lblCantidadUsuarios.Name = "lblCantidadUsuarios";
            this.lblCantidadUsuarios.Size = new System.Drawing.Size(137, 19);
            this.lblCantidadUsuarios.TabIndex = 4;
            this.lblCantidadUsuarios.Text = "Total de Usuarios:";

            // 
            // lblTotalUsuarios
            // 
            this.lblTotalUsuarios.AutoSize = true;
            this.lblTotalUsuarios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalUsuarios.ForeColor = System.Drawing.Color.FromArgb(18, 87, 150);
            this.lblTotalUsuarios.Location = new System.Drawing.Point(1105, 73);
            this.lblTotalUsuarios.Name = "lblTotalUsuarios";
            this.lblTotalUsuarios.Size = new System.Drawing.Size(25, 19);
            this.lblTotalUsuarios.TabIndex = 5;
            this.lblTotalUsuarios.Text = "15";

            // 
            // lstMensajes
            // 
            this.lstMensajes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstMensajes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstMensajes.FormattingEnabled = true;
            this.lstMensajes.ItemHeight = 15;
            this.lstMensajes.Location = new System.Drawing.Point(35, 445);
            this.lstMensajes.Name = "lstMensajes";
            this.lstMensajes.Size = new System.Drawing.Size(1165, 92);
            this.lstMensajes.TabIndex = 6;

            // 
            // BOTONES
            // 
            System.Drawing.Size tamañoBoton = new System.Drawing.Size(140, 42);

            // btnCrear
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(18, 87, 150);
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.Location = new System.Drawing.Point(35, 565);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = tamañoBoton;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;

            // btnDesbloquear
            this.btnDesbloquear.BackColor = System.Drawing.Color.White;
            this.btnDesbloquear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesbloquear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDesbloquear.ForeColor = System.Drawing.Color.FromArgb(18, 87, 150);
            this.btnDesbloquear.Location = new System.Drawing.Point(190, 565);
            this.btnDesbloquear.Name = "btnDesbloquear";
            this.btnDesbloquear.Size = tamañoBoton;
            this.btnDesbloquear.Text = "Desbloquear";
            this.btnDesbloquear.UseVisualStyleBackColor = false;

            // btnModificar
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.Color.FromArgb(18, 87, 150);
            this.btnModificar.Location = new System.Drawing.Point(345, 565);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = tamañoBoton;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;

            // btnActivarDesactivar
            this.btnActivarDesactivar.BackColor = System.Drawing.Color.White;
            this.btnActivarDesactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivarDesactivar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnActivarDesactivar.ForeColor = System.Drawing.Color.FromArgb(18, 87, 150);
            this.btnActivarDesactivar.Location = new System.Drawing.Point(500, 565);
            this.btnActivarDesactivar.Name = "btnActivarDesactivar";
            this.btnActivarDesactivar.Size = new System.Drawing.Size(180, 42);
            this.btnActivarDesactivar.Text = "Activar / Desactivar";
            this.btnActivarDesactivar.UseVisualStyleBackColor = false;

            // btnAplicar
            this.btnAplicar.BackColor = System.Drawing.Color.FromArgb(18, 87, 150);
            this.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicar.FlatAppearance.BorderSize = 0;
            this.btnAplicar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAplicar.ForeColor = System.Drawing.Color.White;
            this.btnAplicar.Location = new System.Drawing.Point(835, 565);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = tamañoBoton;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = false;

            // btnCancelar
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(18, 87, 150);
            this.btnCancelar.Location = new System.Drawing.Point(990, 565);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = tamañoBoton;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;

            // btnSalir
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(18, 87, 150);
            this.btnSalir.Location = new System.Drawing.Point(1145, 565);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 42);
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;

            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.FromArgb(18, 87, 150);
            this.panelInferior.Controls.Add(this.lblUsuarioActivo);
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 720);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(1280, 40);

            // 
            // lblUsuarioActivo
            // 
            this.lblUsuarioActivo.AutoSize = true;
            this.lblUsuarioActivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuarioActivo.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioActivo.Location = new System.Drawing.Point(20, 12);
            this.lblUsuarioActivo.Name = "lblUsuarioActivo";
            this.lblUsuarioActivo.Size = new System.Drawing.Size(185, 15);
            this.lblUsuarioActivo.Text = "Usuario activo: Administrador";

            // 
            // frmGestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 246, 248);
            this.ClientSize = new System.Drawing.Size(1280, 760);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.panelContenedor);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmGestionUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CuentaClara - Gestión de Usuarios";

            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.panelInferior.ResumeLayout(false);
            this.panelInferior.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvUsuarios;

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnDesbloquear;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnActivarDesactivar;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;

        private System.Windows.Forms.CheckBox chkUsuariosActivos;
        private System.Windows.Forms.CheckBox chkTodosUsuarios;

        private System.Windows.Forms.Label lblCantidadUsuarios;
        private System.Windows.Forms.Label lblTotalUsuarios;

        private System.Windows.Forms.ListBox lstMensajes;

        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Label lblUsuarioActivo;
    }
}