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
    public partial class FormVan : Form
    {
        int periodo = 0;
        double tasa = 0;
        public FormVan()
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
                dgvDatos.Rows.Add(i, "(inserte egreso)", "(inserte ingreso)", "");
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTasa.Text))
            {
                errorProvider.SetError(txtTasa, "Todos los campos deben ser llenados.");
            }
            else
            {
                ValidarTabla();
                CalcularFlujoNeto();
                CalcularVan();
            }
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
                    if (celda.Value.Equals("(inserte egreso)") || celda.Value.Equals("(inserte ingreso)"))
                        celda.Value = "0"; // Reemplaza con 0
                }
            }
        }
        private void CalcularFlujoNeto()
        {
            // Recorre todas las filas del DataGridView
            foreach (DataGridViewRow fila in dgvDatos.Rows)
            {
                double egreso = Convert.ToDouble(fila.Cells[1].Value ?? 0);
                double ingreso = Convert.ToDouble(fila.Cells[2].Value ?? 0);

                double flujoNeto = ingreso - egreso;

                fila.Cells[3].Value = flujoNeto;
            }
        }
        void CalcularVan()
        {
            tasa = double.Parse(txtTasa.Text) / 100;
            double van = 0;
            int i = 0;
            // Recorre todas las filas del DataGridView
            foreach (DataGridViewRow fila in dgvDatos.Rows)
            {
                double result = 0;
                double flujo = Convert.ToDouble(fila.Cells[3].Value ?? 0);
                if (i == 0)
                {
                    result = flujo;
                }
                else
                {
                    result = flujo / Math.Pow(1 + tasa, i);
                }
                van += result;
                i += 1;
            }
            txtVan.Text = van.ToString("F2");
        }

        private void DgvDatos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Validar si es una celda que necesita el efecto
            if (e.ColumnIndex >= 1 && e.RowIndex >= 0) // Solo columnas de egresos
            {
                var cell = dgvDatos.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value?.ToString() == "(inserte egreso)" || cell.Value?.ToString() == "(inserte ingreso)")
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
            txtTasa.Text = string.Empty;
            txtPeriodo.Text = string.Empty;
            txtVan.Text = string.Empty;

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
