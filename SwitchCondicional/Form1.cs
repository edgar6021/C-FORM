namespace SwitchCondicional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            int opcion = int.Parse(cmbMes.SelectedItem.ToString());

            switch (opcion)
            {
                case 1:
                    {
                        txtMes.Text = "Enero";
                        break;
                    }
                case 2:
                    {
                        txtMes.Text = "Febrero";
                        break;
                    }
                case 3:
                    {
                        txtMes.Text = "Marzo";
                        break;
                    }
                case 4:
                    {
                        txtMes.Text = "Abril";
                        break;
                    }
                case 5:
                    {
                        txtMes.Text = "Mayo";
                        break;
                    }
                case 6:
                    {
                        txtMes.Text = "Junio";
                        break;
                    }
                case 7:
                    {
                        txtMes.Text = "Julio";
                        break;
                    }
                case 8:
                    {
                        txtMes.Text = "Agosto";
                        break;
                    }
                case 9:
                    {
                        txtMes.Text = "Septiembre";
                        break;
                    }
                case 10:
                    {
                        txtMes.Text = "Octubre";
                        break;
                    }
                case 11:
                    {
                        txtMes.Text = "Noviembre";
                        break;
                    }
                case 12:
                    {
                        txtMes.Text = "Diciembre";
                        break;
                    }
            }
        }
    }
}