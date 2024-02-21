namespace Busqueda
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
            listBuscar = new ListBox();
            btnBuscar = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Aqua;
            label1.Location = new Point(417, 76);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(325, 54);
            label1.TabIndex = 0;
            label1.Text = "Busqueda Array";
            // 
            // listBuscar
            // 
            listBuscar.FormattingEnabled = true;
            listBuscar.ItemHeight = 28;
            listBuscar.Location = new Point(289, 348);
            listBuscar.Name = "listBuscar";
            listBuscar.Size = new Size(551, 88);
            listBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.MenuText;
            btnBuscar.ForeColor = Color.Aqua;
            btnBuscar.Location = new Point(534, 275);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(97, 45);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(468, 165);
            label2.Name = "label2";
            label2.Size = new Size(216, 31);
            label2.TabIndex = 3;
            label2.Text = "Ingresa un nombre";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(454, 216);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 34);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 9);
            label3.Name = "label3";
            label3.Size = new Size(172, 28);
            label3.TabIndex = 5;
            label3.Text = "Edgar De la Rosa";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(1200, 630);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(btnBuscar);
            Controls.Add(listBuscar);
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
        private ListBox listBuscar;
        private Button btnBuscar;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
    }
}