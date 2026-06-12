using BLL;

namespace IU
{
    partial class FormGestionPerfiles
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
            panelPrincipal = new Panel();
            button2 = new Button();
            button1 = new Button();
            lblTitulo = new Label();
            lblFamilia = new Label();
            cmbFamilia = new ComboBox();
            lblRol = new Label();
            cmbRol = new ComboBox();
            lblPermiso = new Label();
            cmbPermiso = new ComboBox();
            btnAsignarRol = new Button();
            btnAsignarPermiso = new Button();
            btnCrearFamilia = new Button();
            btnCancelar = new Button();
            dgvEstructura = new DataGridView();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstructura).BeginInit();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.Anchor = AnchorStyles.None;
            panelPrincipal.BackColor = Color.White;
            panelPrincipal.BorderStyle = BorderStyle.FixedSingle;
            panelPrincipal.Controls.Add(button2);
            panelPrincipal.Controls.Add(button1);
            panelPrincipal.Controls.Add(lblTitulo);
            panelPrincipal.Controls.Add(lblFamilia);
            panelPrincipal.Controls.Add(cmbFamilia);
            panelPrincipal.Controls.Add(lblRol);
            panelPrincipal.Controls.Add(cmbRol);
            panelPrincipal.Controls.Add(lblPermiso);
            panelPrincipal.Controls.Add(cmbPermiso);
            panelPrincipal.Controls.Add(btnAsignarRol);
            panelPrincipal.Controls.Add(btnAsignarPermiso);
            panelPrincipal.Controls.Add(btnCrearFamilia);
            panelPrincipal.Controls.Add(btnCancelar);
            panelPrincipal.Controls.Add(dgvEstructura);
            panelPrincipal.Location = new Point(20, 20);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1320, 1055);
            panelPrincipal.TabIndex = 0;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.FromArgb(18, 87, 150);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(311, 411);
            button2.Name = "button2";
            button2.Size = new Size(206, 124);
            button2.TabIndex = 13;
            button2.Text = "Modificar Permiso";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(18, 87, 150);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(78, 423);
            button1.Name = "button1";
            button1.Size = new Size(197, 112);
            button1.TabIndex = 12;
            button1.Text = "Eliminar Permiso";
            button1.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(20, 70, 120);
            lblTitulo.Location = new Point(76, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(559, 81);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Perfiles";
            // 
            // lblFamilia
            // 
            lblFamilia.Anchor = AnchorStyles.None;
            lblFamilia.AutoSize = true;
            lblFamilia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFamilia.Location = new Point(76, 151);
            lblFamilia.Name = "lblFamilia";
            lblFamilia.Size = new Size(134, 46);
            lblFamilia.TabIndex = 1;
            lblFamilia.Text = "Familia";
            // 
            // cmbFamilia
            // 
            cmbFamilia.Anchor = AnchorStyles.None;
            cmbFamilia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFamilia.Location = new Point(76, 211);
            cmbFamilia.Name = "cmbFamilia";
            cmbFamilia.Size = new Size(250, 49);
            cmbFamilia.TabIndex = 2;
            // 
            // lblRol
            // 
            lblRol.Anchor = AnchorStyles.None;
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRol.Location = new Point(367, 151);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(72, 46);
            lblRol.TabIndex = 3;
            lblRol.Text = "Rol";
            // 
            // cmbRol
            // 
            cmbRol.Anchor = AnchorStyles.None;
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.Location = new Point(367, 211);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(250, 49);
            cmbRol.TabIndex = 4;
            // 
            // lblPermiso
            // 
            lblPermiso.Anchor = AnchorStyles.None;
            lblPermiso.AutoSize = true;
            lblPermiso.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPermiso.Location = new Point(662, 151);
            lblPermiso.Name = "lblPermiso";
            lblPermiso.Size = new Size(149, 46);
            lblPermiso.TabIndex = 5;
            lblPermiso.Text = "Permiso";
            // 
            // cmbPermiso
            // 
            cmbPermiso.Anchor = AnchorStyles.None;
            cmbPermiso.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPermiso.Location = new Point(662, 211);
            cmbPermiso.Name = "cmbPermiso";
            cmbPermiso.Size = new Size(250, 49);
            cmbPermiso.TabIndex = 6;
            // 
            // btnAsignarRol
            // 
            btnAsignarRol.Anchor = AnchorStyles.None;
            btnAsignarRol.BackColor = Color.FromArgb(18, 87, 150);
            btnAsignarRol.FlatStyle = FlatStyle.Flat;
            btnAsignarRol.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAsignarRol.ForeColor = Color.White;
            btnAsignarRol.Location = new Point(78, 314);
            btnAsignarRol.Name = "btnAsignarRol";
            btnAsignarRol.Size = new Size(197, 72);
            btnAsignarRol.TabIndex = 7;
            btnAsignarRol.Text = "Asignar Rol";
            btnAsignarRol.UseVisualStyleBackColor = false;
            btnAsignarRol.Click += btnAsignarRol_Click;
            // 
            // btnAsignarPermiso
            // 
            btnAsignarPermiso.Anchor = AnchorStyles.None;
            btnAsignarPermiso.BackColor = Color.FromArgb(18, 87, 150);
            btnAsignarPermiso.FlatStyle = FlatStyle.Flat;
            btnAsignarPermiso.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAsignarPermiso.ForeColor = Color.White;
            btnAsignarPermiso.Location = new Point(311, 284);
            btnAsignarPermiso.Name = "btnAsignarPermiso";
            btnAsignarPermiso.Size = new Size(206, 102);
            btnAsignarPermiso.TabIndex = 8;
            btnAsignarPermiso.Text = "Asignar Permiso";
            btnAsignarPermiso.UseVisualStyleBackColor = false;
            btnAsignarPermiso.Click += btnAsignarPermiso_Click;
            // 
            // btnCrearFamilia
            // 
            btnCrearFamilia.Anchor = AnchorStyles.None;
            btnCrearFamilia.BackColor = Color.White;
            btnCrearFamilia.FlatStyle = FlatStyle.Flat;
            btnCrearFamilia.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCrearFamilia.ForeColor = Color.FromArgb(18, 87, 150);
            btnCrearFamilia.Location = new Point(565, 330);
            btnCrearFamilia.Name = "btnCrearFamilia";
            btnCrearFamilia.Size = new Size(270, 56);
            btnCrearFamilia.TabIndex = 9;
            btnCrearFamilia.Text = "Crear Familia";
            btnCrearFamilia.UseVisualStyleBackColor = false;
            btnCrearFamilia.Click += btnCrearFamilia_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = Color.White;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(18, 87, 150);
            btnCancelar.Location = new Point(600, 423);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(235, 58);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // dgvEstructura
            // 
            dgvEstructura.Anchor = AnchorStyles.None;
            dgvEstructura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEstructura.BackgroundColor = Color.White;
            dgvEstructura.ColumnHeadersHeight = 58;
            dgvEstructura.Location = new Point(76, 541);
            dgvEstructura.Name = "dgvEstructura";
            dgvEstructura.RowHeadersWidth = 102;
            dgvEstructura.Size = new Size(1148, 463);
            dgvEstructura.TabIndex = 11;
            // 
            // FormGestionPerfiles
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(1670, 1112);
            Controls.Add(panelPrincipal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormGestionPerfiles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CuentaClara - Gestión de Perfiles";
            Load += FormGestionPerfiles_Load;
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstructura).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelPrincipal;
        private Label lblTitulo;

        private Label lblFamilia;
        private ComboBox cmbFamilia;

        private Label lblRol;
        private ComboBox cmbRol;

        private Label lblPermiso;
        private ComboBox cmbPermiso;

        private Button btnAsignarRol;
        private Button btnAsignarPermiso;
        private Button btnCrearFamilia;
        private Button btnCancelar;

        private DataGridView dgvEstructura;
        private Button button2;
        private Button button1;
    }
}