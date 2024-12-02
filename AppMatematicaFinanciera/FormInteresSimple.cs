using System.Windows.Forms.DataVisualization.Charting;
using ChartingSeries = System.Windows.Forms.DataVisualization.Charting.Series;


namespace AppMatematicaFinanciera
{
    public partial class FrmInteresSimple : Form
    {
        public FrmInteresSimple()
        {
            InitializeComponent();
        }

        private double InteresSimple(string periodo, int tiempo, double capital, double tea)
        {
            double interes = 0;
            if (periodo == "diario")
                interes = capital * tiempo * (tea / 36000);
            if (periodo == "mensual")
                interes = capital * tiempo * (tea / 1200);
            if (periodo == "anual")
                interes = capital * tiempo * tea / 100;

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

            double interes = InteresSimple(Periodo, tiempo, capital, tea);
            double monto = interes + capital;

            txtInteres.Text = Math.Round(interes, 2).ToString("F2");
            txtMonto.Text = Math.Round(monto, 2).ToString("F2");

            GenerarGrafico();
            GenerarReporte();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCapital.Text)) {
                errorProvider.SetError(txtCapital, "Todo los campos deben ser llenados.");
            }
            else {
                errorProvider.Clear();
                if (!rbtnDiario.Checked && !rbtnMensual.Checked && !rbtnAnual.Checked) {
                    errorProvider.SetError(groupBox1, "Debe marcar al menos 1 opción.");
                }
                else {
                    errorProvider.Clear();
                    if (string.IsNullOrWhiteSpace(txtTEA.Text)) {
                        errorProvider.SetError(txtTEA, "Todo los campos deben ser llenados.");
                    }
                    else {
                        errorProvider.Clear();                      
                        if (string.IsNullOrWhiteSpace(txtPeriodo.Text)) {
                            errorProvider.SetError(txtPeriodo, "Todo los campos deben ser llenados.");
                        }
                        else {
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
            double capital = double.Parse(txtCapital.Text);
            int tiempo = int.Parse(txtPeriodo.Text);
            double interes = double.Parse(txtInteres.Text) / tiempo;

            // Configurar el tipo de gráfico
            chart1.Series.Clear();
            ChartingSeries series = new ChartingSeries();
            series.ChartType = SeriesChartType.Line;
            chart1.Series.Add(series);
            chart1.Legends.Clear();

            double Valor_Futuro = 0;
            for (int i = 0; i <= tiempo; i++)
            {
                // Agregar datos
                Valor_Futuro = capital + (interes * i);

                if (tiempo % 2 == 0)
                {
                    if (i % 2 == 0)
                        series.Points.AddXY(i, Valor_Futuro);
                }
                else
                {
                    if (i % 2 == 1)
                        series.Points.AddXY(i, Valor_Futuro);
                }
            }

            // Configurar el título del gráfico
            chart1.Titles.Add("Valor Futuro del Capital");

            // Quitar la leyenda
            chart1.Legends.Clear();

            // Configurar el eje X para que siempre comience en 0
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = capital + interes * tiempo;

            // Configurar etiquetas para los ejes
            chart1.ChartAreas[0].AxisX.Title = "Periodo";
            chart1.ChartAreas[0].AxisY.Title = "Valor Futuro";
        }

        private void GenerarReporte()
        {
            double capital = double.Parse(txtCapital.Text);
            int tiempo = int.Parse(txtPeriodo.Text);
            double interes = double.Parse(txtInteres.Text) / tiempo;

            // Aseguramos que el DataGridView tenga suficientes filas
            dgtvReporte.Rows.Clear();  // Limpiamos cualquier fila anterior
            dgtvReporte.Rows.Add(tiempo + 1);  // Agregamos las filas necesarias

            double Valor_Futuro = 0;
            for (int i = 0; i <= tiempo; i++)
            {
                // Calcular interés acumulado para el periodo actual
                double interes_acumulado = interes * i;
                Valor_Futuro = capital + interes_acumulado;

                // Asignamos valores a las celdas del DataGridView
                dgtvReporte.Rows[i].Cells[0].Value = i.ToString();  // Periodo
                dgtvReporte.Rows[i].Cells[1].Value = "S/. " + interes_acumulado.ToString("F2");  // Interés acumulado
                dgtvReporte.Rows[i].Cells[2].Value = "S/. " + Valor_Futuro.ToString("F2");  // Valor Futuro
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
