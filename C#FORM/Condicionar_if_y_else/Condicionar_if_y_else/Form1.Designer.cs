namespace Condicionar_if_y_else
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
            listNumero = new ListBox();
            label1 = new Label();
            txtNumero = new TextBox();
            button1 = new Button();
            btnLimpiar = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // listNumero
            // 
            listNumero.FormattingEnabled = true;
            listNumero.ItemHeight = 28;
            listNumero.Location = new Point(356, 267);
            listNumero.Margin = new Padding(4);
            listNumero.Name = "listNumero";
            listNumero.Size = new Size(277, 88);
            listNumero.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 4);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 28);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(399, 142);
            txtNumero.Margin = new Padding(4);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(186, 34);
            txtNumero.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Aqua;
            button1.Location = new Point(356, 207);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(141, 41);
            button1.TabIndex = 4;
            button1.Text = "Ver";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Crimson;
            btnLimpiar.Location = new Point(519, 207);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 42);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(399, 110);
            label2.Name = "label2";
            label2.Size = new Size(190, 28);
            label2.TabIndex = 6;
            label2.Text = "Ingresa un numero";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(281, 40);
            label3.Name = "label3";
            label3.Size = new Size(450, 54);
            label3.TabIndex = 7;
            label3.Text = "Identificar un numero";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1200, 630);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnLimpiar);
            Controls.Add(button1);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Controls.Add(listNumero);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listNumero;
        private Label label1;
        private TextBox txtNumero;
        private Button button1;
        private Button btnLimpiar;
        private Label label2;
        private Label label3;
    }
}