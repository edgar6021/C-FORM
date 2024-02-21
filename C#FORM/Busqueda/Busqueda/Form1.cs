using System.Drawing.Text;

namespace Busqueda
{
    public partial class Form1 : Form
    {
        private string[] nombres = { "juan", "maria", "juanita", "pedrito", "olita" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;

            bool encuentra = false;

            for(int j = 0; j<nombres.Length && encuentra == false; j++)
                 {
                   if (name.Equals(nombres[j]))
                    {
                    encuentra = true;
                  }
                 }
            if (encuentra) {
                    listBuscar.Items.Add("Tiene acceso");                
                }else {
                    listBuscar.Items.Add("No tiene acceso");
                }
              
            }
    }
}