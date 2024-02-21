namespace For_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);
            
            for (int i = 1; i <=10; i++)
            {
                listTabla.Items.Add(numero+"X"+i+"="+(numero*i)); 
            }
        }
    }
}