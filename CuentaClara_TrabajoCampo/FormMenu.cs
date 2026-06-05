namespace CuentaClara_TrabajoCampo
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGestionUsuarios frm = new FormGestionUsuarios();
          
            this.Hide();

            frm.ShowDialog();

            this.Show();
        }

        private void panelMovimientos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTransacciones_Click(object sender, EventArgs e)
        {

        }
    }
}
