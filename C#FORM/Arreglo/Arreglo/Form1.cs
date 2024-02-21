namespace Arreglo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] letras = new string[3];
            letras[0] = "A";
            letras[1] = "B";
            letras[2] = "C";

            listArreglo.Items.Add(letras[0]);
            listArreglo.Items.Add(letras[1]);
            listArreglo.Items.Add(letras[2]);

        }
    }
}