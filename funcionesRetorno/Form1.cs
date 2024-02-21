namespace funcionesRetorno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double descuentoCompra = calcularDescuento(double.Parse(txtCompra.Text));

            double totalNeto = double.Parse(txtCompra.Text) - descuentoCompra;

            txtDescuento.Text = descuentoCompra.ToString();

            txtNeto.Text = totalNeto.ToString();
        }

        public double calcularDescuento(double tc)
        {
            double descuento = 0;
            
            if (tc > 100 && tc <= 200)
            {
                descuento = tc * 0.05;
            }
            if (tc > 200 && tc <= 300)
            {
                descuento = tc * 0.1;
            }
            if (tc > 300)
            {
                descuento = tc * 0.2;
            }

            return descuento;
        }
    }
}