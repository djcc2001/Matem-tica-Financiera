namespace AppMatematicaFinanciera
{
    partial class FrmAnualidad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bntLimpiar = new Button();
            btnCalcular = new Button();
            txtPagos = new TextBox();
            lblTiempo = new Label();
            txtTasa = new TextBox();
            lblInteres = new Label();
            txtAnualidad = new TextBox();
            lvlDeuda = new Label();
            lblTitulo = new Label();
            cbCalcular = new ComboBox();
            lblSeleccion = new Label();
            lblResulado = new Label();
            txtResultado = new TextBox();
            errorProvider = new ErrorProvider(components);
            pnlDiagrama = new Panel();
            label = new Label();
            cbFrecuencia = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // bntLimpiar
            // 
            bntLimpiar.BackColor = Color.Red;
            bntLimpiar.Font = new Font("Sitka Display", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            bntLimpiar.ForeColor = Color.White;
            bntLimpiar.Location = new Point(112, 207);
            bntLimpiar.Name = "bntLimpiar";
            bntLimpiar.Size = new Size(87, 42);
            bntLimpiar.TabIndex = 69;
            bntLimpiar.Text = "Limpiar";
            bntLimpiar.UseVisualStyleBackColor = false;
            bntLimpiar.Click += bntLimpiar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Lime;
            btnCalcular.Font = new Font("Sitka Text", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcular.ForeColor = Color.Black;
            btnCalcular.Location = new Point(220, 206);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(102, 42);
            btnCalcular.TabIndex = 68;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtPagos
            // 
            txtPagos.Location = new Point(112, 158);
            txtPagos.Name = "txtPagos";
            txtPagos.Size = new Size(210, 23);
            txtPagos.TabIndex = 67;
            txtPagos.TextAlign = HorizontalAlignment.Right;
            txtPagos.KeyPress += txtPagos_KeyPress;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(51, 161);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(48, 15);
            lblTiempo.TabIndex = 66;
            lblTiempo.Text = "Periodo";
            // 
            // txtTasa
            // 
            txtTasa.Location = new Point(112, 121);
            txtTasa.Name = "txtTasa";
            txtTasa.Size = new Size(210, 23);
            txtTasa.TabIndex = 65;
            txtTasa.TextAlign = HorizontalAlignment.Right;
            // 
            // lblInteres
            // 
            lblInteres.AutoSize = true;
            lblInteres.Location = new Point(57, 124);
            lblInteres.Name = "lblInteres";
            lblInteres.Size = new Size(42, 15);
            lblInteres.TabIndex = 64;
            lblInteres.Text = "Interes";
            // 
            // txtAnualidad
            // 
            txtAnualidad.Location = new Point(112, 83);
            txtAnualidad.Name = "txtAnualidad";
            txtAnualidad.Size = new Size(210, 23);
            txtAnualidad.TabIndex = 63;
            txtAnualidad.TextAlign = HorizontalAlignment.Right;
            // 
            // lvlDeuda
            // 
            lvlDeuda.AutoSize = true;
            lvlDeuda.Location = new Point(38, 86);
            lvlDeuda.Name = "lvlDeuda";
            lvlDeuda.Size = new Size(61, 15);
            lvlDeuda.TabIndex = 62;
            lvlDeuda.Text = "Anualidad";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(282, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(209, 25);
            lblTitulo.TabIndex = 61;
            lblTitulo.Text = "Anualidad Vencida";
            // 
            // cbCalcular
            // 
            cbCalcular.FormattingEnabled = true;
            cbCalcular.Items.AddRange(new object[] { "Valor Presente", "Valor Futuro" });
            cbCalcular.Location = new Point(486, 121);
            cbCalcular.Name = "cbCalcular";
            cbCalcular.Size = new Size(210, 23);
            cbCalcular.TabIndex = 71;
            cbCalcular.Text = "Seleccionar...";
            // 
            // lblSeleccion
            // 
            lblSeleccion.AutoSize = true;
            lblSeleccion.Location = new Point(423, 124);
            lblSeleccion.Name = "lblSeleccion";
            lblSeleccion.Size = new Size(50, 15);
            lblSeleccion.TabIndex = 72;
            lblSeleccion.Text = "Calcular";
            // 
            // lblResulado
            // 
            lblResulado.AutoSize = true;
            lblResulado.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblResulado.Location = new Point(486, 164);
            lblResulado.Name = "lblResulado";
            lblResulado.Size = new Size(45, 17);
            lblResulado.TabIndex = 73;
            lblResulado.Text = "label1";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(486, 197);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(210, 23);
            txtResultado.TabIndex = 74;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // pnlDiagrama
            // 
            pnlDiagrama.Location = new Point(38, 312);
            pnlDiagrama.Name = "pnlDiagrama";
            pnlDiagrama.Size = new Size(658, 318);
            pnlDiagrama.TabIndex = 75;
            pnlDiagrama.Paint += pnlDiagrama_Paint;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(409, 86);
            label.Name = "label";
            label.Size = new Size(64, 15);
            label.TabIndex = 76;
            label.Text = "Frecuencia";
            // 
            // cbFrecuencia
            // 
            cbFrecuencia.FormattingEnabled = true;
            cbFrecuencia.Items.AddRange(new object[] { "Semestral", "Trimestral", "Mensual" });
            cbFrecuencia.Location = new Point(486, 83);
            cbFrecuencia.Name = "cbFrecuencia";
            cbFrecuencia.Size = new Size(210, 23);
            cbFrecuencia.TabIndex = 77;
            cbFrecuencia.Text = "Seleccionar...";
            // 
            // FrmAnualidad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 666);
            Controls.Add(txtPagos);
            Controls.Add(cbFrecuencia);
            Controls.Add(label);
            Controls.Add(pnlDiagrama);
            Controls.Add(txtResultado);
            Controls.Add(lblResulado);
            Controls.Add(lblSeleccion);
            Controls.Add(cbCalcular);
            Controls.Add(bntLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(lblTiempo);
            Controls.Add(txtTasa);
            Controls.Add(lblInteres);
            Controls.Add(txtAnualidad);
            Controls.Add(lvlDeuda);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAnualidad";
            Text = "Anualidad";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPago;
        private Button bntLimpiar;
        private Button btnCalcular;
        private TextBox txtPagos;
        private Label lblTiempo;
        private TextBox txtTasa;
        private Label lblInteres;
        private TextBox txtAnualidad;
        private Label lvlDeuda;
        private Label lblTitulo;
        private ComboBox cbCalcular;
        private Label lblSeleccion;
        private Label lblResulado;
        private TextBox txtResultado;
        private ErrorProvider errorProvider;
        private Panel pnlDiagrama;
        private ComboBox cbFrecuencia;
        private Label label;
    }
}