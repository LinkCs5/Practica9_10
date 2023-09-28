namespace Actividad_9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.valor_1 = new System.Windows.Forms.TextBox();
            this.valor_3 = new System.Windows.Forms.TextBox();
            this.valor_2 = new System.Windows.Forms.TextBox();
            this.valor_4 = new System.Windows.Forms.TextBox();
            this.valor_8 = new System.Windows.Forms.TextBox();
            this.valor_6 = new System.Windows.Forms.TextBox();
            this.valor_7 = new System.Windows.Forms.TextBox();
            this.valor_5 = new System.Windows.Forms.TextBox();
            this.boton_calcular = new System.Windows.Forms.Button();
            this.respuesta = new System.Windows.Forms.TextBox();
            this.respuestaMulti = new System.Windows.Forms.TextBox();
            this.respuestaDivi = new System.Windows.Forms.TextBox();
            this.respuestaResta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.limpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // valor_1
            // 
            this.valor_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.valor_1.Location = new System.Drawing.Point(80, 65);
            this.valor_1.Name = "valor_1";
            this.valor_1.Size = new System.Drawing.Size(100, 20);
            this.valor_1.TabIndex = 0;
            this.valor_1.TextChanged += new System.EventHandler(this.valor_1_TextChanged);
            // 
            // valor_3
            // 
            this.valor_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.valor_3.Location = new System.Drawing.Point(80, 102);
            this.valor_3.Name = "valor_3";
            this.valor_3.Size = new System.Drawing.Size(100, 20);
            this.valor_3.TabIndex = 1;
            // 
            // valor_2
            // 
            this.valor_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.valor_2.Location = new System.Drawing.Point(199, 65);
            this.valor_2.Name = "valor_2";
            this.valor_2.Size = new System.Drawing.Size(100, 20);
            this.valor_2.TabIndex = 2;
            // 
            // valor_4
            // 
            this.valor_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.valor_4.Location = new System.Drawing.Point(199, 102);
            this.valor_4.Name = "valor_4";
            this.valor_4.Size = new System.Drawing.Size(100, 20);
            this.valor_4.TabIndex = 3;
            // 
            // valor_8
            // 
            this.valor_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.valor_8.Location = new System.Drawing.Point(513, 102);
            this.valor_8.Name = "valor_8";
            this.valor_8.Size = new System.Drawing.Size(100, 20);
            this.valor_8.TabIndex = 7;
            // 
            // valor_6
            // 
            this.valor_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.valor_6.Location = new System.Drawing.Point(513, 65);
            this.valor_6.Name = "valor_6";
            this.valor_6.Size = new System.Drawing.Size(100, 20);
            this.valor_6.TabIndex = 6;
            // 
            // valor_7
            // 
            this.valor_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.valor_7.Location = new System.Drawing.Point(394, 102);
            this.valor_7.Name = "valor_7";
            this.valor_7.Size = new System.Drawing.Size(100, 20);
            this.valor_7.TabIndex = 5;
            // 
            // valor_5
            // 
            this.valor_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.valor_5.Location = new System.Drawing.Point(394, 65);
            this.valor_5.Name = "valor_5";
            this.valor_5.Size = new System.Drawing.Size(100, 20);
            this.valor_5.TabIndex = 4;
            // 
            // boton_calcular
            // 
            this.boton_calcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.boton_calcular.Location = new System.Drawing.Point(661, 65);
            this.boton_calcular.Name = "boton_calcular";
            this.boton_calcular.Size = new System.Drawing.Size(75, 23);
            this.boton_calcular.TabIndex = 8;
            this.boton_calcular.Text = "Calcular";
            this.boton_calcular.UseVisualStyleBackColor = false;
            this.boton_calcular.Click += new System.EventHandler(this.CalcularBotton_Click);
            // 
            // respuesta
            // 
            this.respuesta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.respuesta.Location = new System.Drawing.Point(80, 194);
            this.respuesta.Multiline = true;
            this.respuesta.Name = "respuesta";
            this.respuesta.Size = new System.Drawing.Size(219, 20);
            this.respuesta.TabIndex = 16;
            this.respuesta.TextChanged += new System.EventHandler(this.respuesta_TextChanged);
            // 
            // respuestaMulti
            // 
            this.respuestaMulti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.respuestaMulti.Location = new System.Drawing.Point(394, 243);
            this.respuestaMulti.Multiline = true;
            this.respuestaMulti.Name = "respuestaMulti";
            this.respuestaMulti.Size = new System.Drawing.Size(219, 20);
            this.respuestaMulti.TabIndex = 17;
            // 
            // respuestaDivi
            // 
            this.respuestaDivi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.respuestaDivi.Location = new System.Drawing.Point(394, 345);
            this.respuestaDivi.Multiline = true;
            this.respuestaDivi.Name = "respuestaDivi";
            this.respuestaDivi.Size = new System.Drawing.Size(219, 20);
            this.respuestaDivi.TabIndex = 18;
            // 
            // respuestaResta
            // 
            this.respuestaResta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.respuestaResta.Location = new System.Drawing.Point(80, 294);
            this.respuestaResta.Multiline = true;
            this.respuestaResta.Name = "respuestaResta";
            this.respuestaResta.Size = new System.Drawing.Size(219, 20);
            this.respuestaResta.TabIndex = 19;
            this.respuestaResta.TextChanged += new System.EventHandler(this.respuestaResta_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(77, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "La suma es:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(391, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "La multiplicacion es:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(77, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "La resta es:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(391, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "La division es:";
            // 
            // limpiar
            // 
            this.limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.limpiar.Location = new System.Drawing.Point(661, 345);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 24;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = false;
            this.limpiar.Click += new System.EventHandler(this.LimpiarBotton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.respuestaResta);
            this.Controls.Add(this.respuestaDivi);
            this.Controls.Add(this.respuestaMulti);
            this.Controls.Add(this.respuesta);
            this.Controls.Add(this.boton_calcular);
            this.Controls.Add(this.valor_8);
            this.Controls.Add(this.valor_6);
            this.Controls.Add(this.valor_7);
            this.Controls.Add(this.valor_5);
            this.Controls.Add(this.valor_4);
            this.Controls.Add(this.valor_2);
            this.Controls.Add(this.valor_3);
            this.Controls.Add(this.valor_1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox valor_1;
        private System.Windows.Forms.TextBox valor_3;
        private System.Windows.Forms.TextBox valor_2;
        private System.Windows.Forms.TextBox valor_4;
        private System.Windows.Forms.TextBox valor_8;
        private System.Windows.Forms.TextBox valor_6;
        private System.Windows.Forms.TextBox valor_7;
        private System.Windows.Forms.TextBox valor_5;
        private System.Windows.Forms.Button boton_calcular;
        private System.Windows.Forms.TextBox respuesta;
        private System.Windows.Forms.TextBox respuestaMulti;
        private System.Windows.Forms.TextBox respuestaDivi;
        private System.Windows.Forms.TextBox respuestaResta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button limpiar;
    }
}

