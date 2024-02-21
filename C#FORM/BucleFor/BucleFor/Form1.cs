namespace BucleFor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVerFor_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                listFor.Items.Add(i.ToString());
            }
        }
    }
}