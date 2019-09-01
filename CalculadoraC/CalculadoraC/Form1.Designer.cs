namespace CalculadoraC
{
    partial class Calculadora
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
            this.pantalla = new System.Windows.Forms.TextBox();
            this.limpiar = new System.Windows.Forms.Button();
            this.btnigual = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btndivision = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnmulti = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.btncero = new System.Windows.Forms.Button();
            this.btnsuma = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.raiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pantalla
            // 
            this.pantalla.BackColor = System.Drawing.Color.White;
            this.pantalla.Location = new System.Drawing.Point(12, 33);
            this.pantalla.Name = "pantalla";
            this.pantalla.ReadOnly = true;
            this.pantalla.Size = new System.Drawing.Size(212, 20);
            this.pantalla.TabIndex = 0;
            this.pantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // limpiar
            // 
            this.limpiar.BackColor = System.Drawing.Color.White;
            this.limpiar.Location = new System.Drawing.Point(230, 33);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(70, 20);
            this.limpiar.TabIndex = 1;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = false;
            this.limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // btnigual
            // 
            this.btnigual.BackColor = System.Drawing.Color.White;
            this.btnigual.Location = new System.Drawing.Point(231, 134);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(74, 138);
            this.btnigual.TabIndex = 2;
            this.btnigual.Text = "=";
            this.btnigual.UseVisualStyleBackColor = false;
            this.btnigual.Click += new System.EventHandler(this.Btnigual_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn1.Location = new System.Drawing.Point(10, 86);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(49, 42);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn3.Location = new System.Drawing.Point(120, 86);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(49, 42);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // btndivision
            // 
            this.btndivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btndivision.Location = new System.Drawing.Point(175, 86);
            this.btndivision.Name = "btndivision";
            this.btndivision.Size = new System.Drawing.Size(49, 42);
            this.btndivision.TabIndex = 6;
            this.btndivision.Text = "/";
            this.btndivision.UseVisualStyleBackColor = false;
            this.btndivision.Click += new System.EventHandler(this.Btndivision_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn4.Location = new System.Drawing.Point(10, 134);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(49, 42);
            this.btn4.TabIndex = 7;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn5.Location = new System.Drawing.Point(65, 134);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(49, 42);
            this.btn5.TabIndex = 8;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn6.Location = new System.Drawing.Point(120, 134);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(49, 42);
            this.btn6.TabIndex = 9;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // btnmulti
            // 
            this.btnmulti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnmulti.Location = new System.Drawing.Point(175, 134);
            this.btnmulti.Name = "btnmulti";
            this.btnmulti.Size = new System.Drawing.Size(49, 42);
            this.btnmulti.TabIndex = 10;
            this.btnmulti.Text = "X";
            this.btnmulti.UseVisualStyleBackColor = false;
            this.btnmulti.Click += new System.EventHandler(this.Btnmulti_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn7.Location = new System.Drawing.Point(10, 182);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(49, 42);
            this.btn7.TabIndex = 11;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn8.Location = new System.Drawing.Point(65, 182);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(49, 42);
            this.btn8.TabIndex = 12;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.Button12_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn9.Location = new System.Drawing.Point(120, 182);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(49, 42);
            this.btn9.TabIndex = 13;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // btnresta
            // 
            this.btnresta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnresta.Location = new System.Drawing.Point(175, 182);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(49, 42);
            this.btnresta.TabIndex = 14;
            this.btnresta.Text = "-";
            this.btnresta.UseVisualStyleBackColor = false;
            this.btnresta.Click += new System.EventHandler(this.Btnresta_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button15.Location = new System.Drawing.Point(120, 230);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(49, 42);
            this.button15.TabIndex = 15;
            this.button15.Text = ".";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.Button15_Click);
            // 
            // btncero
            // 
            this.btncero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btncero.Location = new System.Drawing.Point(10, 230);
            this.btncero.Name = "btncero";
            this.btncero.Size = new System.Drawing.Size(104, 42);
            this.btncero.TabIndex = 16;
            this.btncero.Text = "0";
            this.btncero.UseVisualStyleBackColor = false;
            this.btncero.Click += new System.EventHandler(this.Btncero_Click);
            // 
            // btnsuma
            // 
            this.btnsuma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnsuma.Location = new System.Drawing.Point(175, 230);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(49, 42);
            this.btnsuma.TabIndex = 17;
            this.btnsuma.Text = "+";
            this.btnsuma.UseVisualStyleBackColor = false;
            this.btnsuma.Click += new System.EventHandler(this.Btnsuma_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn2.Location = new System.Drawing.Point(65, 86);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(49, 42);
            this.btn2.TabIndex = 18;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // raiz
            // 
            this.raiz.BackColor = System.Drawing.Color.White;
            this.raiz.Location = new System.Drawing.Point(230, 86);
            this.raiz.Name = "raiz";
            this.raiz.Size = new System.Drawing.Size(72, 42);
            this.raiz.TabIndex = 3;
            this.raiz.Text = "raiz";
            this.raiz.UseVisualStyleBackColor = false;
            this.raiz.Click += new System.EventHandler(this.Raiz_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(314, 293);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnsuma);
            this.Controls.Add(this.btncero);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.btnresta);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnmulti);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btndivision);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.raiz);
            this.Controls.Add(this.btnigual);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.pantalla);
            this.Name = "Calculadora";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pantalla;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button btnigual;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btndivision;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnmulti;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnresta;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button btncero;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button raiz;
    }
}

