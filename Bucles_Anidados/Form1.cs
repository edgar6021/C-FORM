namespace Bucles_Anidados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=1; i<=10; i++)
            {
                for(int j =1; j<=10;j++)
                {
                    listTablas.Items.Add(i + "X" + j + "=" + (i * j));
                }
                listTablas.Items.Add("");
            }
        }
    }
}