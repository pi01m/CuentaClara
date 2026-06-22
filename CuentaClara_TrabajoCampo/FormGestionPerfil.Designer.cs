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
            btnAsignarPermiso = new Button();
            btnAsignarFamilia = new Button();
            btnCrear = new Button();
            btnAplicar = new Button();
            cmbFamiliaHija = new ComboBox();
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            panel1 = new Panel();
            treeViewVistaPrevia = new TreeView();
            cmbFamilia = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            clbFamilia = new CheckedListBox();
            clbPermiso = new CheckedListBox();
            btnSalir = new Button();
            panelInferior = new Panel();
            lblUsuarioActivo = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panelInferior.SuspendLayout();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(51, 237);
            treeView1.Margin = new Padding(0);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(439, 254);
            treeView1.TabIndex = 34;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(radioBtn_Familia);
            groupBox1.Controls.Add(radioBtn_Rol);
            groupBox1.Location = new Point(873, 120);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 3, 2, 3);
            groupBox1.Size = new Size(461, 189);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            // 
            // radioBtn_Familia
            // 
            radioBtn_Familia.AutoSize = true;
            radioBtn_Familia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            radioBtn_Familia.Location = new Point(216, 71);
            radioBtn_Familia.Margin = new Padding(0);
            radioBtn_Familia.Name = "radioBtn_Familia";
            radioBtn_Familia.Size = new Size(193, 50);
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
            radioBtn_Rol.Location = new Point(29, 77);
            radioBtn_Rol.Margin = new Padding(0);
            radioBtn_Rol.Name = "radioBtn_Rol";
            radioBtn_Rol.Size = new Size(54, 23);
            radioBtn_Rol.TabIndex = 0;
            radioBtn_Rol.TabStop = true;
            radioBtn_Rol.Text = "ROL";
            radioBtn_Rol.UseVisualStyleBackColor = true;
            radioBtn_Rol.CheckedChanged += radioBtn_Rol_CheckedChanged_1;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.None;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(51, 529);
            listBox1.Margin = new Padding(0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(835, 124);
            listBox1.TabIndex = 31;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.None;
            btnModificar.BackColor = Color.FromArgb(18, 87, 150);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(581, 327);
            btnModificar.Margin = new Padding(0);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(384, 120);
            btnModificar.TabIndex = 30;
            btnModificar.Text = "Modificar";
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
            btnEliminar.Location = new Point(581, 399);
            btnEliminar.Margin = new Padding(0);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(384, 118);
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
            lblTitulo.Location = new Point(42, 23);
            lblTitulo.Margin = new Padding(0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(559, 81);
            lblTitulo.TabIndex = 19;
            lblTitulo.Text = "Gestión de Perfiles";
            // 
            // lblRol
            // 
            lblRol.Anchor = AnchorStyles.None;
            lblRol.AutoSize = true;
            lblRol.BackColor = Color.White;
            lblRol.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRol.Location = new Point(53, 79);
            lblRol.Margin = new Padding(0);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(72, 46);
            lblRol.TabIndex = 21;
            lblRol.Text = "Rol";
            // 
            // cmbRol
            // 
            cmbRol.Anchor = AnchorStyles.None;
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.Location = new Point(53, 107);
            cmbRol.Margin = new Padding(0);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(249, 49);
            cmbRol.TabIndex = 22;
            // 
            // btnAsignarPermiso
            // 
            btnAsignarPermiso.Anchor = AnchorStyles.None;
            btnAsignarPermiso.BackColor = Color.FromArgb(18, 87, 150);
            btnAsignarPermiso.FlatStyle = FlatStyle.Flat;
            btnAsignarPermiso.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAsignarPermiso.ForeColor = Color.White;
            btnAsignarPermiso.Location = new Point(841, 327);
            btnAsignarPermiso.Margin = new Padding(0);
            btnAsignarPermiso.Name = "btnAsignarPermiso";
            btnAsignarPermiso.Size = new Size(403, 120);
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
            btnAsignarFamilia.Location = new Point(841, 265);
            btnAsignarFamilia.Margin = new Padding(0);
            btnAsignarFamilia.Name = "btnAsignarFamilia";
            btnAsignarFamilia.Size = new Size(403, 120);
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
            btnCrear.Location = new Point(581, 265);
            btnCrear.Margin = new Padding(0);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(384, 120);
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
            btnAplicar.Location = new Point(51, 672);
            btnAplicar.Margin = new Padding(0);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(260, 118);
            btnAplicar.TabIndex = 28;
            btnAplicar.Text = "Aplicar";
            btnAplicar.UseVisualStyleBackColor = false;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // cmbFamiliaHija
            // 
            cmbFamiliaHija.Anchor = AnchorStyles.None;
            cmbFamiliaHija.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFamiliaHija.Location = new Point(53, 189);
            cmbFamiliaHija.Margin = new Padding(0);
            cmbFamiliaHija.Name = "cmbFamiliaHija";
            cmbFamiliaHija.Size = new Size(249, 49);
            cmbFamiliaHija.TabIndex = 36;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(18, 87, 150);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(841, 399);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(403, 118);
            button1.TabIndex = 37;
            button1.Text = "Desasignar ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(53, 157);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(212, 46);
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
            button2.Location = new Point(197, 672);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(260, 118);
            button2.TabIndex = 40;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(treeViewVistaPrevia);
            panel1.Controls.Add(cmbFamilia);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(clbFamilia);
            panel1.Controls.Add(clbPermiso);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(cmbFamiliaHija);
            panel1.Controls.Add(btnCrear);
            panel1.Controls.Add(label2);
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
            panel1.Location = new Point(51, 27);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1172, 766);
            panel1.TabIndex = 41;
            panel1.Paint += panel1_Paint;
            // 
            // treeViewVistaPrevia
            // 
            treeViewVistaPrevia.Location = new Point(671, 79);
            treeViewVistaPrevia.Margin = new Padding(0);
            treeViewVistaPrevia.Name = "treeViewVistaPrevia";
            treeViewVistaPrevia.Size = new Size(151, 141);
            treeViewVistaPrevia.TabIndex = 48;
            // 
            // cmbFamilia
            // 
            cmbFamilia.Anchor = AnchorStyles.None;
            cmbFamilia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFamilia.Location = new Point(217, 107);
            cmbFamilia.Margin = new Padding(0);
            cmbFamilia.Name = "cmbFamilia";
            cmbFamilia.Size = new Size(105, 23);
            cmbFamilia.TabIndex = 46;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(215, 79);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(57, 19);
            label4.TabIndex = 47;
            label4.Text = "Familia";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(525, 79);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(57, 19);
            label3.TabIndex = 45;
            label3.Text = "Familia";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(370, 79);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(64, 19);
            label1.TabIndex = 44;
            label1.Text = "Permiso";
            // 
            // clbFamilia
            // 
            clbFamilia.FormattingEnabled = true;
            clbFamilia.Location = new Point(525, 107);
            clbFamilia.Name = "clbFamilia";
            clbFamilia.Size = new Size(120, 94);
            clbFamilia.TabIndex = 43;
            clbFamilia.SelectedIndexChanged += clbFamilia_SelectedIndexChanged;
            // 
            // clbPermiso
            // 
            clbPermiso.FormattingEnabled = true;
            clbPermiso.Location = new Point(370, 107);
            clbPermiso.Name = "clbPermiso";
            clbPermiso.Size = new Size(120, 94);
            clbPermiso.TabIndex = 42;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.White;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(18, 87, 150);
            btnSalir.Location = new Point(1019, 23);
            btnSalir.Margin = new Padding(1);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(260, 118);
            btnSalir.TabIndex = 23;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // panelInferior
            // 
            panelInferior.BackColor = Color.FromArgb(18, 87, 150);
            panelInferior.Controls.Add(lblUsuarioActivo);
            panelInferior.Dock = DockStyle.Bottom;
            panelInferior.Location = new Point(0, 759);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(1227, 40);
            panelInferior.TabIndex = 42;
            // 
            // lblUsuarioActivo
            // 
            lblUsuarioActivo.AutoSize = true;
            lblUsuarioActivo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsuarioActivo.ForeColor = Color.White;
            lblUsuarioActivo.Location = new Point(20, 12);
            lblUsuarioActivo.Name = "lblUsuarioActivo";
            lblUsuarioActivo.Size = new Size(171, 15);
            lblUsuarioActivo.TabIndex = 0;
            lblUsuarioActivo.Text = "Usuario activo: Administrador";
            // 
            // FormGestionPerfil
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(1227, 799);
            Controls.Add(panelInferior);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            Name = "FormGestionPerfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CuentaClara - Gestión de Perfiles";
            Load += FormGestionPerfil_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelInferior.ResumeLayout(false);
            panelInferior.PerformLayout();
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
        private Button btnAsignarPermiso;
        private Button btnAsignarFamilia;
        private Button btnCrear;
        private Button btnAplicar;
        private ComboBox cmbFamiliaHija;
        private Button button1;
        private Label label2;
        private Button button2;
        private Panel panel1;
        private Button btnSalir;
        private CheckedListBox clbFamilia;
        private CheckedListBox clbPermiso;
        private Label label3;
        private Label label1;
        private ComboBox cmbFamilia;
        private Label label4;
        private TreeView treeViewVistaPrevia;
        private Panel panelInferior;
        private Label lblUsuarioActivo;
    }
}