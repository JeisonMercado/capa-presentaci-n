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
    public partial class FormPaint : Form
    {
        public FormPaint()
        {
            InitializeComponent();
        }
        private void cambiarColor_Click(object sender, EventArgs e)
        {
            Button botonPresionado = (Button)sender;
            panelLienzo.BackColor = botonPresionado.BackColor;
        }
    }
}
