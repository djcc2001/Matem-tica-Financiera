using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppMatematicaFinanciera
{
    public partial class FrmAnualidad : Form
    {
        double anualidad = 0;
        int pagos = 0;
        int pago = 0;
        double interes = 0;
        double tasa = 0;
        string frecuencia = "";
        private bool dibujar = false; // Bandera para controlar el dibujo

        public FrmAnualidad()
        {
            InitializeComponent();
        }
        public double CalcularValorPresente(double anualidad, double tea, int tiempo)
        {
            return anualidad * ((1 - Math.Pow(1 + tea, -tiempo)) / tea);
        }
        public double CalcularValorFuturo(double anualidad, double tea, int tiempo)
        {
            return anualidad * ((Math.Pow(1 + tea, tiempo) - 1) / tea);
        }
        private void Calcular()
        {
            anualidad = double.Parse(txtAnualidad.Text);
            pagos = int.Parse(txtPagos.Text);
            interes = double.Parse(txtTasa.Text);
            string seleccion = cbCalcular.SelectedItem.ToString();
            frecuencia = cbFrecuencia.SelectedItem.ToString();
            
            if (frecuencia == "Semestral")
            {
                tasa = interes / 2;
                pago = pagos * 2;
            }
            if (frecuencia == "Trimestral")
            {
                tasa = interes / 4;
                pago = pagos * 4;
            }
            if (frecuencia == "Mensual")
            {

                tasa = interes / 12;
                pago = pagos * 12;

            }

            double calculo = 0;
            if (seleccion == "Valor Presente")
            {
                calculo = CalcularValorPresente(anualidad, tasa, pago);
                lblResulado.Text = "Valor Presente: ";
            }
            else
            {
                calculo = CalcularValorFuturo(anualidad, tasa, pago);
                lblResulado.Text = "Valor Futuro: ";
            }

            txtResultado.Text = Math.Round(calculo, 2).ToString("F2");
            Dibujar();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAnualidad.Text))
            {
                errorProvider.SetError(txtAnualidad, "Todos los campos deben ser llenados.");
            }
            else
            {
                errorProvider.Clear();
                if (string.IsNullOrWhiteSpace(txtTasa.Text))
                {
                    errorProvider.SetError(txtTasa, "Todos los campos deben ser llenados.");
                }
                else
                {
                    errorProvider.Clear();
                    if (string.IsNullOrWhiteSpace(txtPagos.Text))
                    {
                        errorProvider.SetError(txtPagos, "Todos los campos deben ser llenados.");
                    }
                    else
                    {
                        if (cbFrecuencia.SelectedIndex == -1)
                        {
                            errorProvider.SetError(cbCalcular, "Debe seleccionar una opción.");
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
        private void bntLimpiar_Click(object sender, EventArgs e)
        {
            txtAnualidad.Text = string.Empty;
            txtPagos.Text = string.Empty;
            txtResultado.Text = string.Empty;
            txtTasa.Text = string.Empty;
            cbFrecuencia.SelectedIndex = -1;
            cbCalcular.SelectedIndex = -1;
            lblResulado.Text = string.Empty;

            dibujar = false; // Desactivar el dibujo
            pnlDiagrama.Invalidate(); // Redibujar el panel, pero sin contenido
        }
        private void txtPagos_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Valida cada caracter con su respectivo código ASCII
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                errorProvider.SetError(txtPagos, "No se admiten letras.");
                e.Handled = true; // Evita que el carácter se muestre en el TextBox
            }
            else
            {
                errorProvider.Clear();
            }
        }
        private void Dibujar()
        {
            // Activar el dibujo y redibujar el panel
            dibujar = true;
            pnlDiagrama.Invalidate(); // Forzar que el panel se vuelva a dibujar
        }
        private void pnlDiagrama_Paint(object sender, PaintEventArgs e)
        {
            if (!dibujar) return; // No hacer nada si no se debe dibujar

            Graphics g = e.Graphics;

            // Configuración del dibujo
            Pen pen = new Pen(Color.Black, 2);
            Font font = new Font("Arial", 10);
            Brush textBrush = Brushes.Black;

            // Coordenadas base
            int ejeY = 150; // Altura del eje horizontal
            int entradaY = 50; // Punto superior para la entrada (más alto)
            int salidaY = 250; // Punto inferior para las salidas (más bajo)
            int margen = 20; // Margen lateral para la línea horizontal

            // Ajustar la longitud de la línea horizontal según el tamaño del panel
            int ejeXInicio = margen; // Inicio de la línea horizontal
            int ejeXFin =500; // Fin de la línea horizontal

            // Dibujar eje horizontal
            g.DrawLine(pen, ejeXInicio, ejeY, ejeXFin, ejeY);

            // Dibujar entrada (flecha hacia arriba) al inicio
            int entradaX = ejeXInicio; // Posición de la entrada en el eje X
            g.DrawLine(pen, entradaX, ejeY, entradaX, entradaY); // Línea de la entrada
            g.DrawLine(pen, entradaX - 5, entradaY + 5, entradaX, entradaY); // Flecha izquierda
            g.DrawLine(pen, entradaX + 5, entradaY + 5, entradaX, entradaY); // Flecha derecha

            // Dibujar salida (flecha hacia abajo) al inicio
            g.DrawLine(pen, entradaX, ejeY, entradaX, salidaY); // Línea de la salida
            g.DrawLine(pen, entradaX - 5, salidaY - 5, entradaX, salidaY); // Flecha izquierda
            g.DrawLine(pen, entradaX + 5, salidaY - 5, entradaX, salidaY); // Flecha derecha

            // Dibujar etiquetas de entrada y salida
            g.DrawString("Entrada", font, textBrush, entradaX - 20, entradaY - 20); // Ajustar posición de "Entrada"
            g.DrawString("Salida", font, textBrush, entradaX - 20, salidaY + 5);    // Ajustar posición de "Salida"

            // Dibujar salidas adicionales
            int espacio = 0;
            if (pagos < 8)
            {
                espacio = (ejeXFin - ejeXInicio - 50) / pagos;
            }
            else
            {
                espacio = (ejeXFin - ejeXInicio - 50) / 10;
                pagos = 8;
            }
            int salidaX = ejeXInicio + espacio; // Posición de la primera salida en el eje X (espaciada un poco del inicio)
            

            for (int i = 0; i < pagos; i++)
            {
                // Dibujar línea de salida
                g.DrawLine(pen, salidaX, ejeY, salidaX, salidaY); // Línea de la salida
                g.DrawLine(pen, salidaX - 5, salidaY - 5, salidaX, salidaY); // Flecha izquierda
                g.DrawLine(pen, salidaX + 5, salidaY - 5, salidaX, salidaY); // Flecha derecha

                // Etiqueta para la flecha
                g.DrawString($"{i + 1}", font, textBrush, salidaX - 10, salidaY + 10);

                // Mover la posición horizontal para la próxima flecha
                salidaX += espacio;
            }

            // Dibujar texto adicional (información financiera)
            int textoX = ejeXFin + 20; // Posición del texto adicional
            g.DrawString("A = S/." + anualidad.ToString("F2"), font, textBrush, textoX, ejeY - 40);
            g.DrawString("i = "+ interes * 100+"%", font, textBrush, textoX, ejeY - 20);
            g.DrawString("n = "+pago, font, textBrush, textoX, ejeY);

        }
    }
}
