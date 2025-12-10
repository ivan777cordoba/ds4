using System;
using System.Windows.Forms;

namespace Laboratorio123
{
    public partial class Form1 : Form
    {
        private Triangulo calculador;

        public Form1()
        {
            InitializeComponent();
            calculador = new Triangulo();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double lado1 = double.Parse(txtLado1.Text);
                double lado2 = double.Parse(txtLado2.Text);
                double lado3 = double.Parse(txtLado3.Text);

                if (calculador.EsTrianguloValido(lado1, lado2, lado3))
                {
                    double semiperimetro = calculador.CalcularSemiperimetro(lado1, lado2, lado3);
                    double area = calculador.CalcularArea(lado1, lado2, lado3);

                    txtSemiperimetro.Text = semiperimetro.ToString("F2");
                    txtArea.Text = area.ToString("F2");
                }
                else
                {
                    MessageBox.Show("Los lados no forman un triángulo válido. " +
                                  "Asegúrese que:\n1. Todos los lados sean positivos\n" +
                                  "2. La suma de dos lados sea mayor que el tercero",
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
            txtLado1.Clear();
            txtLado2.Clear();
            txtLado3.Clear();
            txtSemiperimetro.Clear();
            txtArea.Clear();
            txtLado1.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}