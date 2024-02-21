namespace Facturacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            Cantidad = new Label();
            txtCantidad = new TextBox();
            label2 = new Label();
            txtPrecio = new TextBox();
            label3 = new Label();
            listView1 = new ListView();
            label4 = new Label();
            label5 = new Label();
            cmbCliente = new ComboBox();
            cmbDescuento = new ComboBox();
            cmbProducto = new ComboBox();
            cmbComprobante = new ComboBox();
            label6 = new Label();
            lblFecha = new Label();
            label7 = new Label();
            linkLabel1 = new LinkLabel();
            txtFecha = new TextBox();
            txtCant = new TextBox();
            Cliente = new Label();
            label8 = new Label();
            txtPrice = new TextBox();
            txtDesc = new TextBox();
            label9 = new Label();
            label10 = new Label();
            txtComp = new TextBox();
            label11 = new Label();
            txtClient = new TextBox();
            txtProduct = new TextBox();
            label12 = new Label();
            label13 = new Label();
            txtTotal = new TextBox();
            btnFacturar = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 83);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 28);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            // 
            // Cantidad
            // 
            Cantidad.AutoSize = true;
            Cantidad.Location = new Point(37, 166);
            Cantidad.Name = "Cantidad";
            Cantidad.Size = new Size(96, 28);
            Cantidad.TabIndex = 2;
            Cantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(33, 197);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 34);
            txtCantidad.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 260);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 28);
            label2.TabIndex = 4;
            label2.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(33, 291);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 34);
            txtPrecio.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 348);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 28);
            label3.TabIndex = 6;
            label3.Text = "Descuento";
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.ButtonHighlight;
            listView1.Location = new Point(186, 99);
            listView1.Name = "listView1";
            listView1.Size = new Size(456, 316);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(649, 83);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(140, 28);
            label4.TabIndex = 9;
            label4.Text = "Comprobante";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(649, 166);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(78, 28);
            label5.TabIndex = 11;
            label5.Text = "Cliente";
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(655, 197);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(151, 36);
            cmbCliente.TabIndex = 12;
            cmbCliente.SelectedIndexChanged += cmbCliente_SelectedIndexChanged;
            // 
            // cmbDescuento
            // 
            cmbDescuento.FormattingEnabled = true;
            cmbDescuento.Location = new Point(33, 379);
            cmbDescuento.Name = "cmbDescuento";
            cmbDescuento.Size = new Size(151, 36);
            cmbDescuento.TabIndex = 13;
            cmbDescuento.SelectedIndexChanged += cmbDescuento_SelectedIndexChanged;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(33, 114);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(151, 36);
            cmbProducto.TabIndex = 14;
            cmbProducto.SelectedIndexChanged += cmbProducto_SelectedIndexChanged;
            // 
            // cmbComprobante
            // 
            cmbComprobante.FormattingEnabled = true;
            cmbComprobante.Location = new Point(655, 119);
            cmbComprobante.Name = "cmbComprobante";
            cmbComprobante.Size = new Size(151, 36);
            cmbComprobante.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(337, 114);
            label6.Name = "label6";
            label6.Size = new Size(121, 28);
            label6.TabIndex = 16;
            label6.Text = "Facturacion";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(544, 109);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(0, 28);
            lblFecha.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(525, 109);
            label7.Name = "label7";
            label7.Size = new Size(0, 28);
            label7.TabIndex = 18;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(463, 174);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 28);
            linkLabel1.TabIndex = 19;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(491, 106);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(125, 34);
            txtFecha.TabIndex = 20;
            // 
            // txtCant
            // 
            txtCant.Location = new Point(208, 198);
            txtCant.Name = "txtCant";
            txtCant.Size = new Size(125, 34);
            txtCant.TabIndex = 21;
            // 
            // Cliente
            // 
            Cliente.AutoSize = true;
            Cliente.Location = new Point(375, 167);
            Cliente.Name = "Cliente";
            Cliente.Size = new Size(140, 28);
            Cliente.TabIndex = 22;
            Cliente.Text = "Comprobante";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(208, 235);
            label8.Name = "label8";
            label8.Size = new Size(71, 28);
            label8.TabIndex = 23;
            label8.Text = "Precio";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(208, 266);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 34);
            txtPrice.TabIndex = 24;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(208, 331);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(125, 34);
            txtDesc.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(208, 303);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(112, 28);
            label9.TabIndex = 26;
            label9.Text = "Descuento";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(208, 167);
            label10.Name = "label10";
            label10.Size = new Size(96, 28);
            label10.TabIndex = 27;
            label10.Text = "Cantidad";
            // 
            // txtComp
            // 
            txtComp.Location = new Point(375, 198);
            txtComp.Name = "txtComp";
            txtComp.Size = new Size(125, 34);
            txtComp.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(375, 235);
            label11.Name = "label11";
            label11.Size = new Size(78, 28);
            label11.TabIndex = 29;
            label11.Text = "Cliente";
            // 
            // txtClient
            // 
            txtClient.Location = new Point(375, 266);
            txtClient.Name = "txtClient";
            txtClient.Size = new Size(125, 34);
            txtClient.TabIndex = 30;
            // 
            // txtProduct
            // 
            txtProduct.Location = new Point(375, 331);
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(125, 34);
            txtProduct.TabIndex = 31;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(375, 303);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(98, 28);
            label12.TabIndex = 32;
            label12.Text = "Producto";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(544, 247);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(59, 28);
            label13.TabIndex = 33;
            label13.Text = "Total";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(517, 278);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(125, 34);
            txtTotal.TabIndex = 34;
            // 
            // btnFacturar
            // 
            btnFacturar.Location = new Point(239, 461);
            btnFacturar.Name = "btnFacturar";
            btnFacturar.Size = new Size(94, 42);
            btnFacturar.TabIndex = 35;
            btnFacturar.Text = "Facturar";
            btnFacturar.UseVisualStyleBackColor = true;
            btnFacturar.Click += btnFacturar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(390, 461);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 42);
            btnLimpiar.TabIndex = 36;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1200, 630);
            Controls.Add(btnLimpiar);
            Controls.Add(btnFacturar);
            Controls.Add(txtTotal);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(txtProduct);
            Controls.Add(txtClient);
            Controls.Add(label11);
            Controls.Add(txtComp);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtDesc);
            Controls.Add(txtPrice);
            Controls.Add(label8);
            Controls.Add(Cliente);
            Controls.Add(txtCant);
            Controls.Add(txtFecha);
            Controls.Add(linkLabel1);
            Controls.Add(label7);
            Controls.Add(lblFecha);
            Controls.Add(label6);
            Controls.Add(cmbComprobante);
            Controls.Add(cmbProducto);
            Controls.Add(cmbDescuento);
            Controls.Add(cmbCliente);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(listView1);
            Controls.Add(label3);
            Controls.Add(txtPrecio);
            Controls.Add(label2);
            Controls.Add(txtCantidad);
            Controls.Add(Cantidad);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Cantidad;
        private TextBox txtCantidad;
        private Label label2;
        private TextBox txtPrecio;
        private Label label3;
        private ListView listView1;
        private Label label4;
        private Label label5;
        private ComboBox cmbCliente;
        private ComboBox cmbDescuento;
        private ComboBox cmbProducto;
        private ComboBox cmbComprobante;
        private Label label6;
        private Label lblFecha;
        private Label label7;
        private LinkLabel linkLabel1;
        private TextBox txtFecha;
        private TextBox txtCant;
        private Label Cliente;
        private Label label8;
        private TextBox txtPrice;
        private TextBox txtDesc;
        private Label label9;
        private Label label10;
        private TextBox txtComp;
        private Label label11;
        private TextBox txtClient;
        private TextBox txtProduct;
        private Label label12;
        private Label label13;
        private TextBox txtTotal;
        private Button btnFacturar;
        private Button btnLimpiar;
    }
}