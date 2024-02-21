using System;
using System.Windows.Forms;
namespace Facturacion
{
    public partial class Form1 : Form
    {
        private string[] productos = { "Iphone", "Samsung", "Laptop" };
        private int[] descuento = { 10, 15, 20, 30 };
        private string[] Tipo_comprobante = { "Fiscal", "No Fiscal" };
        private string[] Clientes = { "Juan", "Arturo", "Yeremi", "Juancito" };

        public Form1()
        {
            InitializeComponent();
            cmbDescuento.SelectedIndexChanged += cmbDescuento_SelectedIndexChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbProducto.Items.AddRange(productos);
            cmbCliente.Items.AddRange(Clientes);
            cmbComprobante.Items.AddRange(Tipo_comprobante);
            cmbDescuento.Items.AddRange(descuento.Select(d => d.ToString()).ToArray());

            DateTime fecha = DateTime.Now;
            txtFecha.Text = fecha.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
            }
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCant.Text, out int cantidad))
            {
                txtCant.Text = cantidad.ToString();
            }
            else
            {
                MessageBox.Show("Cantidad debe ser un número entero válido.");
            }

            if (double.TryParse(txtPrice.Text, out double precio))
            {
                txtPrice.Text = precio.ToString();
            }
            else
            {
                MessageBox.Show("Precio debe ser un número válido.");
            }

            if (int.TryParse(txtDesc.Text, out int Desct))
            {
                cmbDescuento.SelectedIndex = Desct;
            }
            else
            {
                MessageBox.Show("Descuento debe elegir un porcentaje válido.");
            }
        }

        private void cmbDescuento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDescuento.SelectedIndex >= 0)
            {
                txtDesc.Text = cmbDescuento.SelectedItem.ToString();
            }
        }
    }
}
