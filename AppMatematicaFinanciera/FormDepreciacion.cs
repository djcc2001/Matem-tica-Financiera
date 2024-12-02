using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AppMatematicaFinanciera
{
    public partial class FormDepreciacion : Form
    {
        double costo = 0;
        double valor = 0;
        int vida = 0;
        double depreciacion = 0;
        public FormDepreciacion()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtCoto.Text))
            {
                errorProvider.SetError(txtCoto, "Todo los campos deben ser llenados.");
            }
            else
            {
                errorProvider.Clear();
                if (string.IsNullOrWhiteSpace(txtValor.Text))
                {
                    errorProvider.SetError(txtValor, "Todo los campos deben ser llenados.");
                }
                else
                {
                    errorProvider.Clear();
                    if (string.IsNullOrWhiteSpace(txtVida.Text))
                    {
                        errorProvider.SetError(txtVida, "Todo los campos deben ser llenados.");
                    }
                    else
                    {
                        errorProvider.Clear();
                        CalcularDepreciacion();
                        cargarTabla();
                        cargarGrafico();
                    }
                }
            }
        }

        private void CalcularDepreciacion()
        {
            costo = double.Parse(txtCoto.Text);
            valor = double.Parse(txtValor.Text);
            vida = int.Parse(txtVida.Text);

            depreciacion = (costo - valor) / vida;

            txtDepreciacion.Text = depreciacion.ToString("F2");
        }

        private void cargarTabla()
        {
            double sumatoria = 0;
            int i = 0;
            for (int j = 0; j <= vida; j++)
            {
                if (j == 0)
                {
                    dgvDatos.Rows.Add(j, "S/." + (costo - sumatoria).ToString("F2"), "", "");
                }
                else
                {
                    dgvDatos.Rows.Add(j, "S/." + (costo - sumatoria).ToString("F2"), "S/." + depreciacion.ToString("F2"), "S/." + sumatoria.ToString("F2"));
                }

                sumatoria += depreciacion;
            }
        }

        private void cargarGrafico()
        {
            // Limpiar cualquier dato previo del gráfico
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            // Crear un área de gráfico
            var chartArea = new ChartArea("MainArea");
            chart1.ChartAreas.Add(chartArea);

            // Crear una nueva serie para el gráfico de barras
            var series = new Series("Depreciación Anual")
            {
                ChartType = SeriesChartType.Column, // Tipo de gráfico: Barras
                XValueType = ChartValueType.Int32, // Eje X como valores enteros (Años)
                YValueType = ChartValueType.Double, // Eje Y como valores dobles (Valores de Depreciación)
                IsVisibleInLegend = false // Desactiva la leyenda
            };
            chart1.Series.Add(series);

            // Agregar datos al gráfico
            double sumatoria = 0;
            for (int j = 1; j <= vida; j++) // Solo desde el año 1 (excluyendo el año 0 inicial)
            {
                double valorRestante = costo - sumatoria;
                series.Points.AddXY(j, valorRestante);
                sumatoria += depreciacion;
            }

            // Configuración estética opcional
            chart1.Titles.Clear();
            chart1.Titles.Add("Valor en Libros");
            chart1.ChartAreas["MainArea"].AxisX.Title = "Años";
        }


        private void bntLimpiar_Click(object sender, EventArgs e)
        {
            txtCoto.Text = string.Empty;
            txtDepreciacion.Text = string.Empty;
            txtValor.Text = string.Empty;
            txtVida.Text = string.Empty;

            chart1.Series.Clear();
            chart1.Titles.Clear();

            dgvDatos.Rows.Clear();
        }

        private void txtVida_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Valida cada caracter con su respectivo código ASCII
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                errorProvider.SetError(txtVida, "No se admiten letras.");
                e.Handled = true; // Evita que el carácter se muestre en el TextBox
            }
            else
            {
                errorProvider.Clear();
            }
        }
    }
}
