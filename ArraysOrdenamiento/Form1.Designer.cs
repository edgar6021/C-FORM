namespace ArraysOrdenamiento
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
            this.listDesordenado = new System.Windows.Forms.ListBox();
            this.listOrdenado = new System.Windows.Forms.ListBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listDesordenado
            // 
            this.listDesordenado.FormattingEnabled = true;
            this.listDesordenado.ItemHeight = 15;
            this.listDesordenado.Location = new System.Drawing.Point(64, 32);
            this.listDesordenado.Name = "listDesordenado";
            this.listDesordenado.Size = new System.Drawing.Size(158, 244);
            this.listDesordenado.TabIndex = 0;
            // 
            // listOrdenado
            // 
            this.listOrdenado.FormattingEnabled = true;
            this.listOrdenado.ItemHeight = 15;
            this.listOrdenado.Location = new System.Drawing.Point(352, 32);
            this.listOrdenado.Name = "listOrdenado";
            this.listOrdenado.Size = new System.Drawing.Size(167, 244);
            this.listOrdenado.TabIndex = 1;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(64, 310);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(455, 49);
            this.btnOrdenar.TabIndex = 2;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 404);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.listOrdenado);
            this.Controls.Add(this.listDesordenado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listDesordenado;
        private ListBox listOrdenado;
        private Button btnOrdenar;
    }
}