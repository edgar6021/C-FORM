namespace Algoritmo
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
            label3 = new Label();
            textNota1 = new TextBox();
            textNota2 = new TextBox();
            textNota3 = new TextBox();
            listResultado = new ListBox();
            BtnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(294, 84);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(269, 28);
            label1.TabIndex = 0;
            label1.Text = "Ingrese la primera calificacion";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(294, 151);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(275, 28);
            label2.TabIndex = 1;
            label2.Text = "lngrese la segunda calificacion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(294, 212);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(261, 28);
            label3.TabIndex = 2;
            label3.Text = "Ingrese la tercera calificacion";
            // 
            // textNota1
            // 
            textNota1.Location = new Point(345, 116);
            textNota1.Margin = new Padding(4, 4, 4, 4);
            textNota1.Name = "textNota1";
            textNota1.Size = new Size(170, 34);
            textNota1.TabIndex = 3;
            // 
            // textNota2
            // 
            textNota2.Location = new Point(345, 183);
            textNota2.Margin = new Padding(4, 4, 4, 4);
            textNota2.Name = "textNota2";
            textNota2.Size = new Size(170, 34);
            textNota2.TabIndex = 4;
            // 
            // textNota3
            // 
            textNota3.Location = new Point(345, 244);
            textNota3.Margin = new Padding(4, 4, 4, 4);
            textNota3.Name = "textNota3";
            textNota3.Size = new Size(170, 34);
            textNota3.TabIndex = 5;
            // 
            // listResultado
            // 
            listResultado.FormattingEnabled = true;
            listResultado.ItemHeight = 28;
            listResultado.Location = new Point(327, 344);
            listResultado.Margin = new Padding(4, 4, 4, 4);
            listResultado.Name = "listResultado";
            listResultado.Size = new Size(205, 144);
            listResultado.TabIndex = 6;
            // 
            // BtnCalcular
            // 
            BtnCalcular.BackColor = Color.DarkCyan;
            BtnCalcular.Location = new Point(364, 295);
            BtnCalcular.Margin = new Padding(4, 4, 4, 4);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(129, 41);
            BtnCalcular.TabIndex = 7;
            BtnCalcular.Text = "Calcular";
            BtnCalcular.UseVisualStyleBackColor = false;
            BtnCalcular.Click += BtnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(1100, 630);
            Controls.Add(BtnCalcular);
            Controls.Add(listResultado);
            Controls.Add(textNota3);
            Controls.Add(textNota2);
            Controls.Add(textNota1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textNota1;
        private TextBox textNota2;
        private TextBox textNota3;
        private ListBox listResultado;
        private Button BtnCalcular;
    }
}