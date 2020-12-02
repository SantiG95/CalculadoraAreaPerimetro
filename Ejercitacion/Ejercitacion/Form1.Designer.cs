namespace Ejercitacion
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
            this.baseBox = new System.Windows.Forms.TextBox();
            this.alturaBox = new System.Windows.Forms.TextBox();
            this.baseLabel = new System.Windows.Forms.Label();
            this.alturaLabel = new System.Windows.Forms.Label();
            this.formaBox = new System.Windows.Forms.ComboBox();
            this.operacionBox = new System.Windows.Forms.ComboBox();
            this.forma = new System.Windows.Forms.Label();
            this.operacion = new System.Windows.Forms.Label();
            this.calcular = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.Label();
            this.faltanDatos = new System.Windows.Forms.Label();
            this.operacionLabel = new System.Windows.Forms.Label();
            this.formaPreviewBox = new System.Windows.Forms.PictureBox();
            this.reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.formaPreviewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // baseBox
            // 
            this.baseBox.AllowDrop = true;
            this.baseBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseBox.Location = new System.Drawing.Point(40, 161);
            this.baseBox.Name = "baseBox";
            this.baseBox.Size = new System.Drawing.Size(121, 30);
            this.baseBox.TabIndex = 0;
            this.baseBox.Text = "\r\n";
            this.baseBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.baseBox.Visible = false;
            this.baseBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.limitadorInput);
            // 
            // alturaBox
            // 
            this.alturaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alturaBox.Location = new System.Drawing.Point(220, 161);
            this.alturaBox.Name = "alturaBox";
            this.alturaBox.Size = new System.Drawing.Size(121, 30);
            this.alturaBox.TabIndex = 1;
            this.alturaBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.alturaBox.Visible = false;
            this.alturaBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.limitadorInput);
            // 
            // baseLabel
            // 
            this.baseLabel.AutoSize = true;
            this.baseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseLabel.Location = new System.Drawing.Point(67, 127);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(57, 25);
            this.baseLabel.TabIndex = 2;
            this.baseLabel.Text = "Base";
            this.baseLabel.Visible = false;
            // 
            // alturaLabel
            // 
            this.alturaLabel.AutoSize = true;
            this.alturaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alturaLabel.Location = new System.Drawing.Point(254, 127);
            this.alturaLabel.Name = "alturaLabel";
            this.alturaLabel.Size = new System.Drawing.Size(63, 25);
            this.alturaLabel.TabIndex = 3;
            this.alturaLabel.Text = "Altura";
            this.alturaLabel.Visible = false;
            // 
            // formaBox
            // 
            this.formaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formaBox.FormattingEnabled = true;
            this.formaBox.Items.AddRange(new object[] {
            "Rectangulo",
            "Cuadrado",
            "Circulo",
            "Triangulo"});
            this.formaBox.Location = new System.Drawing.Point(40, 64);
            this.formaBox.Name = "formaBox";
            this.formaBox.Size = new System.Drawing.Size(121, 33);
            this.formaBox.TabIndex = 4;
            this.formaBox.SelectionChangeCommitted += new System.EventHandler(this.formaBox_SelectionChangeCommitted);
            // 
            // operacionBox
            // 
            this.operacionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operacionBox.FormattingEnabled = true;
            this.operacionBox.Items.AddRange(new object[] {
            "Perimetro",
            "Area"});
            this.operacionBox.Location = new System.Drawing.Point(220, 64);
            this.operacionBox.Name = "operacionBox";
            this.operacionBox.Size = new System.Drawing.Size(121, 33);
            this.operacionBox.TabIndex = 5;
            this.operacionBox.SelectionChangeCommitted += new System.EventHandler(this.operacionBox_SelectionChangeCommitted);
            // 
            // forma
            // 
            this.forma.AutoSize = true;
            this.forma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forma.Location = new System.Drawing.Point(67, 30);
            this.forma.Name = "forma";
            this.forma.Size = new System.Drawing.Size(68, 25);
            this.forma.TabIndex = 6;
            this.forma.Text = "Forma";
            // 
            // operacion
            // 
            this.operacion.AutoSize = true;
            this.operacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operacion.Location = new System.Drawing.Point(228, 30);
            this.operacion.Name = "operacion";
            this.operacion.Size = new System.Drawing.Size(103, 25);
            this.operacion.TabIndex = 7;
            this.operacion.Text = "Operacion";
            // 
            // calcular
            // 
            this.calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcular.Location = new System.Drawing.Point(220, 226);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(121, 50);
            this.calcular.TabIndex = 8;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.MouseClick += new System.Windows.Forms.MouseEventHandler(this.calcular_MouseClick);
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(338, 300);
            this.resultado.Name = "resultado";
            this.resultado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.resultado.Size = new System.Drawing.Size(0, 46);
            this.resultado.TabIndex = 9;
            this.resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // faltanDatos
            // 
            this.faltanDatos.AutoSize = true;
            this.faltanDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faltanDatos.ForeColor = System.Drawing.Color.Red;
            this.faltanDatos.Location = new System.Drawing.Point(32, 279);
            this.faltanDatos.Name = "faltanDatos";
            this.faltanDatos.Size = new System.Drawing.Size(527, 92);
            this.faltanDatos.TabIndex = 11;
            this.faltanDatos.Text = "Completa todos los campos,\r\npor favor";
            this.faltanDatos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.faltanDatos.Visible = false;
            // 
            // operacionLabel
            // 
            this.operacionLabel.AutoSize = true;
            this.operacionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operacionLabel.Location = new System.Drawing.Point(86, 300);
            this.operacionLabel.Name = "operacionLabel";
            this.operacionLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.operacionLabel.Size = new System.Drawing.Size(0, 46);
            this.operacionLabel.TabIndex = 12;
            this.operacionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // formaPreviewBox
            // 
            this.formaPreviewBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.formaPreviewBox.Image = global::Ejercitacion.Properties.Resources.Nada;
            this.formaPreviewBox.Location = new System.Drawing.Point(375, 30);
            this.formaPreviewBox.Name = "formaPreviewBox";
            this.formaPreviewBox.Size = new System.Drawing.Size(200, 200);
            this.formaPreviewBox.TabIndex = 13;
            this.formaPreviewBox.TabStop = false;
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(40, 226);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(121, 50);
            this.reset.TabIndex = 14;
            this.reset.Text = "Resetear";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.MouseClick += new System.Windows.Forms.MouseEventHandler(this.reset_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 377);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.formaPreviewBox);
            this.Controls.Add(this.operacionLabel);
            this.Controls.Add(this.faltanDatos);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.operacion);
            this.Controls.Add(this.forma);
            this.Controls.Add(this.operacionBox);
            this.Controls.Add(this.formaBox);
            this.Controls.Add(this.alturaLabel);
            this.Controls.Add(this.baseLabel);
            this.Controls.Add(this.alturaBox);
            this.Controls.Add(this.baseBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Perimetros y Areas";
            ((System.ComponentModel.ISupportInitialize)(this.formaPreviewBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox baseBox;
        private System.Windows.Forms.TextBox alturaBox;
        private System.Windows.Forms.Label baseLabel;
        private System.Windows.Forms.Label alturaLabel;
        private System.Windows.Forms.ComboBox formaBox;
        private System.Windows.Forms.ComboBox operacionBox;
        private System.Windows.Forms.Label forma;
        private System.Windows.Forms.Label operacion;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Label faltanDatos;
        private System.Windows.Forms.Label operacionLabel;
        private System.Windows.Forms.PictureBox formaPreviewBox;
        private System.Windows.Forms.Button reset;
    }
}

