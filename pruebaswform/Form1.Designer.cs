namespace pruebaswform
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
            this.btnSumar = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.BtnMultiplicar = new System.Windows.Forms.Button();
            this.BtnResta = new System.Windows.Forms.Button();
            this.BtnDividir = new System.Windows.Forms.Button();
            this.BtnFactorial = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.btnporcentaje = new System.Windows.Forms.Button();
            this.btnVector = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSumar
            // 
            this.btnSumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumar.Location = new System.Drawing.Point(12, 44);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(124, 39);
            this.btnSumar.TabIndex = 3;
            this.btnSumar.Text = "+";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.BtnSumar_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(327, 75);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 1;
            this.txtNum1.TextChanged += new System.EventHandler(this.TxtNum1_TextChanged);
            this.txtNum1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNum1_KeyDown);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(327, 127);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 2;
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(322, 177);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(120, 30);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Resultado";
            this.lblResultado.Click += new System.EventHandler(this.LblResultado_Click);
            // 
            // BtnMultiplicar
            // 
            this.BtnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMultiplicar.Location = new System.Drawing.Point(12, 108);
            this.BtnMultiplicar.Name = "BtnMultiplicar";
            this.BtnMultiplicar.Size = new System.Drawing.Size(124, 39);
            this.BtnMultiplicar.TabIndex = 5;
            this.BtnMultiplicar.Text = "x";
            this.BtnMultiplicar.UseVisualStyleBackColor = true;
            this.BtnMultiplicar.Click += new System.EventHandler(this.BtnMultiplicar_Click);
            // 
            // BtnResta
            // 
            this.BtnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResta.Location = new System.Drawing.Point(162, 44);
            this.BtnResta.Name = "BtnResta";
            this.BtnResta.Size = new System.Drawing.Size(124, 39);
            this.BtnResta.TabIndex = 4;
            this.BtnResta.Text = "-";
            this.BtnResta.UseVisualStyleBackColor = true;
            this.BtnResta.Click += new System.EventHandler(this.BtnResta_Click);
            // 
            // BtnDividir
            // 
            this.BtnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDividir.Location = new System.Drawing.Point(162, 108);
            this.BtnDividir.Name = "BtnDividir";
            this.BtnDividir.Size = new System.Drawing.Size(124, 39);
            this.BtnDividir.TabIndex = 6;
            this.BtnDividir.Text = "/";
            this.BtnDividir.UseVisualStyleBackColor = true;
            this.BtnDividir.Click += new System.EventHandler(this.BtnDividir_Click);
            // 
            // BtnFactorial
            // 
            this.BtnFactorial.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnFactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFactorial.Location = new System.Drawing.Point(152, 166);
            this.BtnFactorial.Name = "BtnFactorial";
            this.BtnFactorial.Size = new System.Drawing.Size(97, 26);
            this.BtnFactorial.TabIndex = 7;
            this.BtnFactorial.Text = "!";
            this.BtnFactorial.UseVisualStyleBackColor = false;
            this.BtnFactorial.Click += new System.EventHandler(this.BtnFactorial_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(333, 23);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(90, 26);
            this.BtnLimpiar.TabIndex = 9;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // btnporcentaje
            // 
            this.btnporcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnporcentaje.Location = new System.Drawing.Point(49, 166);
            this.btnporcentaje.Name = "btnporcentaje";
            this.btnporcentaje.Size = new System.Drawing.Size(97, 26);
            this.btnporcentaje.TabIndex = 10;
            this.btnporcentaje.Text = "%";
            this.btnporcentaje.UseVisualStyleBackColor = true;
            this.btnporcentaje.Click += new System.EventHandler(this.Btnporcentaje_Click);
            // 
            // btnVector
            // 
            this.btnVector.Location = new System.Drawing.Point(49, 241);
            this.btnVector.Name = "btnVector";
            this.btnVector.Size = new System.Drawing.Size(124, 23);
            this.btnVector.TabIndex = 11;
            this.btnVector.Text = "Analisis de vector";
            this.btnVector.UseVisualStyleBackColor = true;
            this.btnVector.Click += new System.EventHandler(this.BtnVector_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(212, 241);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 12;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(212, 260);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(37, 13);
            this.lblSuma.TabIndex = 13;
            this.lblSuma.Text = "Suma:";
            this.lblSuma.Click += new System.EventHandler(this.LblSuma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 291);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnVector);
            this.Controls.Add(this.btnporcentaje);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnFactorial);
            this.Controls.Add(this.BtnDividir);
            this.Controls.Add(this.BtnResta);
            this.Controls.Add(this.BtnMultiplicar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.btnSumar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button BtnMultiplicar;
        private System.Windows.Forms.Button BtnResta;
        private System.Windows.Forms.Button BtnDividir;
        private System.Windows.Forms.Button BtnFactorial;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button btnporcentaje;
        private System.Windows.Forms.Button btnVector;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblSuma;
    }
}

