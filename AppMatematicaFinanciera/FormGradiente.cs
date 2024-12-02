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
    public partial class FormGradiente : Form
    {
        double capital = 0;
        double cuota1 = 0;
        double gradiente = 0;
        double interes = 0;
        int periodo = 0;
        string seleccion = "";

        private bool dibujar = false; // Bandera para controlar el dibujo

        public FormGradiente()
        {
            InitializeComponent();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCapital.Text))
            {
                errorProvider.SetError(txtCapital, "Todos los campos deben ser llenados.");
            }
            else
            {
                errorProvider.Clear();
                if (string.IsNullOrWhiteSpace(txtCuota1.Text))
                {
                    errorProvider.SetError(txtCuota1, "Todos los campos deben ser llenados.");
                }
                else
                {
                    errorProvider.Clear();
                    if (string.IsNullOrWhiteSpace(txtGradiente.Text))
                    {
                        errorProvider.SetError(txtGradiente, "Todos los campos deben ser llenados.");
                    }
                    else
                    {
                        errorProvider.Clear();
                        if (string.IsNullOrWhiteSpace(txtPeriodo.Text))
                        {
                            errorProvider.SetError(txtGradiente, "Todos los campos deben ser llenados.");
                        }
                        else
                        {
                            errorProvider.Clear();
                            if (cbCalcular.SelectedIndex == -1)
                            {
                                errorProvider.SetError(cbCalcular, "Debe seleccionar una opción.");
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
        }
        private void Calcular()
        {
            capital = double.Parse(txtCapital.Text);
            cuota1 = double.Parse(txtCuota1.Text);
            gradiente = double.Parse(txtGradiente.Text);
            interes = double.Parse(txtInteres.Text) / 100;
            periodo = int.Parse(txtPeriodo.Text);
            seleccion = cbCalcular.SelectedItem.ToString();

            CalcularValorPresente();
            CalcularValorFuturo();
            Dibujar();
            GenerarTabla();
        }
        private void CalcularValorPresente()
        {
            double P = 0;
            // Fórmula de valor presente con gradiente aritmético
            double term1 = ((Math.Pow(1 + interes, periodo) - 1) / (interes * Math.Pow(1 + interes, periodo)));
            double term2 = ((Math.Pow(1 + interes, periodo) - 1) / (interes * Math.Pow(1 + interes, periodo))) - (periodo / Math.Pow(1 + interes, periodo));
            if (seleccion.Equals("G.A. Creciente"))
                P = cuota1 * term1 + (gradiente / interes) * term2;
            else
                P = cuota1 * term1 - (gradiente / interes) * term2;
            txtVP.Text = P.ToString("F2");
        }
        private void CalcularValorFuturo()
        {
            double F = 0;
            // Fórmula de valor presente con gradiente aritmético
            double term1 = ((Math.Pow(1 + interes, periodo) - 1) / interes);
            double term2 = ((Math.Pow(1 + interes, periodo) - 1) / interes) - periodo;
            if (seleccion.Equals("G.A. Creciente"))
                F = cuota1 * term1 + (gradiente / interes) * term2;
            else
                F = cuota1 * term1 - (gradiente / interes) * term2;
            txtVF.Text = F.ToString("F2");
        }
        private void Dibujar()
        {
            dibujar = true;
            pnlDiagrama.Invalidate(); // Forzar el redibujado del panel
        }
        private void pnlDiagrama_Paint(object sender, PaintEventArgs e)
        {
            if (!dibujar) return; // No hacer nada si no se debe dibujar

            if (seleccion.Equals("G.A. Creciente"))
                DibujarCreciente(e);
            else
                DibujarDecreciente(e);
        }
        private void DibujarCreciente(PaintEventArgs e)
        {
            if (!dibujar) return; // No hacer nada si no se debe dibujar

            Graphics g = e.Graphics;

            // Configuración del dibujo
            Pen pen = new Pen(Color.Black, 2);
            Font font = new Font("Arial", 10);
            Brush textBrush = Brushes.Black;

            // Coordenadas base
            int ejeY = 200; // Línea horizontal
            int vpY = 200; // Punto inferior para el VP
            int margen = 50; // Margen desde el borde del panel

            // Ajustar la longitud de la línea horizontal según el tamaño del panel
            int ejeXInicio = margen;
            int ejeXFin = pnlDiagrama.Width - margen;

            // Dibujar eje horizontal
            g.DrawLine(pen, ejeXInicio, ejeY, ejeXFin, ejeY);

            int posX = 0;
            int entradaY = 0;

            // Determinar si el número de periodos es menor o igual a 6
            bool mostrarTodosLosPeriodos = periodo <= 6;

            int espacio = (ejeXFin - ejeXInicio) / periodo; // Cambiado para incluir todos los periodos

            for (int i = 0; i <= periodo; i++) // Cambiado de "i < periodo" a "i <= periodo"
            {
                posX = ejeXInicio + (i * espacio);
                entradaY = ejeY - (i * 15); // Ajustar la posición de las flechas según el índice i

                // Dibujar solo las flechas en los periodos 1, 2, 3 y los últimos tres
                if (mostrarTodosLosPeriodos || i == 1 || i == 2 || i == 3 || i >= periodo - 3)
                {
                    // Dibujar flechas hacia arriba
                    g.DrawLine(pen, posX, ejeY, posX, entradaY);
                    g.DrawLine(pen, posX - 5, entradaY + 5, posX, entradaY);
                    g.DrawLine(pen, posX + 5, entradaY + 5, posX, entradaY);

                    // Mostrar los valores correspondientes solo si i > 0
                    if (i > 0) // Agregada esta condición para omitir el valor en el periodo 0
                    {
                        if (i == 1)
                        {
                            g.DrawString($"{cuota1}", font, textBrush, posX - 20, entradaY - 30); // Ajuste para que el valor esté por encima de la flecha
                        }
                        else
                        {
                            g.DrawString($"{cuota1 + i * gradiente}", font, textBrush, posX - 20, entradaY - 30); // Ajuste para que el valor esté por encima de la flecha
                        }
                    }
                }

                // Etiquetas de los periodos
                if (mostrarTodosLosPeriodos || i == 1 || i == 2 || i == 3 || i >= periodo - 3)
                {
                    g.DrawString($"{i}", font, textBrush, posX - 5, ejeY + 5);
                }
                else
                {
                    // Mostrar puntos suspensivos solo en los periodos intermedios
                    if (i == periodo / 2)
                    {
                        g.DrawString("...", font, textBrush, posX - 5, ejeY + 5);
                    }
                }
            }
        }
        private void DibujarDecreciente(PaintEventArgs e)
        {
            if (!dibujar) return; // No hacer nada si no se debe dibujar

            Graphics g = e.Graphics;

            // Configuración del dibujo
            Pen pen = new Pen(Color.Black, 2);
            Font font = new Font("Arial", 10);
            Brush textBrush = Brushes.Black;

            // Coordenadas base
            int ejeY = 200; // Línea horizontal
            int margen = 50; // Margen desde el borde del panel

            // Ajustar la longitud de la línea horizontal según el tamaño del panel
            int ejeXInicio = margen;
            int ejeXFin = pnlDiagrama.Width - margen;

            // Dibujar eje horizontal
            g.DrawLine(pen, ejeXInicio, ejeY, ejeXFin, ejeY);

            int posX = 0;
            int entradaY = 0;

            // Determinar si el número de periodos es menor o igual a 6
            bool mostrarTodosLosPeriodos = periodo <= 6;

            // Configurar la longitud base de las flechas
            int longitudBaseFlecha = 180; // Longitud inicial de la flecha

            int espacio = (ejeXFin - ejeXInicio) / periodo; // Dividir por "periodo" en lugar de "periodo - 1" para que incluya el último punto.

            for (int i = 0; i <= periodo; i++) // Cambiado a "i <= periodo" para incluir el periodo final
            {
                posX = ejeXInicio + (i * espacio);

                // Reducir la longitud de las flechas conforme avanza el índice
                int longitudFlecha = longitudBaseFlecha - (i * 18); // Reducir en función del índice

                // Asegurarse de que la longitud mínima de las flechas no sea negativa
                if (longitudFlecha < 10)
                {
                    longitudFlecha = 10;
                }

                entradaY = ejeY - longitudFlecha; // Colocar la flecha hacia arriba con la longitud correspondiente

                // Dibujar solo las flechas en los periodos 1, 2, 3 y los últimos tres
                if (mostrarTodosLosPeriodos || i == 1 || i == 2 || i == 3 || i >= periodo - 3)
                {
                    // Dibujar flechas hacia arriba solo si i > 0
                    if (i > 0)
                    {
                        g.DrawLine(pen, posX, ejeY, posX, entradaY);
                        g.DrawLine(pen, posX - 5, entradaY + 5, posX, entradaY);
                        g.DrawLine(pen, posX + 5, entradaY + 5, posX, entradaY);
                    }

                    // Mostrar los valores correspondientes solo si i > 0
                    if (i > 0)
                    {
                        if (i == 1)
                        {
                            g.DrawString($"{cuota1}", font, textBrush, posX - 20, entradaY - 20); // Ajuste para que el valor esté por encima de la flecha
                        }
                        else
                        {
                            // Cálculo del valor con gradiente decreciente
                            g.DrawString($"{cuota1 - i * gradiente}", font, textBrush, posX - 20, entradaY - 20); // Ajuste para que el valor esté por encima de la flecha
                        }
                    }
                }

                // Etiquetas de los periodos
                if (mostrarTodosLosPeriodos || i == 1 || i == 2 || i == 3 || i >= periodo - 3)
                {
                    g.DrawString($"{i}", font, textBrush, posX - 5, ejeY + 5); // Ajuste para que la etiqueta esté debajo de la línea
                }
                else
                {
                    // Mostrar puntos suspensivos solo en los periodos intermedios
                    if (i == periodo / 2)
                    {
                        g.DrawString("...", font, textBrush, posX - 5, ejeY + 5); // Ajuste para que los puntos suspensivos estén debajo de la línea
                    }
                }
            }

        }
        private void GenerarTabla()
        {
            // Limpiamos cualquier fila anterior
            dgtvReporte.Rows.Clear();
            // Agregamos las filas necesarias
            dgtvReporte.Rows.Add(periodo + 1);

            double interestb = 0; // Interés del periodo
            double abonotb = 0;  // Amortización del periodo
            double saldoCapital = capital; // Inicializamos con el capital inicial

            for (int i = 0; i <= periodo; i++)
            {
                if (i == 0)
                {
                    dgtvReporte.Rows[i].Cells[0].Value = i.ToString(); // Periodo
                    dgtvReporte.Rows[i].Cells[4].Value = saldoCapital.ToString("F2"); // Saldo inicial
                }
                else
                {
                    interestb = saldoCapital * interes; 
                    abonotb = cuota1 - interestb;       
                    saldoCapital -= abonotb;           

                    // Llenar el DataGridView
                    dgtvReporte.Rows[i].Cells[0].Value = i.ToString(); // Periodo
                    dgtvReporte.Rows[i].Cells[1].Value = cuota1.ToString("F2"); // Cuota
                    dgtvReporte.Rows[i].Cells[2].Value = interestb.ToString("F2"); // Interés
                    dgtvReporte.Rows[i].Cells[3].Value = abonotb.ToString("F2"); // Amortización
                    dgtvReporte.Rows[i].Cells[4].Value = saldoCapital.ToString("F2"); // Saldo
                    cuota1 += gradiente;
                }

                
            }

        }
        private void bntLimpiar_Click(object sender, EventArgs e)
        {
            txtCapital.Text = string.Empty;
            txtCuota1.Text = string.Empty;
            txtGradiente.Text = string.Empty;
            txtInteres.Text = string.Empty;
            txtPeriodo.Text = string.Empty;
            txtVF.Text = string.Empty;
            txtVP.Text = string.Empty;
            cbCalcular.SelectedIndex = -1;

            dibujar = false; // Desactivar el dibujo
            pnlDiagrama.Invalidate(); // Redibujar el panel, pero sin contenido

            dgtvReporte.Rows.Clear();
        }
    }
}
