namespace Arreglos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] lenguajes = new string[3];

            lenguajes[0] = "C";
            lenguajes[1] = "C++";
            lenguajes[2] = "C#";

            listArreglo.Items.Add(lenguajes[0]);
            listArreglo.Items.Add(lenguajes[1]);
            listArreglo.Items.Add(lenguajes[2]);
        }
    }
}