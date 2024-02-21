namespace Bucle_For_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i<=3; i++)
            {
                MessageBox.Show("Hola Mundo");
            }
        }
    }
}