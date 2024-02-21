namespace ArraysOrdenamiento
{
    public partial class Form1 : Form
    {
        private int[] numeros = { 8, 10, 5, 23, 2, 15, 18 };  
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Cargar el Array a ListBox para mostrar los elementos desordenados
            foreach (int num in numeros) { 
                listDesordenado.Items.Add(num);
            }

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            Array.Sort(numeros);
            
            foreach (int num in numeros)
            {
                listOrdenado.Items.Add(num);
            }

        }
    }
}