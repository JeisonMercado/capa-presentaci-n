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
    public partial class FormCalculadora : Form
    {
        private double primerNumero = 0;
        private String operador = "";
        private Boolean esNuevoNumero = true;
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if (esNuevoNumero)
            {
                txtPantalla.Text = "";
                esNuevoNumero = false;
            }
            if (txtPantalla.Text.Contains(".") && boton.Text == ".")
            {
                return;
            }
        txtPantalla.Text += boton.Text;
        }

        private void btnOperacion_Click(object sender, EventArgs e)
        {
                Button boton = (Button)sender;
                primerNumero = Convert.ToDouble(txtPantalla.Text);
                operador = boton.Text;
                esNuevoNumero = true;        
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            double segundoNumero = Convert.ToDouble(txtPantalla.Text);
            double resultado = 0;

            switch(operador)
            {
                case "+": 
                    resultado = primerNumero + segundoNumero;
                    break;
                case "-":
                    resultado = primerNumero - segundoNumero;
                    break;
                case "x":
                    resultado = primerNumero * segundoNumero;
                    break;
                case "/":
                    if(segundoNumero == 0 || primerNumero == 0)
                    {
                        MessageBox.Show("No se puede dividir por cero");
                        btnAc.PerformClick();
                        return;
                    }
                    resultado = primerNumero / segundoNumero;
                    break;

                default:
                    return;
            }
            txtPantalla.Text = resultado.ToString();
            primerNumero = resultado;
            esNuevoNumero = true;
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "0";
            primerNumero = 0;
            operador = "";
            esNuevoNumero = true;
        }
    }
}
