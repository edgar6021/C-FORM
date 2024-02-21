namespace Ordenamientos
{
    public partial class Form1 : Form
    {
        private int[] numbers = { 12, 1, 453, 45, 84, 2, 42 };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (int i in numbers)
            {
                listDesordenada.Items.Add(i);
            }
        }

        private void BtnOrdenar_Click(object sender, EventArgs e)
        {
            Array.Sort(numbers);

            foreach (int i in numbers)
            {
                listOrdenada.Items.Add(i);
            }
        }
    }
}