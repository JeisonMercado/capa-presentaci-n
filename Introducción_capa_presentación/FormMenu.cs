using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Introducción_capa_presentación
{
    public partial class FormMenu : System.Windows.Forms.Form
    {
        public FormMenu()
        {
            InitializeComponent();

        }
        private void btnEditor_Click(object sender, EventArgs e)
        {
            FormEditor formEditor = new FormEditor();
            formEditor.ShowDialog();
        }

        private void btnPaint_Click(object sender, EventArgs e)
        {
            FormPaint formPaint = new FormPaint();
            formPaint.ShowDialog();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            FormCalculadora formCalculadora = new FormCalculadora();
            formCalculadora.ShowDialog();
        }
    }
}

