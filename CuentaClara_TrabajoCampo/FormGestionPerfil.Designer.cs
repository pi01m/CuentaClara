namespace IU
{
    partial class FormGestionPerfil
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
            treeView1 = new TreeView();
            groupBox1 = new GroupBox();
            radioBtn_Familia = new RadioButton();
            radioBtn_Rol = new RadioButton();
            listBox1 = new ListBox();
            btnModificar = new Button();
            btnEliminar = new Button();
            lblTitulo = new Label();
            lblRol = new Label();
            cmbRol = new ComboBox();
            lblPermiso = new Label();
            cmbPermiso = new ComboBox();
            btnAsignarPermiso = new Button();
            btnAsignarFamilia = new Button();
            btnCrear = new Button();
            btnAplicar = new Button();
            cmbFamilia = new ComboBox();
            cmbFamiliaHija = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(83, 670);
            treeView1.Margin = new Padding(2, 3, 2, 3);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(1383, 594);
            treeView1.TabIndex = 34;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(radioBtn_Familia);
            groupBox1.Controls.Add(radioBtn_Rol);
            groupBox1.Location = new Point(1649, 262);
            groupBox1.Margin = new Padding(2, 3, 2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 3, 2, 3);
            groupBox1.Size = new Size(384, 118);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            // 
            // radioBtn_Familia
            // 
            radioBtn_Familia.AutoSize = true;
            radioBtn_Familia.Location = new Point(185, 30);
            radioBtn_Familia.Margin = new Padding(2, 3, 2, 3);
            radioBtn_Familia.Name = "radioBtn_Familia";
            radioBtn_Familia.Size = new Size(163, 45);
            radioBtn_Familia.TabIndex = 17;
            radioBtn_Familia.TabStop = true;
            radioBtn_Familia.Text = "FAMILIA";
            radioBtn_Familia.UseVisualStyleBackColor = true;
            radioBtn_Familia.CheckedChanged += radioBtn_Familia_CheckedChanged;
            // 
            // radioBtn_Rol
            // 
            radioBtn_Rol.AutoSize = true;
            radioBtn_Rol.Location = new Point(15, 30);
            radioBtn_Rol.Margin = new Padding(2, 3, 2, 3);
            radioBtn_Rol.Name = "radioBtn_Rol";
            radioBtn_Rol.Size = new Size(97, 45);
            radioBtn_Rol.TabIndex = 0;
            radioBtn_Rol.TabStop = true;
            radioBtn_Rol.Text = "Rol";
            radioBtn_Rol.UseVisualStyleBackColor = true;
            radioBtn_Rol.CheckedChanged += radioBtn_Rol_CheckedChanged_1;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.None;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 41;
            listBox1.Location = new Point(85, 1416);
            listBox1.Margin = new Padding(2, 3, 2, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(2022, 291);
            listBox1.TabIndex = 31;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.None;
            btnModificar.BackColor = Color.FromArgb(18, 87, 150);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(1957, 713);
            btnModificar.Margin = new Padding(2, 3, 2, 3);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(260, 118);
            btnModificar.TabIndex = 30;
            btnModificar.Text = "Modificar Permiso";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.BackColor = Color.FromArgb(18, 87, 150);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(1634, 713);
            btnEliminar.Margin = new Padding(2, 3, 2, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(260, 118);
            btnEliminar.TabIndex = 29;
            btnEliminar.Text = "Eliminar ";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(20, 70, 120);
            lblTitulo.Location = new Point(85, 82);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(559, 81);
            lblTitulo.TabIndex = 19;
            lblTitulo.Text = "Gestión de Perfiles";
            // 
            // lblRol
            // 
            lblRol.Anchor = AnchorStyles.None;
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRol.Location = new Point(112, 235);
            lblRol.Margin = new Padding(2, 0, 2, 0);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(72, 46);
            lblRol.TabIndex = 21;
            lblRol.Text = "Rol";
            // 
            // cmbRol
            // 
            cmbRol.Anchor = AnchorStyles.None;
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.Location = new Point(112, 314);
            cmbRol.Margin = new Padding(2, 3, 2, 3);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(249, 49);
            cmbRol.TabIndex = 22;
            // 
            // lblPermiso
            // 
            lblPermiso.Anchor = AnchorStyles.None;
            lblPermiso.AutoSize = true;
            lblPermiso.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPermiso.Location = new Point(459, 235);
            lblPermiso.Margin = new Padding(2, 0, 2, 0);
            lblPermiso.Name = "lblPermiso";
            lblPermiso.Size = new Size(149, 46);
            lblPermiso.TabIndex = 23;
            lblPermiso.Text = "Permiso";
            // 
            // cmbPermiso
            // 
            cmbPermiso.Anchor = AnchorStyles.None;
            cmbPermiso.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPermiso.Location = new Point(459, 314);
            cmbPermiso.Margin = new Padding(2, 3, 2, 3);
            cmbPermiso.Name = "cmbPermiso";
            cmbPermiso.Size = new Size(249, 49);
            cmbPermiso.TabIndex = 24;
            // 
            // btnAsignarPermiso
            // 
            btnAsignarPermiso.Anchor = AnchorStyles.None;
            btnAsignarPermiso.BackColor = Color.FromArgb(18, 87, 150);
            btnAsignarPermiso.FlatStyle = FlatStyle.Flat;
            btnAsignarPermiso.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAsignarPermiso.ForeColor = Color.White;
            btnAsignarPermiso.Location = new Point(889, 262);
            btnAsignarPermiso.Margin = new Padding(2, 3, 2, 3);
            btnAsignarPermiso.Name = "btnAsignarPermiso";
            btnAsignarPermiso.Size = new Size(277, 118);
            btnAsignarPermiso.TabIndex = 25;
            btnAsignarPermiso.Text = "Asignar Permiso";
            btnAsignarPermiso.UseVisualStyleBackColor = false;
            btnAsignarPermiso.Click += btnAsignarPermiso_Click_1;
            // 
            // btnAsignarFamilia
            // 
            btnAsignarFamilia.Anchor = AnchorStyles.None;
            btnAsignarFamilia.BackColor = Color.FromArgb(18, 87, 150);
            btnAsignarFamilia.FlatStyle = FlatStyle.Flat;
            btnAsignarFamilia.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAsignarFamilia.ForeColor = Color.White;
            btnAsignarFamilia.Location = new Point(1243, 260);
            btnAsignarFamilia.Margin = new Padding(2, 3, 2, 3);
            btnAsignarFamilia.Name = "btnAsignarFamilia";
            btnAsignarFamilia.Size = new Size(260, 118);
            btnAsignarFamilia.TabIndex = 26;
            btnAsignarFamilia.Text = "Asignar Familia";
            btnAsignarFamilia.UseVisualStyleBackColor = false;
            btnAsignarFamilia.Click += btnAsignarFamilia_Click;
            // 
            // btnCrear
            // 
            btnCrear.Anchor = AnchorStyles.None;
            btnCrear.BackColor = Color.White;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCrear.ForeColor = Color.FromArgb(18, 87, 150);
            btnCrear.Location = new Point(1634, 506);
            btnCrear.Margin = new Padding(2, 3, 2, 3);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(260, 118);
            btnCrear.TabIndex = 27;
            btnCrear.Text = "Crear Familia";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click_1;
            // 
            // btnAplicar
            // 
            btnAplicar.Anchor = AnchorStyles.None;
            btnAplicar.BackColor = Color.White;
            btnAplicar.FlatStyle = FlatStyle.Flat;
            btnAplicar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAplicar.ForeColor = Color.FromArgb(18, 87, 150);
            btnAplicar.Location = new Point(85, 1744);
            btnAplicar.Margin = new Padding(2, 3, 2, 3);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(260, 118);
            btnAplicar.TabIndex = 28;
            btnAplicar.Text = "Aplicar";
            btnAplicar.UseVisualStyleBackColor = false;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // cmbFamilia
            // 
            cmbFamilia.Anchor = AnchorStyles.None;
            cmbFamilia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFamilia.Location = new Point(112, 459);
            cmbFamilia.Margin = new Padding(2, 3, 2, 3);
            cmbFamilia.Name = "cmbFamilia";
            cmbFamilia.Size = new Size(249, 49);
            cmbFamilia.TabIndex = 35;
            // 
            // cmbFamiliaHija
            // 
            cmbFamiliaHija.Anchor = AnchorStyles.None;
            cmbFamiliaHija.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFamiliaHija.Location = new Point(459, 459);
            cmbFamiliaHija.Margin = new Padding(2, 3, 2, 3);
            cmbFamiliaHija.Name = "cmbFamiliaHija";
            cmbFamiliaHija.Size = new Size(249, 49);
            cmbFamiliaHija.TabIndex = 36;
            // 
            // FormGestionPerfil
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(2317, 1922);
            Controls.Add(cmbFamilia);
            Controls.Add(cmbFamiliaHija);
            Controls.Add(treeView1);
            Controls.Add(groupBox1);
            Controls.Add(listBox1);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(lblTitulo);
            Controls.Add(lblRol);
            Controls.Add(cmbRol);
            Controls.Add(lblPermiso);
            Controls.Add(cmbPermiso);
            Controls.Add(btnAsignarPermiso);
            Controls.Add(btnAsignarFamilia);
            Controls.Add(btnCrear);
            Controls.Add(btnAplicar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            Name = "FormGestionPerfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CuentaClara - Gestión de Perfiles";
            Load += FormGestionPerfil_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private GroupBox groupBox1;
        private RadioButton radioBtn_Familia;
        private RadioButton radioBtn_Rol;
        private ListBox listBox1;
        private Button btnModificar;
        private Button btnEliminar;
        private Label lblTitulo;
        private Label lblRol;
        private ComboBox cmbRol;
        private Label lblPermiso;
        private ComboBox cmbPermiso;
        private Button btnAsignarPermiso;
        private Button btnAsignarFamilia;
        private Button btnCrear;
        private Button btnAplicar;
        private ComboBox cmbFamilia;
        private ComboBox cmbFamiliaHija;
    }
}