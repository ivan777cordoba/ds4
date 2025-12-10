using System;
using System.Windows.Forms;

namespace Laboratorio121
{
    public partial class Form1 : Form
    {
        private Distancia calculador;

        public Form1()
        {
            InitializeComponent();
            calculador = new Distancia();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double velocidad = double.Parse(txtVelocidad.Text);
                double tiempo = double.Parse(txtTiempo.Text);

                if (calculador.ValidarDatos(velocidad, tiempo))
                {
                    double distancia = calculador.CalcularDistancia(velocidad, tiempo);
                    txtDistancia.Text = distancia.ToString("F2") + " km";
                }
                else
                {
                    MessageBox.Show("La velocidad y el tiempo deben ser valores positivos.",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingrese valores numéricos válidos.",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtVelocidad.Clear();
            txtTiempo.Clear();
            txtDistancia.Clear();
            txtVelocidad.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}