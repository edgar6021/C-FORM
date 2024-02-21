namespace introPOO1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AireAcondicionado aire1 = new AireAcondicionado("Toshiba", "Seiya_Plus_10","Blanco",220,18000,16);
           

            MessageBox.Show(aire1.getBtu());
        }
    }
}