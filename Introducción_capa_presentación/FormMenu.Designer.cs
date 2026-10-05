namespace Introducción_capa_presentación
{
    partial class FormMenu
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
            this.btnEditor = new System.Windows.Forms.Button();
            this.btnPaint = new System.Windows.Forms.Button();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEditor
            // 
            this.btnEditor.Location = new System.Drawing.Point(339, 121);
            this.btnEditor.Name = "btnEditor";
            this.btnEditor.Size = new System.Drawing.Size(148, 23);
            this.btnEditor.TabIndex = 0;
            this.btnEditor.Text = "Editor de Texto.";
            this.btnEditor.UseVisualStyleBackColor = true;
            this.btnEditor.Click += new System.EventHandler(this.btnEditor_Click);
            // 
            // btnPaint
            // 
            this.btnPaint.Location = new System.Drawing.Point(339, 67);
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.Size = new System.Drawing.Size(148, 23);
            this.btnPaint.TabIndex = 1;
            this.btnPaint.Text = "Paint personalizado";
            this.btnPaint.UseVisualStyleBackColor = true;
            this.btnPaint.Click += new System.EventHandler(this.btnPaint_Click);
            // 
            // btnCalculator
            // 
            this.btnCalculator.Location = new System.Drawing.Point(339, 187);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(148, 23);
            this.btnCalculator.TabIndex = 2;
            this.btnCalculator.Text = "Calculadora";
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.btnPaint);
            this.Controls.Add(this.btnEditor);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditor;
        private System.Windows.Forms.Button btnPaint;
        private System.Windows.Forms.Button btnCalculator;
    }
}

