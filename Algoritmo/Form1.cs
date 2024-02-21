namespace Algoritmo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int nota1 = int.Parse(txtNota1.Text);
            int nota2 = int.Parse(txtNota2.Text);
            int nota3 = int.Parse(txtNota3.Text);

            int suma = nota1 + nota2 + nota3;

            int promedio = suma / 3;

            MessageBox.Show("El Promedio es: "+promedio);

        }
    }
}