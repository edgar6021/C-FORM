namespace Ordenamientos
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
            listDesordenada = new ListBox();
            listOrdenada = new ListBox();
            BtnOrdenar = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(187, 34);
            label1.Name = "label1";
            label1.Size = new Size(350, 41);
            label1.TabIndex = 0;
            label1.Text = "Ordanamiento de Array";
            // 
            // listDesordenada
            // 
            listDesordenada.FormattingEnabled = true;
            listDesordenada.ItemHeight = 20;
            listDesordenada.Location = new Point(126, 128);
            listDesordenada.Name = "listDesordenada";
            listDesordenada.Size = new Size(150, 224);
            listDesordenada.TabIndex = 1;
            // 
            // listOrdenada
            // 
            listOrdenada.FormattingEnabled = true;
            listOrdenada.ItemHeight = 20;
            listOrdenada.Location = new Point(410, 128);
            listOrdenada.Name = "listOrdenada";
            listOrdenada.Size = new Size(150, 224);
            listOrdenada.TabIndex = 2;
            // 
            // BtnOrdenar
            // 
            BtnOrdenar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnOrdenar.Location = new Point(282, 215);
            BtnOrdenar.Name = "BtnOrdenar";
            BtnOrdenar.Size = new Size(122, 44);
            BtnOrdenar.TabIndex = 3;
            BtnOrdenar.Text = "Ordenar";
            BtnOrdenar.UseVisualStyleBackColor = true;
            BtnOrdenar.Click += BtnOrdenar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(116, 94);
            label2.Name = "label2";
            label2.Size = new Size(207, 31);
            label2.TabIndex = 4;
            label2.Text = "Lista desordenada";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(400, 94);
            label3.Name = "label3";
            label3.Size = new Size(171, 31);
            label3.TabIndex = 5;
            label3.Text = "Lista ordenada";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BtnOrdenar);
            Controls.Add(listOrdenada);
            Controls.Add(listDesordenada);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listDesordenada;
        private ListBox listOrdenada;
        private Button BtnOrdenar;
        private Label label2;
        private Label label3;
    }
}