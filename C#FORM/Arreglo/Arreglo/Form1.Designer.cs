namespace Arreglo
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
            listArreglo = new ListBox();
            SuspendLayout();
            // 
            // listArreglo
            // 
            listArreglo.BackColor = Color.LightCoral;
            listArreglo.ForeColor = SystemColors.MenuText;
            listArreglo.FormattingEnabled = true;
            listArreglo.ItemHeight = 20;
            listArreglo.Location = new Point(256, 122);
            listArreglo.Name = "listArreglo";
            listArreglo.Size = new Size(183, 184);
            listArreglo.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(listArreglo);
            ForeColor = SystemColors.ActiveCaption;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listArreglo;
    }
}