namespace PrimerComponente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            String texto = txtMensaje.Text;
            MessageBox.Show("", texto);
        }
    }
}