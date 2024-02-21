namespace BucleWhileYdo
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
            listWhile = new ListBox();
            label1 = new Label();
            txtWhile = new TextBox();
            btnWhile = new Button();
            label2 = new Label();
            label3 = new Label();
            txtDo = new TextBox();
            btnDo = new Button();
            listDo = new ListBox();
            SuspendLayout();
            // 
            // listWhile
            // 
            listWhile.FormattingEnabled = true;
            listWhile.ItemHeight = 28;
            listWhile.Location = new Point(252, 290);
            listWhile.Name = "listWhile";
            listWhile.Size = new Size(245, 172);
            listWhile.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(267, 156);
            label1.Name = "label1";
            label1.Size = new Size(189, 28);
            label1.TabIndex = 1;
            label1.Text = "lngresa un numero";
            // 
            // txtWhile
            // 
            txtWhile.Location = new Point(249, 196);
            txtWhile.Name = "txtWhile";
            txtWhile.Size = new Size(245, 34);
            txtWhile.TabIndex = 2;
            // 
            // btnWhile
            // 
            btnWhile.Location = new Point(317, 245);
            btnWhile.Name = "btnWhile";
            btnWhile.Size = new Size(94, 39);
            btnWhile.TabIndex = 3;
            btnWhile.Text = "Ver";
            btnWhile.UseVisualStyleBackColor = true;
            btnWhile.Click += btnWhile_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(317, 90);
            label2.Name = "label2";
            label2.Size = new Size(367, 38);
            label2.TabIndex = 4;
            label2.Text = "BUCLE WHILE Y DO WHILE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(559, 156);
            label3.Name = "label3";
            label3.Size = new Size(189, 28);
            label3.TabIndex = 5;
            label3.Text = "lngresa un numero";
            // 
            // txtDo
            // 
            txtDo.Location = new Point(534, 196);
            txtDo.Name = "txtDo";
            txtDo.Size = new Size(245, 34);
            txtDo.TabIndex = 6;
            // 
            // btnDo
            // 
            btnDo.Location = new Point(613, 245);
            btnDo.Name = "btnDo";
            btnDo.Size = new Size(94, 39);
            btnDo.TabIndex = 7;
            btnDo.Text = "Ver";
            btnDo.UseVisualStyleBackColor = true;
            btnDo.Click += btnDo_Click;
            // 
            // listDo
            // 
            listDo.FormattingEnabled = true;
            listDo.ItemHeight = 28;
            listDo.Location = new Point(534, 290);
            listDo.Name = "listDo";
            listDo.Size = new Size(245, 172);
            listDo.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlueViolet;
            ClientSize = new Size(1200, 630);
            Controls.Add(listDo);
            Controls.Add(btnDo);
            Controls.Add(txtDo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnWhile);
            Controls.Add(txtWhile);
            Controls.Add(label1);
            Controls.Add(listWhile);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listWhile;
        private Label label1;
        private TextBox txtWhile;
        private Button btnWhile;
        private Label label2;
        private Label label3;
        private TextBox txtDo;
        private Button btnDo;
        private ListBox listDo;
    }
}