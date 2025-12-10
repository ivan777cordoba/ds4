using System;
using System.Windows.Forms;

namespace Laboratorio122
{
    public partial class Form1 : Form
    {
        private Promedio calculador;

        public Form1()
        {
            InitializeComponent();
            calculador = new Promedio();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double nota1 = double.Parse(txtNota1.Text);
                double nota2 = double.Parse(txtNota2.Text);
                double nota3 = double.Parse(txtNota3.Text);

                // Validar que las notas estén entre 0 y 10
                if (nota1 >= 0 && nota1 <= 10 &&
                    nota2 >= 0 && nota2 <= 10 &&
                    nota3 >= 0 && nota3 <= 10)
                {
                    double promedio = calculador.CalcularPromedio(nota1, nota2, nota3);
                    string estado = calculador.ObtenerEstado(promedio);

                    txtPromedio.Text = promedio.ToString("F2");
                    lblEstado.Text = $"Estado: {estado}";
                }
                else
                {
                    MessageBox.Show("Las notas deben estar entre 0 y 10.",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingrese valores numéricos válidos.",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtPromedio.Clear();
            lblEstado.Text = "Estado:";
            txtNota1.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}