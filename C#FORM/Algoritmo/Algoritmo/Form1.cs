namespace Algoritmo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int nota1 = int.Parse(textNota1.Text);
            int nota2 = int.Parse(textNota2.Text);
            int nota3 = int.Parse(textNota3.Text);

            int suma = nota1 + nota2 + nota3;

            int promedio = suma / 3;

            listResultado.Items.Add(promedio);



        }
    }
}