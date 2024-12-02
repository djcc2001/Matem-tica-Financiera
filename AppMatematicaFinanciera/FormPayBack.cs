using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMatematicaFinanciera
{

    public partial class FormPayBack : Form
    {
        int periodo = 0;

        public FormPayBack()
        {
            InitializeComponent();
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPeriodo.Text))
            {
                errorProvider.SetError(txtPeriodo, "Todos los campos deben ser llenados.");
            }
            else
            {
                AgregarFilas();
            }
        }
        private void AgregarFilas()
        {
            periodo = int.Parse(txtPeriodo.Text);
            for (int i = 0; i <= periodo; i++)
            {
                // Agregar una fila vacía
                dgvDatos.Rows.Add(i, "(inserte flujo)", "");
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ValidarTabla();
            CalcularFlujoAcumulado();
            CalcularPayBack();
        }
        private void ValidarTabla()
        {
            // Recorre todas las filas del DataGridView
            foreach (DataGridViewRow fila in dgvDatos.Rows)
            {
                // Recorre todas las celdas de la fila
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    // Si la celda está vacía o contiene un valor nulo
                    if (celda.Value.Equals("(\r\n)"))
                        celda.Value = "0"; // Reemplaza con 0
                }
            }
        }
        private void CalcularFlujoAcumulado()
        {
            double acumulador = 0;
            // Recorre todas las filas del DataGridView
            foreach (DataGridViewRow fila in dgvDatos.Rows)
            {
                double flujo = Convert.ToDouble(fila.Cells[1].Value ?? 0);

                acumulador += flujo;

                fila.Cells[2].Value = acumulador;
            }
        }
        private void CalcularPayBack()
        {
            double flujoAcumuladoAnterior = 0;
            double flujoAcumuladoActual = 0;
            int periodoAnterior = -1;
            int periodoActual = -1;
            double flujoNetoEnPeriodo = 0;
            double payBackExacto = -1; // Inicialmente -1 significa que no se recuperó la inversión

            foreach (DataGridViewRow fila in dgvDatos.Rows)
            {
                if (fila.IsNewRow) continue; // Ignorar la fila de "nueva entrada"

                flujoAcumuladoActual = Convert.ToDouble(fila.Cells[2].Value ?? 0);
                periodoActual = Convert.ToInt32(fila.Cells[0].Value);

                // Detectar el punto donde el flujo acumulado cambia de negativo a positivo o cero
                if (flujoAcumuladoAnterior < 0 && flujoAcumuladoActual >= 0)
                {
                    flujoNetoEnPeriodo = Convert.ToDouble(fila.Cells[1].Value ?? 0); // Flujo neto en este período

                    // Interpolar el tiempo exacto de recuperación
                    payBackExacto = periodoAnterior + Math.Abs(flujoAcumuladoAnterior) / flujoNetoEnPeriodo;

                    // Pintar las celdas relevantes
                    // Resaltar el flujo acumulado anterior (negativo) y su período
                    var filaAnterior = dgvDatos.Rows[periodoAnterior];
                    filaAnterior.Cells[0].Style.BackColor = Color.Yellow; // Celda de período
                    filaAnterior.Cells[2].Style.BackColor = Color.Yellow; // Celda de flujo acumulado

                    // Resaltar el flujo neto del siguiente período y su acumulado
                    fila.Cells[1].Style.BackColor = Color.Yellow; // Celda de flujo neto

                    break; // Salir del bucle, ya que se encontró el período de recuperación
                }

                flujoAcumuladoAnterior = flujoAcumuladoActual;
                periodoAnterior = periodoActual;
            }

            if (payBackExacto >= 0)
            {
                txtPb.Text = payBackExacto.ToString("F2");
            }
            else
            {
                txtPb.Text = "No se recuperó la inversión.";
            }
        }
        private void DgvDatos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Validar si es una celda que necesita el efecto
            if (e.ColumnIndex >= 1 && e.RowIndex >= 0) // Solo columnas de egresos
            {
                var cell = dgvDatos.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value?.ToString() == "(inserte flujo)")
                {
                    e.PaintBackground(e.ClipBounds, true); // Pinta el fondo
                    TextRenderer.DrawText(
                        e.Graphics,
                        cell.Value.ToString(),
                        dgvDatos.Font,
                        e.CellBounds,
                        Color.Gray, // Color del placeholder
                        TextFormatFlags.VerticalCenter | TextFormatFlags.Left
                    );
                    e.Handled = true; // Evita la pintura predeterminada
                }
            }
        }
        private void bntLimpiar_Click(object sender, EventArgs e)
        {
            txtPeriodo.Text = string.Empty;
            txtPb.Text = string.Empty;

            dgvDatos.Rows.Clear();
        }

        private void txtPeriodo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Valida cada caracter con su respectivo código ASCII
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                errorProvider.SetError(txtPeriodo, "No se admiten letras.");
                e.Handled = true; // Evita que el carácter se muestre en el TextBox
            }
            else
            {
                errorProvider.Clear();
            }
        }
    }
}
