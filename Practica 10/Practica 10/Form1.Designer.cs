namespace Practica_10
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.matrizText = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.TextBox();
            this.calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // matrizText
            // 
            this.matrizText.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.matrizText.Location = new System.Drawing.Point(85, 177);
            this.matrizText.Name = "matrizText";
            this.matrizText.Size = new System.Drawing.Size(100, 20);
            this.matrizText.TabIndex = 0;
            // 
            // resultado
            // 
            this.resultado.BackColor = System.Drawing.Color.Tan;
            this.resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultado.Location = new System.Drawing.Point(473, 68);
            this.resultado.Multiline = true;
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(315, 271);
            this.resultado.TabIndex = 1;
            // 
            // calcular
            // 
            this.calcular.BackColor = System.Drawing.Color.Transparent;
            this.calcular.Location = new System.Drawing.Point(302, 174);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(75, 23);
            this.calcular.TabIndex = 2;
            this.calcular.Text = "calcular";
            this.calcular.UseVisualStyleBackColor = false;
            this.calcular.Click += new System.EventHandler(this.btnGenrarMatriz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.matrizText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox matrizText;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.Button calcular;
    }
}

