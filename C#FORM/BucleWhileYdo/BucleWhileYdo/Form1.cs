namespace BucleWhileYdo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {

            int Number = int.Parse(txtWhile.Text);
            while(Number > 0)
            {
                listWhile.Items.Add("Bucle While");

                Number--;
            }


        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtDo.Text);
            do
            {
                listDo.Items.Add("Bucle do While");

                number--;
            } while (number > 0);
    }
  }
}