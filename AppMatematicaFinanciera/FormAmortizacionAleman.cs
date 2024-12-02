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

namespace AppMatematicaFinanciera
{
    public partial class FrmAmortizacionAleman : Form
    {
        public FrmAmortizacionAleman()
        {
            InitializeComponent();
        }

        public double CalcularCuotaSistemaAleman(double capital, double tiempo)
        {
            double pagoMensual = capital / tiempo;
            return pagoMensual;
        }

        private void Calcular()
        {
            double deuda = double.Parse(txtDeuda.Text);
            double interes = double.Parse(txtInteres.Text);
            int tiempo = int.Parse(txtTiempo.Text);

            double cuota = CalcularCuotaSistemaAleman(deuda, tiempo);

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
                if (string.IsNullOrWhiteSpace(txtInteres.Text))  {
                    errorProvider.SetError(txtInteres, "Todo los campos deben ser llenados.");
                }
                else {
                    errorProvider.Clear();
                    if (string.IsNullOrWhiteSpace(txtTiempo.Text)) {
                        errorProvider.SetError(txtTiempo, "Todo los campos deben ser llenados.");
                    }
                    else  {
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
            double calInteres = 0;

            for (int i = 0; i < tiempo; i++)
            {
                // calculo del interes
                calInteres = deuda * interes;
                // calculo de Deuda restante
                deuda = deuda - cuota;

                // Asignamos valores a las celdas del DataGridView
                dgtvReporte.Rows[i].Cells[0].Value = (i + 1).ToString();  // Mes
                dgtvReporte.Rows[i].Cells[1].Value = "S/. " + cuota.ToString("F2");  // Cuota
                dgtvReporte.Rows[i].Cells[2].Value = "S/. " + calInteres.ToString("F2");  // Interes
                dgtvReporte.Rows[i].Cells[3].Value = "S/. " + (cuota + calInteres).ToString("F2");  // Amortizacion
                dgtvReporte.Rows[i].Cells[4].Value = "S/. " + deuda.ToString("F2");  // deuda
            }

        }
        
        private void GenerarGrafico()
        {
            // Limpiar cualquier serie o puntos existentes en el Chart
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.ChartAreas.Add(new ChartArea());

            // Crear series para la deuda, intereses y amortización
            Series serieIntereses = new Series("Intereses");
            Series serieAmortizacion = new Series("Cuota Amortización");

            serieIntereses.ChartType = SeriesChartType.Column;
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

            int Intervalo = 0;
            if (tiempo < 10)
                Intervalo = 1;
            else if (tiempo < 30) 
                Intervalo = 3;
            else
                Intervalo = 5;

            double calInteres = 0;
            // Agregar los puntos al gráfico 
            for (int i = 0; i < tiempo; i += Intervalo)
            {
                // calculo del interes
                calInteres = deuda * interes;
                // calculo de Deuda restante
                deuda = deuda - cuota*Intervalo;
                // Agregar puntos a cada serie para los meses seleccionados 
                serieAmortizacion.Points.AddXY(i, cuota);
                serieIntereses.Points.AddXY(i, calInteres);
            }

            // Agregar las series al Chart
            chart1.Series.Add(serieIntereses);
            chart1.Series.Add(serieAmortizacion);

            // Ajustar títulos y ejes
            chart1.Titles.Clear();
            chart1.Titles.Add("Gráfico de Amortización - Sistema Alemán");
            chart1.ChartAreas[0].AxisX.Title = "Meses";
            chart1.ChartAreas[0].AxisY.Title = "Monto (S/.)";

            // Establecer intervalo del eje X para mostrar solo cada 3 meses
            chart1.ChartAreas[0].AxisX.Interval = Intervalo;

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
