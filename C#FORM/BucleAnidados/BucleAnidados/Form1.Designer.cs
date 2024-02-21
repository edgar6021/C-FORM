namespace BucleAnidados
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
            label2 = new Label();
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            listTabla = new ListBox();
            btnCalcular = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(241, 132);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(252, 28);
            label1.TabIndex = 0;
            label1.Text = "Ingresa el primer numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(738, 132);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(269, 28);
            label2.TabIndex = 1;
            label2.Text = "Ingresa el segundo numero";
            // 
            // txtNumero1
            // 
            txtNumero1.BackColor = SystemColors.Highlight;
            txtNumero1.Location = new Point(284, 199);
            txtNumero1.Margin = new Padding(4);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(186, 34);
            txtNumero1.TabIndex = 2;
            // 
            // txtNumero2
            // 
            txtNumero2.BackColor = SystemColors.Highlight;
            txtNumero2.Location = new Point(789, 199);
            txtNumero2.Margin = new Padding(4);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(186, 34);
            txtNumero2.TabIndex = 3;
            // 
            // listTabla
            // 
            listTabla.BackColor = SystemColors.Highlight;
            listTabla.FormattingEnabled = true;
            listTabla.ItemHeight = 28;
            listTabla.Location = new Point(134, 298);
            listTabla.Margin = new Padding(4);
            listTabla.Name = "listTabla";
            listTabla.Size = new Size(1020, 312);
            listTabla.TabIndex = 4;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Crimson;
            btnCalcular.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnCalcular.Location = new Point(542, 185);
            btnCalcular.Margin = new Padding(4);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(160, 62);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(460, 28);
            label3.Name = "label3";
            label3.Size = new Size(301, 50);
            label3.TabIndex = 6;
            label3.Text = "Bucle Anidados";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(1, 9);
            label4.Name = "label4";
            label4.Size = new Size(0, 50);
            label4.TabIndex = 8;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(279, 113);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 28);
            label5.TabIndex = 7;
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(439, 298);
            label6.Name = "label6";
            label6.Size = new Size(384, 50);
            label6.TabIndex = 9;
            label6.Text = "Tabla de multiplicar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(1200, 630);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(btnCalcular);
            Controls.Add(listTabla);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(label2);
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
        private Label label2;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private ListBox listTabla;
        private Button btnCalcular;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}