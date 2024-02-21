namespace Bucles_Anidados
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
            this.listTablas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listTablas
            // 
            this.listTablas.FormattingEnabled = true;
            this.listTablas.ItemHeight = 15;
            this.listTablas.Location = new System.Drawing.Point(55, 58);
            this.listTablas.Name = "listTablas";
            this.listTablas.Size = new System.Drawing.Size(263, 244);
            this.listTablas.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 373);
            this.Controls.Add(this.listTablas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listTablas;
    }
}