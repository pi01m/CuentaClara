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
            panelPrincipal = new Panel();
            treeView1 = new TreeView();
            label1 = new Label();
            cmbFamiliaHija = new ComboBox();
            groupBox1 = new GroupBox();
            radioBtn_Familia = new RadioButton();
            radioBtn_Rol = new RadioButton();
            listBox1 = new ListBox();
            btnModificar = new Button();
            btnEliminar = new Button();
            lblTitulo = new Label();
            lblFamilia = new Label();
            cmbFamilia = new ComboBox();
            lblRol = new Label();
            cmbRol = new ComboBox();
            lblPermiso = new Label();
            cmbPermiso = new ComboBox();
            btnAsignarPermiso = new Button();
            btnAsignarFamilia = new Button();
            btnCrear = new Button();
            btnAplicar = new Button();
            panelPrincipal.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.Anchor = AnchorStyles.None;
            panelPrincipal.BackColor = Color.White;
            panelPrincipal.BorderStyle = BorderStyle.FixedSingle;
            panelPrincipal.Controls.Add(treeView1);
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Controls.Add(cmbFamiliaHija);
            panelPrincipal.Controls.Add(groupBox1);
            panelPrincipal.Controls.Add(listBox1);
            panelPrincipal.Controls.Add(btnModificar);
            panelPrincipal.Controls.Add(btnEliminar);
            panelPrincipal.Controls.Add(lblTitulo);
            panelPrincipal.Controls.Add(lblFamilia);
            panelPrincipal.Controls.Add(cmbFamilia);
            panelPrincipal.Controls.Add(lblRol);
            panelPrincipal.Controls.Add(cmbRol);
            panelPrincipal.Controls.Add(lblPermiso);
            panelPrincipal.Controls.Add(cmbPermiso);
            panelPrincipal.Controls.Add(btnAsignarPermiso);
            panelPrincipal.Controls.Add(btnAsignarFamilia);
            panelPrincipal.Controls.Add(btnCrear);
            panelPrincipal.Controls.Add(btnAplicar);
            panelPrincipal.Location = new Point(104, 32);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(2039, 1182);
            panelPrincipal.TabIndex = 0;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(164, 578);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(988, 519);
            treeView1.TabIndex = 18;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(88, 335);
            label1.Name = "label1";
            label1.Size = new Size(207, 46);
            label1.TabIndex = 16;
            label1.Text = "Familia Hija";
            // 
            // cmbFamiliaHija
            // 
            cmbFamiliaHija.Anchor = AnchorStyles.None;
            cmbFamiliaHija.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFamiliaHija.Location = new Point(88, 395);
            cmbFamiliaHija.Name = "cmbFamiliaHija";
            cmbFamiliaHija.Size = new Size(250, 49);
            cmbFamiliaHija.TabIndex = 17;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(radioBtn_Familia);
            groupBox1.Controls.Add(radioBtn_Rol);
            groupBox1.Location = new Point(1295, 395);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(414, 108);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // radioBtn_Familia
            // 
            radioBtn_Familia.AutoSize = true;
            radioBtn_Familia.Location = new Point(230, 46);
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
            radioBtn_Rol.Location = new Point(46, 46);
            radioBtn_Rol.Name = "radioBtn_Rol";
            radioBtn_Rol.Size = new Size(110, 45);
            radioBtn_Rol.TabIndex = 0;
            radioBtn_Rol.TabStop = true;
            radioBtn_Rol.Text = "ROL";
            radioBtn_Rol.UseVisualStyleBackColor = true;
            radioBtn_Rol.CheckedChanged += radioBtn_Rol_CheckedChanged;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.None;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 41;
            listBox1.Location = new Point(1211, 578);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(583, 127);
            listBox1.TabIndex = 14;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.None;
            btnModificar.BackColor = Color.FromArgb(18, 87, 150);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(1399, 216);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(206, 58);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "Modificar Permiso";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.BackColor = Color.FromArgb(18, 87, 150);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(1172, 216);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(191, 60);
            btnEliminar.TabIndex = 12;
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
            lblTitulo.Location = new Point(70, 46);
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
            lblFamilia.Location = new Point(88, 167);
            lblFamilia.Name = "lblFamilia";
            lblFamilia.Size = new Size(134, 46);
            lblFamilia.TabIndex = 1;
            lblFamilia.Text = "Familia";
            // 
            // cmbFamilia
            // 
            cmbFamilia.Anchor = AnchorStyles.None;
            cmbFamilia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFamilia.Location = new Point(88, 227);
            cmbFamilia.Name = "cmbFamilia";
            cmbFamilia.Size = new Size(250, 49);
            cmbFamilia.TabIndex = 2;
            // 
            // lblRol
            // 
            lblRol.Anchor = AnchorStyles.None;
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRol.Location = new Point(379, 167);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(72, 46);
            lblRol.TabIndex = 3;
            lblRol.Text = "Rol";
            // 
            // cmbRol
            // 
            cmbRol.Anchor = AnchorStyles.None;
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.Location = new Point(379, 227);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(250, 49);
            cmbRol.TabIndex = 4;
            cmbRol.SelectedIndexChanged += cmbRol_SelectedIndexChanged;
            // 
            // lblPermiso
            // 
            lblPermiso.Anchor = AnchorStyles.None;
            lblPermiso.AutoSize = true;
            lblPermiso.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPermiso.Location = new Point(674, 167);
            lblPermiso.Name = "lblPermiso";
            lblPermiso.Size = new Size(149, 46);
            lblPermiso.TabIndex = 5;
            lblPermiso.Text = "Permiso";
            // 
            // cmbPermiso
            // 
            cmbPermiso.Anchor = AnchorStyles.None;
            cmbPermiso.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPermiso.Location = new Point(674, 227);
            cmbPermiso.Name = "cmbPermiso";
            cmbPermiso.Size = new Size(250, 49);
            cmbPermiso.TabIndex = 6;
            // 
            // btnAsignarPermiso
            // 
            btnAsignarPermiso.Anchor = AnchorStyles.None;
            btnAsignarPermiso.BackColor = Color.FromArgb(18, 87, 150);
            btnAsignarPermiso.FlatStyle = FlatStyle.Flat;
            btnAsignarPermiso.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAsignarPermiso.ForeColor = Color.White;
            btnAsignarPermiso.Location = new Point(1270, 280);
            btnAsignarPermiso.Name = "btnAsignarPermiso";
            btnAsignarPermiso.Size = new Size(197, 111);
            btnAsignarPermiso.TabIndex = 7;
            btnAsignarPermiso.Text = "Asignar Permiso";
            btnAsignarPermiso.UseVisualStyleBackColor = false;
            btnAsignarPermiso.Click += btnAsignarPermiso_Click;
            // 
            // btnAsignarFamilia
            // 
            btnAsignarFamilia.Anchor = AnchorStyles.None;
            btnAsignarFamilia.BackColor = Color.FromArgb(18, 87, 150);
            btnAsignarFamilia.FlatStyle = FlatStyle.Flat;
            btnAsignarFamilia.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAsignarFamilia.ForeColor = Color.White;
            btnAsignarFamilia.Location = new Point(1503, 280);
            btnAsignarFamilia.Name = "btnAsignarFamilia";
            btnAsignarFamilia.Size = new Size(206, 111);
            btnAsignarFamilia.TabIndex = 8;
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
            btnCrear.Location = new Point(1656, 218);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(180, 56);
            btnCrear.TabIndex = 9;
            btnCrear.Text = "Crear Familia";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnAplicar
            // 
            btnAplicar.Anchor = AnchorStyles.None;
            btnAplicar.BackColor = Color.White;
            btnAplicar.FlatStyle = FlatStyle.Flat;
            btnAplicar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAplicar.ForeColor = Color.FromArgb(18, 87, 150);
            btnAplicar.Location = new Point(857, 356);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(242, 147);
            btnAplicar.TabIndex = 10;
            btnAplicar.Text = "Aplicar";
            btnAplicar.UseVisualStyleBackColor = false;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // FormGestionPerfil
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(2547, 1268);
            Controls.Add(panelPrincipal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormGestionPerfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CuentaClara - Gestión de Perfiles";
            Load += FormGestionPerfil_Load;
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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

        private Button btnAsignarPermiso;
        private Button btnAsignarFamilia;
        private Button btnCrear;
        private Button btnAplicar;
        private Button btnModificar;
        private Button btnEliminar;
        private GroupBox groupBox1;
        private RadioButton radioBtn_Familia;
        private RadioButton radioBtn_Rol;
        private ListBox listBox1;
        private Label label1;
        private ComboBox cmbFamiliaHija;
        private TreeView treeView1;
    }
}