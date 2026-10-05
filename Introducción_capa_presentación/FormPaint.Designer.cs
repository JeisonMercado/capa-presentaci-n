namespace Introducción_capa_presentación
{
    partial class FormPaint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAzul = new System.Windows.Forms.Button();
            this.btnAmarillo = new System.Windows.Forms.Button();
            this.btnNegro = new System.Windows.Forms.Button();
            this.btnVerde = new System.Windows.Forms.Button();
            this.btnRojo = new System.Windows.Forms.Button();
            this.panelLienzo = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAzul);
            this.panel1.Controls.Add(this.btnAmarillo);
            this.panel1.Controls.Add(this.btnNegro);
            this.panel1.Controls.Add(this.btnVerde);
            this.panel1.Controls.Add(this.btnRojo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 70);
            this.panel1.TabIndex = 0;
            // 
            // btnAzul
            // 
            this.btnAzul.BackColor = System.Drawing.Color.Blue;
            this.btnAzul.Location = new System.Drawing.Point(59, 11);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(40, 40);
            this.btnAzul.TabIndex = 4;
            this.btnAzul.UseVisualStyleBackColor = false;
            this.btnAzul.Click += new System.EventHandler(this.cambiarColor_Click);
            // 
            // btnAmarillo
            // 
            this.btnAmarillo.BackColor = System.Drawing.Color.Yellow;
            this.btnAmarillo.Location = new System.Drawing.Point(105, 11);
            this.btnAmarillo.Name = "btnAmarillo";
            this.btnAmarillo.Size = new System.Drawing.Size(40, 40);
            this.btnAmarillo.TabIndex = 3;
            this.btnAmarillo.UseVisualStyleBackColor = false;
            this.btnAmarillo.Click += new System.EventHandler(this.cambiarColor_Click);
            // 
            // btnNegro
            // 
            this.btnNegro.BackColor = System.Drawing.Color.Black;
            this.btnNegro.Location = new System.Drawing.Point(151, 11);
            this.btnNegro.Name = "btnNegro";
            this.btnNegro.Size = new System.Drawing.Size(40, 40);
            this.btnNegro.TabIndex = 2;
            this.btnNegro.UseVisualStyleBackColor = false;
            this.btnNegro.Click += new System.EventHandler(this.cambiarColor_Click);
            // 
            // btnVerde
            // 
            this.btnVerde.BackColor = System.Drawing.Color.Green;
            this.btnVerde.Location = new System.Drawing.Point(197, 11);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(40, 40);
            this.btnVerde.TabIndex = 1;
            this.btnVerde.UseVisualStyleBackColor = false;
            this.btnVerde.Click += new System.EventHandler(this.cambiarColor_Click);
            // 
            // btnRojo
            // 
            this.btnRojo.BackColor = System.Drawing.Color.Red;
            this.btnRojo.Location = new System.Drawing.Point(13, 11);
            this.btnRojo.Name = "btnRojo";
            this.btnRojo.Size = new System.Drawing.Size(40, 40);
            this.btnRojo.TabIndex = 0;
            this.btnRojo.UseVisualStyleBackColor = false;
            this.btnRojo.Click += new System.EventHandler(this.cambiarColor_Click);
            // 
            // panelLienzo
            // 
            this.panelLienzo.BackColor = System.Drawing.SystemColors.Info;
            this.panelLienzo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLienzo.Location = new System.Drawing.Point(0, 70);
            this.panelLienzo.Name = "panelLienzo";
            this.panelLienzo.Size = new System.Drawing.Size(800, 380);
            this.panelLienzo.TabIndex = 1;
            // 
            // FormPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelLienzo);
            this.Controls.Add(this.panel1);
            this.Name = "FormPaint";
            this.Text = "FormPaint";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRojo;
        private System.Windows.Forms.Panel panelLienzo;
        private System.Windows.Forms.Button btnAzul;
        private System.Windows.Forms.Button btnAmarillo;
        private System.Windows.Forms.Button btnNegro;
        private System.Windows.Forms.Button btnVerde;
    }
}