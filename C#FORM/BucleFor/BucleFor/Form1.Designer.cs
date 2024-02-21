namespace BucleFor
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
            listFor = new ListBox();
            btnVerFor = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // listFor
            // 
            listFor.BackColor = Color.IndianRed;
            listFor.FormattingEnabled = true;
            listFor.ItemHeight = 20;
            listFor.Location = new Point(211, 78);
            listFor.Name = "listFor";
            listFor.Size = new Size(236, 204);
            listFor.TabIndex = 0;
            listFor.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnVerFor
            // 
            btnVerFor.BackColor = Color.IndianRed;
            btnVerFor.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerFor.Location = new Point(259, 315);
            btnVerFor.Name = "btnVerFor";
            btnVerFor.Size = new Size(94, 53);
            btnVerFor.TabIndex = 1;
            btnVerFor.Text = "Ver";
            btnVerFor.UseVisualStyleBackColor = false;
            btnVerFor.Click += btnVerFor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(180, 9);
            label1.Name = "label1";
            label1.Size = new Size(297, 60);
            label1.TabIndex = 2;
            label1.Text = "Ver Bucle For";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(653, 450);
            Controls.Add(label1);
            Controls.Add(btnVerFor);
            Controls.Add(listFor);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listFor;
        private Button btnVerFor;
        private Label label1;
    }
}