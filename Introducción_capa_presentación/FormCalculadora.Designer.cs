namespace Introducción_capa_presentación
{
    partial class FormCalculadora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtPantalla = new System.Windows.Forms.TextBox();
            this.btnCambioSigno = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnNueve = new System.Windows.Forms.Button();
            this.btnAc = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSiete = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnCero = new System.Windows.Forms.Button();
            this.btnUno = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnPorcentaje = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtPantalla
            // 
            this.txtPantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPantalla.Location = new System.Drawing.Point(194, 124);
            this.txtPantalla.Name = "txtPantalla";
            this.txtPantalla.ReadOnly = true;
            this.txtPantalla.Size = new System.Drawing.Size(116, 35);
            this.txtPantalla.TabIndex = 1;
            this.txtPantalla.Text = "0";
            this.txtPantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCambioSigno
            // 
            this.btnCambioSigno.Location = new System.Drawing.Point(97, 294);
            this.btnCambioSigno.Name = "btnCambioSigno";
            this.btnCambioSigno.Size = new System.Drawing.Size(75, 23);
            this.btnCambioSigno.TabIndex = 2;
            this.btnCambioSigno.UseVisualStyleBackColor = true;
            // 
            // btnSeis
            // 
            this.btnSeis.Location = new System.Drawing.Point(259, 236);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(75, 23);
            this.btnSeis.TabIndex = 3;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnTres
            // 
            this.btnTres.Location = new System.Drawing.Point(259, 265);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(75, 23);
            this.btnTres.TabIndex = 4;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.Location = new System.Drawing.Point(178, 236);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(75, 23);
            this.btnCinco.TabIndex = 5;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnOcho
            // 
            this.btnOcho.Location = new System.Drawing.Point(178, 207);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(75, 23);
            this.btnOcho.TabIndex = 6;
            this.btnOcho.Text = "8";
            this.btnOcho.UseVisualStyleBackColor = true;
            this.btnOcho.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnDos
            // 
            this.btnDos.Location = new System.Drawing.Point(178, 265);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(75, 23);
            this.btnDos.TabIndex = 7;
            this.btnDos.Text = "2";
            this.btnDos.UseVisualStyleBackColor = true;
            this.btnDos.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnNueve
            // 
            this.btnNueve.Location = new System.Drawing.Point(259, 207);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(75, 23);
            this.btnNueve.TabIndex = 8;
            this.btnNueve.Text = "9";
            this.btnNueve.UseVisualStyleBackColor = true;
            this.btnNueve.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnAc
            // 
            this.btnAc.Location = new System.Drawing.Point(97, 178);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(75, 23);
            this.btnAc.TabIndex = 9;
            this.btnAc.Text = "AC";
            this.btnAc.UseVisualStyleBackColor = true;
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(178, 178);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 10;
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnSiete
            // 
            this.btnSiete.Location = new System.Drawing.Point(97, 207);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(75, 23);
            this.btnSiete.TabIndex = 11;
            this.btnSiete.Text = "7";
            this.btnSiete.UseVisualStyleBackColor = true;
            this.btnSiete.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnCuatro
            // 
            this.btnCuatro.Location = new System.Drawing.Point(97, 236);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(75, 23);
            this.btnCuatro.TabIndex = 12;
            this.btnCuatro.Text = "4";
            this.btnCuatro.UseVisualStyleBackColor = true;
            this.btnCuatro.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnCero
            // 
            this.btnCero.Location = new System.Drawing.Point(178, 294);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(75, 23);
            this.btnCero.TabIndex = 13;
            this.btnCero.Text = "0";
            this.btnCero.UseVisualStyleBackColor = true;
            this.btnCero.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnUno
            // 
            this.btnUno.Location = new System.Drawing.Point(97, 265);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(75, 23);
            this.btnUno.TabIndex = 14;
            this.btnUno.Text = "1";
            this.btnUno.UseVisualStyleBackColor = true;
            this.btnUno.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(340, 236);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(75, 23);
            this.btnResta.TabIndex = 15;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnOperacion_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(340, 178);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 23);
            this.btnDividir.TabIndex = 16;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnOperacion_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(340, 207);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplicar.TabIndex = 17;
            this.btnMultiplicar.Text = "x";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnOperacion_Click);
            // 
            // btnPorcentaje
            // 
            this.btnPorcentaje.Location = new System.Drawing.Point(259, 178);
            this.btnPorcentaje.Name = "btnPorcentaje";
            this.btnPorcentaje.Size = new System.Drawing.Size(75, 23);
            this.btnPorcentaje.TabIndex = 18;
            this.btnPorcentaje.UseVisualStyleBackColor = true;
            // 
            // btnPunto
            // 
            this.btnPunto.Location = new System.Drawing.Point(259, 294);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(75, 23);
            this.btnPunto.TabIndex = 19;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(340, 265);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 23);
            this.btnSuma.TabIndex = 20;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnOperacion_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(340, 294);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(75, 23);
            this.btnIgual.TabIndex = 21;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 450);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnPorcentaje);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnUno);
            this.Controls.Add(this.btnCero);
            this.Controls.Add(this.btnCuatro);
            this.Controls.Add(this.btnSiete);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAc);
            this.Controls.Add(this.btnNueve);
            this.Controls.Add(this.btnDos);
            this.Controls.Add(this.btnOcho);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCambioSigno);
            this.Controls.Add(this.txtPantalla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCalculadora";
            this.Text = "FormCalculadora";
            this.Click += new System.EventHandler(this.btnOperacion_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtPantalla;
        private System.Windows.Forms.Button btnCambioSigno;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnAc;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnPorcentaje;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnIgual;
    }
}