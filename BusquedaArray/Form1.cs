namespace BusquedaArray
{
    public partial class Form1 : Form
    {
        private String[] nombres = {"Jose", "Eike", "Maria", "Wilfran" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;

            bool encuentra = false;

            for ( int i = 0; i<nombres.Length && encuentra== false; i++)
            {
                if (nombre.Equals(nombres[i]))
                { 
                    encuentra= true;
                }
            }

            if (encuentra)
            {
                MessageBox.Show("Se encontro el valor");
            }
            else
            {
                MessageBox.Show("No se encontro el valor");
            }



        }
    }
}