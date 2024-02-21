namespace Bucle_While_y_Do_While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);

            do

            {
                ListMensaje.Items.Add("Este es un bucle while");

                numero--;
            }
            while (numero > 0) ;

        }
    }
}