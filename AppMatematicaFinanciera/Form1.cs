using System.Windows.Forms.DataVisualization.Charting;

namespace AppMatematicaFinanciera
{
    public partial class frmVentanaPrincipal : Form
    {
        public frmVentanaPrincipal()
        {
            InitializeComponent();
        }

        void AbrirForm(Form formulario)
        {
            while (panelBase.Controls.Count > 0)
            {
                panelBase.Controls.RemoveAt(0);
            }

            Form formHijo = formulario;
            formulario.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            this.Text = formHijo.Text;
            panelBase.Controls.Add(formHijo);
            formHijo.Show();
        }

        private void interesSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FrmInteresSimple();
            AbrirForm(form);
        }

        private void interesCompuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FrmInteresCompuesto();
            AbrirForm(form);
        }

        private void sistemaFrancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FrmAmortizacionFrances();
            AbrirForm(form);
        }

        private void sistemaAlemanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FrmAmortizacionAleman();
            AbrirForm(form);
        }

        private void sistemaAmericanoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FrmAmortizacionAmericano();
            AbrirForm(form);
        }

        private void anualidadVencidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form form = new FrmAnualidad();
            AbrirForm(form);
        }

        private void gradienteAritmeticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FormGradiente();
            AbrirForm(form);
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FormVan();
            AbrirForm(form);
        }

        private void tIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FormTir();
            AbrirForm(form);
        }

        private void payBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FormPayBack();
            AbrirForm(form);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form form = new FormDepreciacion();
            AbrirForm(form);
        }
    }
}
