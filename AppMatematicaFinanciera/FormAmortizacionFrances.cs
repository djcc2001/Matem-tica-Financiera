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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace AppMatematicaFinanciera
{
    public partial class FrmAmortizacionFrances : Form
    {
        public FrmAmortizacionFrances()
        {
            InitializeComponent();
        }

        public double CalcularCuotaSistemaFrances(double capital, double tiempo, double tea)
        {
            double r;
            r = tea / 1200;
            double Cuota = (capital * r * Math.Pow(1 + r, tiempo)) / (Math.Pow(1 + r, tiempo) - 1);
            return Cuota;
        }

        private void Calcular()
        {
            double deuda = double.Parse(txtDeuda.Text);
            double interes = double.Parse(txtInteres.Text);
            int tiempo = int.Parse(txtTiempo.Text);

            double cuota = CalcularCuotaSistemaFrances(deuda, tiempo, interes);

            txtPago.Text = Math.Round(cuota, 2).ToString("F2");

            GenerarReporte();
            GenerarGrafico();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDeuda.Text)) {
                errorProvider.SetError(txtDeuda, "Todo los campos deben ser llenados.");
            }
            else {
                errorProvider.Clear();
                if (string.IsNullOrWhiteSpace(txtInteres.Text)) {
                    errorProvider.SetError(txtInteres, "Todo los campos deben ser llenados.");
                }
                else  {
                    errorProvider.Clear();
                    if (string.IsNullOrWhiteSpace(txtTiempo.Text))  {
                        errorProvider.SetError(txtTiempo, "Todo los campos deben ser llenados.");
                    }
                    else {
                        errorProvider.Clear();
                        Calcular();
                    }
                }
            }

        }

        private void GenerarReporte()
        {
            double deuda = double.Parse(txtDeuda.Text);
            double interes = double.Parse(txtInteres.Text);
            if (interes < 1)
                interes = interes / 12;
            else
                interes = interes / 1200;
            int tiempo = int.Parse(txtTiempo.Text);
            double cuota = double.Parse(txtPago.Text);

            // Aseguramos que el DataGridView tenga suficientes filas
            dgtvReporte.Rows.Clear();  // Limpiamos cualquier fila anterior
            dgtvReporte.Rows.Add(tiempo);  // Agregamos las filas necesarias

            double monto = 0;
            interes = deuda * interes;
            double amortizacion = cuota - interes;

            for (int i = 0; i < tiempo; i++)
            {
                // calculo de la deuda restante.
                monto = deuda - amortizacion * i;

                // Asignamos valores a las celdas del DataGridView
                dgtvReporte.Rows[i].Cells[0].Value = (i + 1).ToString();  // Mes
                dgtvReporte.Rows[i].Cells[1].Value = "S/. " + cuota.ToString("F2");  // Cuota
                dgtvReporte.Rows[i].Cells[2].Value = "S/. " + interes.ToString("F2");  // Interes
                dgtvReporte.Rows[i].Cells[3].Value = "S/. " + amortizacion.ToString("F2");  // Amortizacion
                dgtvReporte.Rows[i].Cells[4].Value = "S/. " + monto.ToString("F2");  // deuda
            }

        }
       
        private void GenerarGrafico()
        {
            // Limpiar cualquier serie o puntos existentes en el Chart
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.ChartAreas.Add(new ChartArea());

            // Crear series para la deuda y amortización
            Series seriesDeuda = new Series("Deuda");
            Series serieAmortizacion = new Series("Amortización");

            seriesDeuda.ChartType = SeriesChartType.Column;
            serieAmortizacion.ChartType = SeriesChartType.Column; 

            // Obtener los datos necesarios
            double deuda = double.Parse(txtDeuda.Text);
            double interes = double.Parse(txtInteres.Text);
            if (interes < 1)
                interes = interes / 12;
            else
                interes = interes / 1200;

            int tiempo = int.Parse(txtTiempo.Text);
            double cuota = double.Parse(txtPago.Text);

            // Calcular la amortización (se mantiene constante)
            double amortizacion = cuota - (deuda * interes);

            // Agregar puntos al gráfico
            for (int i = 1; i <= tiempo; i++)
            {
                // Verificar si es un mes que debe ser mostrado (según el intervalo)
                if (i % 1 == 0 || i == tiempo) // Cambia a tu lógica de intervalo aquí
                {
                    seriesDeuda.Points.AddXY(i, deuda);            // Deuda total actual
                    serieAmortizacion.Points.AddXY(i, amortizacion); // Amortización constante
                }

                // Recalcular el saldo de la deuda
                deuda -= amortizacion; // Solo restamos la amortización fija
            }

            // Agregar las series al Chart
            chart1.Series.Add(seriesDeuda);
            chart1.Series.Add(serieAmortizacion);

            // Ajustar títulos y ejes
            chart1.Titles.Clear();
            chart1.Titles.Add("Gráfico de Amortización - Sistema Francés");
            chart1.ChartAreas[0].AxisX.Title = "Meses";
            chart1.ChartAreas[0].AxisY.Title = "Monto (S/.)";

            // Establecer intervalo del eje X
            chart1.ChartAreas[0].AxisX.Interval = 1; // Cambia esto según tu lógica de intervalo
        }
        
        private void bntLimpiar_Click(object sender, EventArgs e)
        {
            txtDeuda.Text = string.Empty;
            txtInteres.Text = string.Empty;
            txtPago.Text = string.Empty;
            txtTiempo.Text = string.Empty;

            chart1.Series.Clear();
            chart1.Titles.Clear();

            dgtvReporte.Rows.Clear();
        }

        private void txtTiempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // valida cada caracter con su respectivo codigo ASCII
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                errorProvider.SetError(txtTiempo, "No se admiten letras.");
                e.Handled = true;  // Evita que el carácter se muestre en el TextBox
            }
            else
            {
                errorProvider.Clear();
            }
        }
    }
}
