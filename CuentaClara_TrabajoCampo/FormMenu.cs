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
            FormGestionUsuarios frm =new FormGestionUsuarios();

            frm.ShowDialog();
        }
    }
}
