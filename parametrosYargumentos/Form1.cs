namespace parametrosYargumentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void sumar(int num1, int num2)
        {
            int resultado = num1 + num2;

            MessageBox.Show("La suma de los numero es: " + resultado);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txtNumero1.Text);
            int numero2 = int.Parse(txtNumero2.Text);

            sumar(numero1, numero2);
        }
    }
}