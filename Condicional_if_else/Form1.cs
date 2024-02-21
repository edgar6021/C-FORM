namespace Condicional_if_else
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEvaluacion_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);

            if (numero % 2 == 0)
            {
                MessageBox.Show("El numero ingresado es Par");
            }
            else
            {
                MessageBox.Show("El numero ingresado es Impar");
            }
        }
    }
}