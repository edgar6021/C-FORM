namespace Condicionar_if_y_else
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);

            if (numero % 2 == 0)
            {
                listNumero.Items.Add(numero + " es par");
            }
            else
            {
                listNumero.Items.Add(numero + " es impar");

            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listNumero.Items.Clear();
            txtNumero.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}