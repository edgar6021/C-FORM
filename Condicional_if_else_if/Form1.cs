namespace Condicional_if_else_if
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDescuento.Enabled = false;
            txtCompraDescuento.Enabled=false;


        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int compra = int.Parse(txtCompra.Text);

            double descuento = 0;

            double compraDescuento = 0;

            if (compra > 100)
            {
                descuento = compra * 0.05;
            }
            else if (compra >= 150)
            {
                descuento = compra * 0.1;
            }
            else if (compra >= 200)
            {
                descuento = compra * 0.15;
            }

            compraDescuento = compra - descuento;

            txtDescuento.Text = descuento.ToString();
            txtCompraDescuento.Text=compraDescuento.ToString();

        }
    }
}