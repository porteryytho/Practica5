namespace Practica5
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.suma = new System.Windows.Forms.Button();
            this.res = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(158, 25);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(219, 20);
            this.num1.TabIndex = 0;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(158, 65);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(219, 20);
            this.num2.TabIndex = 1;
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(158, 140);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(219, 20);
            this.total.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "1° NUMERO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "2° NUMERO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "TOTAL";
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(19, 235);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(74, 21);
            this.suma.TabIndex = 6;
            this.suma.Text = "SUMA";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.suma_Click);
            // 
            // res
            // 
            this.res.Location = new System.Drawing.Point(115, 235);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(74, 21);
            this.res.TabIndex = 7;
            this.res.Text = "RESTA";
            this.res.UseVisualStyleBackColor = true;
            this.res.Click += new System.EventHandler(this.res_Click);
            // 
            // mul
            // 
            this.mul.Location = new System.Drawing.Point(209, 235);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(112, 21);
            this.mul.TabIndex = 8;
            this.mul.Text = "MULTIPLICACION";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.Click += new System.EventHandler(this.mul_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(342, 235);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(74, 21);
            this.div.TabIndex = 9;
            this.div.Text = "DIVICION";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 20);
            this.button1.TabIndex = 10;
            this.button1.Text = "LIMPIAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 285);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.res);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.total);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button res;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button button1;
    }
}

