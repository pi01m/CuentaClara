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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            panel1 = new Panel();
            btnSalir = new Button();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(42, 215);
            treeView1.Margin = new Padding(0);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(383, 254);
            treeView1.TabIndex = 34;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(radioBtn_Familia);
            groupBox1.Controls.Add(radioBtn_Rol);
            groupBox1.Location = new Point(448, 73);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(1);
            groupBox1.Size = new Size(190, 69);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            // 
            // radioBtn_Familia
            // 
            radioBtn_Familia.AutoSize = true;
            radioBtn_Familia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            radioBtn_Familia.Location = new Point(89, 26);
            radioBtn_Familia.Margin = new Padding(0);
            radioBtn_Familia.Name = "radioBtn_Familia";
            radioBtn_Familia.Size = new Size(81, 23);
            radioBtn_Familia.TabIndex = 17;
            radioBtn_Familia.TabStop = true;
            radioBtn_Familia.Text = "FAMILIA";
            radioBtn_Familia.UseVisualStyleBackColor = true;
            radioBtn_Familia.CheckedChanged += radioBtn_Familia_CheckedChanged;
            // 
            // radioBtn_Rol
            // 
            radioBtn_Rol.AutoSize = true;
            radioBtn_Rol.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            radioBtn_Rol.Location = new Point(12, 28);
            radioBtn_Rol.Margin = new Padding(0);
            radioBtn_Rol.Name = "radioBtn_Rol";
            radioBtn_Rol.Size = new Size(49, 23);
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
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(35, 514);
            listBox1.Margin = new Padding(0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(835, 109);
            listBox1.TabIndex = 31;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.None;
            btnModificar.BackColor = Color.FromArgb(18, 87, 150);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(460, 303);
            btnModificar.Margin = new Padding(0);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(158, 44);
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
            btnEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(460, 375);
            btnEliminar.Margin = new Padding(0);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(158, 43);
            btnEliminar.TabIndex = 29;
            btnEliminar.Text = "Eliminar ";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.White;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(20, 70, 120);
            lblTitulo.Location = new Point(35, 25);
            lblTitulo.Margin = new Padding(0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(228, 32);
            lblTitulo.TabIndex = 19;
            lblTitulo.Text = "Gestión de Perfiles";
            // 
            // lblRol
            // 
            lblRol.Anchor = AnchorStyles.None;
            lblRol.AutoSize = true;
            lblRol.BackColor = Color.White;
            lblRol.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRol.Location = new Point(35, 73);
            lblRol.Margin = new Padding(0);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(31, 19);
            lblRol.TabIndex = 21;
            lblRol.Text = "Rol";
            // 
            // cmbRol
            // 
            cmbRol.Anchor = AnchorStyles.None;
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.Location = new Point(37, 101);
            cmbRol.Margin = new Padding(0);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(105, 23);
            cmbRol.TabIndex = 22;
            // 
            // lblPermiso
            // 
            lblPermiso.Anchor = AnchorStyles.None;
            lblPermiso.AutoSize = true;
            lblPermiso.BackColor = Color.White;
            lblPermiso.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPermiso.Location = new Point(199, 73);
            lblPermiso.Margin = new Padding(0);
            lblPermiso.Name = "lblPermiso";
            lblPermiso.Size = new Size(64, 19);
            lblPermiso.TabIndex = 23;
            lblPermiso.Text = "Permiso";
            // 
            // cmbPermiso
            // 
            cmbPermiso.Anchor = AnchorStyles.None;
            cmbPermiso.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPermiso.Location = new Point(199, 101);
            cmbPermiso.Margin = new Padding(0);
            cmbPermiso.Name = "cmbPermiso";
            cmbPermiso.Size = new Size(105, 23);
            cmbPermiso.TabIndex = 24;
            // 
            // btnAsignarPermiso
            // 
            btnAsignarPermiso.Anchor = AnchorStyles.None;
            btnAsignarPermiso.BackColor = Color.FromArgb(18, 87, 150);
            btnAsignarPermiso.FlatStyle = FlatStyle.Flat;
            btnAsignarPermiso.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAsignarPermiso.ForeColor = Color.White;
            btnAsignarPermiso.Location = new Point(678, 303);
            btnAsignarPermiso.Margin = new Padding(0);
            btnAsignarPermiso.Name = "btnAsignarPermiso";
            btnAsignarPermiso.Size = new Size(166, 44);
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
            btnAsignarFamilia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAsignarFamilia.ForeColor = Color.White;
            btnAsignarFamilia.Location = new Point(678, 241);
            btnAsignarFamilia.Margin = new Padding(0);
            btnAsignarFamilia.Name = "btnAsignarFamilia";
            btnAsignarFamilia.Size = new Size(166, 44);
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
            btnCrear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCrear.ForeColor = Color.FromArgb(18, 87, 150);
            btnCrear.Location = new Point(460, 241);
            btnCrear.Margin = new Padding(0);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(158, 44);
            btnCrear.TabIndex = 27;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click_1;
            // 
            // btnAplicar
            // 
            btnAplicar.Anchor = AnchorStyles.None;
            btnAplicar.BackColor = Color.White;
            btnAplicar.FlatStyle = FlatStyle.Flat;
            btnAplicar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAplicar.ForeColor = Color.FromArgb(18, 87, 150);
            btnAplicar.Location = new Point(35, 643);
            btnAplicar.Margin = new Padding(0);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(107, 43);
            btnAplicar.TabIndex = 28;
            btnAplicar.Text = "Aplicar";
            btnAplicar.UseVisualStyleBackColor = false;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // cmbFamilia
            // 
            cmbFamilia.Anchor = AnchorStyles.None;
            cmbFamilia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFamilia.Location = new Point(35, 171);
            cmbFamilia.Margin = new Padding(0);
            cmbFamilia.Name = "cmbFamilia";
            cmbFamilia.Size = new Size(105, 23);
            cmbFamilia.TabIndex = 35;
            // 
            // cmbFamiliaHija
            // 
            cmbFamiliaHija.Anchor = AnchorStyles.None;
            cmbFamiliaHija.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFamiliaHija.Location = new Point(199, 171);
            cmbFamiliaHija.Margin = new Padding(0);
            cmbFamiliaHija.Name = "cmbFamiliaHija";
            cmbFamiliaHija.Size = new Size(105, 23);
            cmbFamiliaHija.TabIndex = 36;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(18, 87, 150);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(678, 375);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(166, 43);
            button1.TabIndex = 37;
            button1.Text = "Desasignar ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(37, 141);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(57, 19);
            label1.TabIndex = 38;
            label1.Text = "Familia";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(199, 141);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(90, 19);
            label2.TabIndex = 39;
            label2.Text = "Familia-Hija";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(18, 87, 150);
            button2.Location = new Point(161, 643);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(107, 43);
            button2.TabIndex = 40;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(cmbFamiliaHija);
            panel1.Controls.Add(btnCrear);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmbPermiso);
            panel1.Controls.Add(lblPermiso);
            panel1.Controls.Add(cmbFamilia);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(cmbRol);
            panel1.Controls.Add(lblRol);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(treeView1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnAsignarFamilia);
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(btnAsignarPermiso);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnAplicar);
            panel1.Location = new Point(21, 10);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1069, 709);
            panel1.TabIndex = 41;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.White;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(18, 87, 150);
            btnSalir.Location = new Point(893, 24);
            btnSalir.Margin = new Padding(1);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(107, 43);
            btnSalir.TabIndex = 23;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormGestionPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(1133, 740);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(1);
            MaximizeBox = false;
            Name = "FormGestionPerfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CuentaClara - Gestión de Perfiles";
            Load += FormGestionPerfil_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
        private Panel panel1;
        private Button btnSalir;
    }
}