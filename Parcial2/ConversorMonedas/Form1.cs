using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ConversorMonedas
{
    public partial class Form1 : Form
    {
        private const double TASA_EURO_A_DOLAR = 1.17;
        private const double TASA_DOLAR_A_PESO = 4258;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (dgvHistorial != null)
            {
                dgvHistorial.ReadOnly = true;
                dgvHistorial.AllowUserToAddRows = false;
            }
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                double euro = 0, dolar = 0, peso = 0;

                // Validar que solo haya un campo lleno
                int camposLlenos = new[] { txtEuro.Text, txtDolar.Text, txtPeso.Text }
                    .Count(campo => !string.IsNullOrWhiteSpace(campo));

                if (camposLlenos != 1)
                {
                    MessageBox.Show("Ingrese exactamente un valor a convertir.", "Advertencia",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar que el valor sea numérico y positivo
                if (!string.IsNullOrWhiteSpace(txtEuro.Text))
                {
                    if (!EsNumeroValido(txtEuro.Text))
                    {
                        MessageBox.Show("Ingrese un valor numérico válido para Euros.", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    euro = double.Parse(txtEuro.Text);
                    dolar = euro * TASA_EURO_A_DOLAR;
                    peso = dolar * TASA_DOLAR_A_PESO;
                }
                else if (!string.IsNullOrWhiteSpace(txtDolar.Text))
                {
                    if (!EsNumeroValido(txtDolar.Text))
                    {
                        MessageBox.Show("Ingrese un valor numérico válido para Dólares.", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    dolar = double.Parse(txtDolar.Text);
                    euro = dolar / TASA_EURO_A_DOLAR;
                    peso = dolar * TASA_DOLAR_A_PESO;
                }
                else if (!string.IsNullOrWhiteSpace(txtPeso.Text))
                {
                    if (!EsNumeroValido(txtPeso.Text))
                    {
                        MessageBox.Show("Ingrese un valor numérico válido para Pesos.", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    peso = double.Parse(txtPeso.Text);
                    dolar = peso / TASA_DOLAR_A_PESO;
                    euro = dolar / TASA_EURO_A_DOLAR;
                }

                // Mostrar resultados formateados
                txtEuro.Text = euro.ToString("N2");
                txtDolar.Text = dolar.ToString("N2");
                txtPeso.Text = peso.ToString("N2");

                // Agregar al historial
                if (dgvHistorial != null)
                {
                    dgvHistorial.Rows.Add(euro.ToString("N2"), dolar.ToString("N2"),
                                        peso.ToString("N2"), DateTime.Now.ToString("g"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool EsNumeroValido(string texto)
        {
            return double.TryParse(texto, out double resultado) && resultado >= 0;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEuro.Clear();
            txtDolar.Clear();
            txtPeso.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtEuro.Text) ||
                    string.IsNullOrWhiteSpace(txtDolar.Text) ||
                    string.IsNullOrWhiteSpace(txtPeso.Text))
                {
                    MessageBox.Show("Primero realice una conversión antes de guardar.", "Advertencia",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!double.TryParse(txtEuro.Text, out double euro) ||
                    !double.TryParse(txtDolar.Text, out double dolar) ||
                    !double.TryParse(txtPeso.Text, out double peso))
                {
                    MessageBox.Show("Los valores de conversión no son válidos.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                GuardarEnBD(euro, dolar, peso);
                MessageBox.Show("Conversión guardada exitosamente en la base de datos.", "Éxito",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar en la base de datos: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarEnBD(double euro, double dolar, double peso)
        {
            try
            {
                string connectionString = @"Server=.\sqlexpress;Database=ConversorDB;Trusted_Connection=True;";
                string sqlInsert = "INSERT INTO HistorialConversiones (Euro, Dolar, Peso, Fecha) VALUES (@Euro, @Dolar, @Peso, @Fecha)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(sqlInsert, conn))
                {
                    cmd.Parameters.AddWithValue("@Euro", euro);
                    cmd.Parameters.AddWithValue("@Dolar", dolar);
                    cmd.Parameters.AddWithValue("@Peso", peso);
                    cmd.Parameters.AddWithValue("@Fecha", DateTime.Now);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar en base de datos: " + ex.Message);
            }
        }

        private void txtEuro_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números, punto decimal y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtDolar_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtEuro_KeyPress(sender, e);
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtEuro_KeyPress(sender, e);
        }
    }
}