using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ChartingSeries = System.Windows.Forms.DataVisualization.Charting.Series;

namespace AppMatematicaFinanciera
{
    public partial class FrmInteresCompuesto : Form
    {
        public FrmInteresCompuesto()
        {
            InitializeComponent();
        }

        private double InteresCompuesto(string periodo, int tiempo, double capital, double tea) {
            double interes = 0;
            if (periodo == "diario")
                interes = capital * (Math.Pow((1 + tea/3600), tiempo) - 1);
            if (periodo == "mensual")
                interes = capital * (Math.Pow((1 + tea/1200), tiempo) - 1);            
            if (periodo == "anual")
                interes = capital * (Math.Pow((1 + tea/100), tiempo) - 1);

            return interes;
        }
        private void Calcular()
        {
            string Periodo = "";
            double capital = double.Parse(txtCapital.Text);
            if (rbtnMensual.Checked)
                Periodo = "mensual";
            else if (rbtnDiario.Checked)
                Periodo = "diario";
            else if (rbtnAnual.Checked)
                Periodo = "anual";
            double tea = double.Parse(txtTEA.Text);
            int tiempo = int.Parse(txtPeriodo.Text);

            double interes = InteresCompuesto(Periodo, tiempo, capital, tea);

            double monto = capital + interes;

            txtInteres.Text = Math.Round(interes, 2).ToString("F2");
            txtMonto.Text = Math.Round(monto, 2).ToString("F2");

            GenerarGrafico();
            GenerarReporte();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCapital.Text))
            {
                errorProvider.SetError(txtCapital, "Todo los campos deben ser llenados.");
            }
            else
            {
                errorProvider.Clear();
                if (!rbtnDiario.Checked && !rbtnMensual.Checked && !rbtnAnual.Checked)
                {
                    errorProvider.SetError(groupBox1, "Debe marcar al menos 1 opción.");
                }
                else
                {
                    errorProvider.Clear();
                    if (string.IsNullOrWhiteSpace(txtTEA.Text))
                    {
                        errorProvider.SetError(txtTEA, "Todo los campos deben ser llenados.");
                    }
                    else
                    {
                        errorProvider.Clear();
                        if (string.IsNullOrWhiteSpace(txtPeriodo.Text))
                        {
                            errorProvider.SetError(txtPeriodo, "Todo los campos deben ser llenados.");
                        }
                        else
                        {
                            errorProvider.Clear();
                            Calcular();
                        }
                    }
                }
            }
        }

        private void bntLimpiar_Click(object sender, EventArgs e)
        {
            txtCapital.Text = string.Empty;
            rbtnMensual.Checked = false;
            rbtnDiario.Checked = false;
            rbtnAnual.Checked = false;
            txtTEA.Text = string.Empty;
            txtPeriodo.Text = string.Empty;
            txtInteres.Text = string.Empty;
            txtMonto.Text = string.Empty;

            chart1.Series.Clear();
            chart1.Titles.Clear();

            dgtvReporte.Rows.Clear();
        }

        private void GenerarGrafico()
        {
            string Periodo = "";
            double capital = double.Parse(txtCapital.Text);
            double tea = double.Parse(txtTEA.Text);
            int tiempo = int.Parse(txtPeriodo.Text);

            if (rbtnMensual.Checked)
                tea = tea / 12;
            else if (rbtnDiario.Checked)
                tea = tea / 360;
            else if (rbtnAnual.Checked)
                tea = tea;

            // Configurar el tipo de gráfico
            chart1.Series.Clear();
            var series = new Series();
            series.ChartType = SeriesChartType.Line;
            chart1.Series.Add(series);
            chart1.Legends.Clear();

            // Calcular y agregar datos al gráfico
            for (int i = 0; i <= tiempo; i++)
            {
                double valorFuturo = capital * Math.Pow(1 + (tea / 100), i);
                series.Points.AddXY(i, valorFuturo);
            }

            // Configurar el título del gráfico
            chart1.Titles.Add("Valor Futuro del Capital");

            // Configurar el eje X para que siempre comience en 0
            chart1.ChartAreas[0].AxisX.Minimum = 0;

            // Configurar etiquetas para los ejes
            chart1.ChartAreas[0].AxisX.Title = "Periodo";
            chart1.ChartAreas[0].AxisY.Title = "Valor Futuro";

            // Configurar el máximo del eje Y basado en el valor futuro calculado
            chart1.ChartAreas[0].AxisY.Maximum = capital * Math.Pow(1 + (tea / 100), tiempo);
        }

        private void GenerarReporte()
        {
            string Periodo = "";
            double capital = double.Parse(txtCapital.Text);
            double tea = double.Parse(txtTEA.Text);
            int tiempo = int.Parse(txtPeriodo.Text);

            // Ajustar TEA según el tipo de periodo seleccionado
            if (rbtnMensual.Checked)
                tea = tea / 12;
            else if (rbtnDiario.Checked)
                tea = tea / 360;

            // Aseguramos que el DataGridView tenga suficientes filas
            dgtvReporte.Rows.Clear();  // Limpiamos cualquier fila anterior
            dgtvReporte.Rows.Add(tiempo + 1);  // Agregamos las filas necesarias

            for (int i = 0; i <= tiempo; i++)
            {
                // Calcular interés acumulado y valor futuro
                double valorFuturo = capital * Math.Pow(1 + (tea / 100), i);
                double interesAcumulado = capital * (Math.Pow(1 + (tea / 100), i) - 1);

                // Asignar valores a las celdas del DataGridView
                dgtvReporte.Rows[i].Cells[0].Value = i.ToString();  // Periodo
                dgtvReporte.Rows[i].Cells[1].Value = "S/. " + interesAcumulado.ToString("F2");  // Interés acumulado
                dgtvReporte.Rows[i].Cells[2].Value = "S/. " + valorFuturo.ToString("F2");  // Valor Futuro
            }
        }

        private void txtPeriodo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // valida cada caracter con su respectivo codigo ASCII

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                errorProvider.SetError(txtPeriodo, "No se admiten letras.");
                e.Handled = true;  // Evita que el carácter se muestre en el TextBox
            }
            else
            {
                errorProvider.Clear();
            }
        }
    }
}
