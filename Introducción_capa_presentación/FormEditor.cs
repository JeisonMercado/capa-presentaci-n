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
    public partial class FormEditor : Form
    {
        public FormEditor()
        {
            InitializeComponent();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfdGuardar.Title = "Guardar archivo de texto";
            sfdGuardar.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            sfdGuardar.DefaultExt = ".txt";
            
            if (sfdGuardar.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    String rutaArchivo = sfdGuardar.FileName;

                    System.IO.File.WriteAllText(rutaArchivo, txtContent.Text);
                    MessageBox.Show
                        (
                        "Archivo guardado exitosamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                catch(Exception ex)
                {
                    MessageBox.Show
                        (
                        "Error al guardar el archivo: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }
    }
}
