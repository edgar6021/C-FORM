namespace Condicional_if_else
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnEvaluacion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(75, 121);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(213, 23);
            this.txtNumero.TabIndex = 0;
            // 
            // btnEvaluacion
            // 
            this.btnEvaluacion.Location = new System.Drawing.Point(75, 209);
            this.btnEvaluacion.Name = "btnEvaluacion";
            this.btnEvaluacion.Size = new System.Drawing.Size(213, 48);
            this.btnEvaluacion.TabIndex = 1;
            this.btnEvaluacion.Text = "Evaluacion Numero Par";
            this.btnEvaluacion.UseVisualStyleBackColor = true;
            this.btnEvaluacion.Click += new System.EventHandler(this.btnEvaluacion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Evaluacion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 404);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEvaluacion);
            this.Controls.Add(this.txtNumero);
            this.Name = "Form1";
            this.Text = "Evaluacion Numero Par";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNumero;
        private Button btnEvaluacion;
        private Label label1;
    }
}