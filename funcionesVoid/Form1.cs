namespace funcionesVoid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void saludar()
        {
            MessageBox.Show("Este es un mensaje de la funcion");
        }
        private void btnSaludar_Click(object sender, EventArgs e)
        {
            saludar();
        }
    }
}