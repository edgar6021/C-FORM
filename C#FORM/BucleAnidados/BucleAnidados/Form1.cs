namespace BucleAnidados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txtNumero1.Text);
            int numero2 = int.Parse(txtNumero2.Text);

            for (int i = 1; i <= numero1; i++)
            {
                for (int k = 1; k <= numero2; k++)
                {
                    listTabla.Items.Add(i + "x" + k + "=" + (i * k));
                }
                listTabla.Items.Add("");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }
    }
}