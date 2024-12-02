namespace AppMatematicaFinanciera
{
    partial class FormGradiente
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
            lblTitulo = new Label();
            txtCapital = new TextBox();
            lblCapital = new Label();
            txtPeriodo = new TextBox();
            lblTiempo = new Label();
            txtGradiente = new TextBox();
            lblGradiente = new Label();
            lblSeleccion = new Label();
            cbCalcular = new ComboBox();
            bntLimpiar = new Button();
            btnCalcular = new Button();
            pnlDiagrama = new Panel();
            dgtvReporte = new DataGridView();
            clmN = new DataGridViewTextBoxColumn();
            clmCuota = new DataGridViewTextBoxColumn();
            clmInteres = new DataGridViewTextBoxColumn();
            clmAbono = new DataGridViewTextBoxColumn();
            clmSaldo = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtCuota1 = new TextBox();
            errorProvider = new ErrorProvider(components);
            label2 = new Label();
            label3 = new Label();
            txtVP = new TextBox();
            txtVF = new TextBox();
            lblInteres = new Label();
            txtInteres = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgtvReporte).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(233, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(227, 25);
            lblTitulo.TabIndex = 62;
            lblTitulo.Text = "Gradiente Aritmético";
            // 
            // txtCapital
            // 
            txtCapital.Location = new Point(81, 71);
            txtCapital.Name = "txtCapital";
            txtCapital.Size = new Size(210, 23);
            txtCapital.TabIndex = 65;
            txtCapital.TextAlign = HorizontalAlignment.Right;
            // 
            // lblCapital
            // 
            lblCapital.AutoSize = true;
            lblCapital.Location = new Point(25, 74);
            lblCapital.Name = "lblCapital";
            lblCapital.Size = new Size(44, 15);
            lblCapital.TabIndex = 64;
            lblCapital.Text = "Capital";
            // 
            // txtPeriodo
            // 
            txtPeriodo.Location = new Point(81, 198);
            txtPeriodo.Name = "txtPeriodo";
            txtPeriodo.Size = new Size(210, 23);
            txtPeriodo.TabIndex = 71;
            txtPeriodo.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(21, 201);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(48, 15);
            lblTiempo.TabIndex = 70;
            lblTiempo.Text = "Periodo";
            // 
            // txtGradiente
            // 
            txtGradiente.Location = new Point(81, 129);
            txtGradiente.Name = "txtGradiente";
            txtGradiente.Size = new Size(209, 23);
            txtGradiente.TabIndex = 69;
            txtGradiente.TextAlign = HorizontalAlignment.Right;
            // 
            // lblGradiente
            // 
            lblGradiente.AutoSize = true;
            lblGradiente.Location = new Point(11, 132);
            lblGradiente.Name = "lblGradiente";
            lblGradiente.Size = new Size(58, 15);
            lblGradiente.TabIndex = 68;
            lblGradiente.Text = "Gradiente";
            // 
            // lblSeleccion
            // 
            lblSeleccion.AutoSize = true;
            lblSeleccion.Location = new Point(19, 237);
            lblSeleccion.Name = "lblSeleccion";
            lblSeleccion.Size = new Size(50, 15);
            lblSeleccion.TabIndex = 74;
            lblSeleccion.Text = "Calcular";
            // 
            // cbCalcular
            // 
            cbCalcular.FormattingEnabled = true;
            cbCalcular.Items.AddRange(new object[] { "G.A. Creciente", "G.A. Decreciente" });
            cbCalcular.Location = new Point(81, 234);
            cbCalcular.Name = "cbCalcular";
            cbCalcular.Size = new Size(210, 23);
            cbCalcular.TabIndex = 73;
            cbCalcular.Text = "Seleccionar...";
            // 
            // bntLimpiar
            // 
            bntLimpiar.BackColor = Color.Red;
            bntLimpiar.Font = new Font("Sitka Display", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            bntLimpiar.ForeColor = Color.White;
            bntLimpiar.Location = new Point(81, 273);
            bntLimpiar.Name = "bntLimpiar";
            bntLimpiar.Size = new Size(87, 42);
            bntLimpiar.TabIndex = 76;
            bntLimpiar.Text = "Limpiar";
            bntLimpiar.UseVisualStyleBackColor = false;
            bntLimpiar.Click += bntLimpiar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Lime;
            btnCalcular.Font = new Font("Sitka Text", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcular.ForeColor = Color.Black;
            btnCalcular.Location = new Point(189, 273);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(102, 42);
            btnCalcular.TabIndex = 75;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // pnlDiagrama
            // 
            pnlDiagrama.Location = new Point(309, 73);
            pnlDiagrama.Name = "pnlDiagrama";
            pnlDiagrama.Size = new Size(418, 242);
            pnlDiagrama.TabIndex = 77;
            pnlDiagrama.Paint += pnlDiagrama_Paint;
            // 
            // dgtvReporte
            // 
            dgtvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgtvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgtvReporte.Columns.AddRange(new DataGridViewColumn[] { clmN, clmCuota, clmInteres, clmAbono, clmSaldo });
            dgtvReporte.Location = new Point(20, 365);
            dgtvReporte.Name = "dgtvReporte";
            dgtvReporte.RowTemplate.Height = 25;
            dgtvReporte.Size = new Size(707, 286);
            dgtvReporte.TabIndex = 78;
            // 
            // clmN
            // 
            clmN.HeaderText = "N";
            clmN.Name = "clmN";
            clmN.ReadOnly = true;
            // 
            // clmCuota
            // 
            clmCuota.HeaderText = "Cuota";
            clmCuota.Name = "clmCuota";
            clmCuota.ReadOnly = true;
            // 
            // clmInteres
            // 
            clmInteres.HeaderText = "Interes";
            clmInteres.Name = "clmInteres";
            clmInteres.ReadOnly = true;
            // 
            // clmAbono
            // 
            clmAbono.HeaderText = "Abono";
            clmAbono.Name = "clmAbono";
            clmAbono.ReadOnly = true;
            // 
            // clmSaldo
            // 
            clmSaldo.HeaderText = "Saldo";
            clmSaldo.Name = "clmSaldo";
            clmSaldo.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 103);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 79;
            label1.Text = "1° Cuota";
            // 
            // txtCuota1
            // 
            txtCuota1.Location = new Point(81, 100);
            txtCuota1.Name = "txtCuota1";
            txtCuota1.Size = new Size(210, 23);
            txtCuota1.TabIndex = 80;
            txtCuota1.TextAlign = HorizontalAlignment.Right;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(139, 332);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 81;
            label2.Text = "Valor Presente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(451, 332);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 82;
            label3.Text = "Valor Futuro";
            // 
            // txtVP
            // 
            txtVP.Location = new Point(233, 329);
            txtVP.Name = "txtVP";
            txtVP.ReadOnly = true;
            txtVP.Size = new Size(172, 23);
            txtVP.TabIndex = 83;
            // 
            // txtVF
            // 
            txtVF.Location = new Point(532, 329);
            txtVF.Name = "txtVF";
            txtVF.ReadOnly = true;
            txtVF.Size = new Size(194, 23);
            txtVF.TabIndex = 84;
            // 
            // lblInteres
            // 
            lblInteres.AutoSize = true;
            lblInteres.Location = new Point(30, 167);
            lblInteres.Name = "lblInteres";
            lblInteres.Size = new Size(42, 15);
            lblInteres.TabIndex = 0;
            lblInteres.Text = "Interes";
            // 
            // txtInteres
            // 
            txtInteres.Location = new Point(81, 164);
            txtInteres.Name = "txtInteres";
            txtInteres.Size = new Size(209, 23);
            txtInteres.TabIndex = 85;
            txtInteres.TextAlign = HorizontalAlignment.Right;
            // 
            // FormGradiente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 666);
            Controls.Add(txtInteres);
            Controls.Add(lblInteres);
            Controls.Add(txtVF);
            Controls.Add(txtVP);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCuota1);
            Controls.Add(label1);
            Controls.Add(dgtvReporte);
            Controls.Add(pnlDiagrama);
            Controls.Add(bntLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(lblSeleccion);
            Controls.Add(cbCalcular);
            Controls.Add(txtPeriodo);
            Controls.Add(lblTiempo);
            Controls.Add(txtGradiente);
            Controls.Add(lblGradiente);
            Controls.Add(txtCapital);
            Controls.Add(lblCapital);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGradiente";
            Text = "Gradiente Creciente";
            ((System.ComponentModel.ISupportInitialize)dgtvReporte).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtCapital;
        private Label lblCapital;
        private TextBox txtPeriodo;
        private Label lblTiempo;
        private TextBox txtGradiente;
        private Label lblGradiente;
        private Label lblSeleccion;
        private ComboBox cbCalcular;
        private Button bntLimpiar;
        private Button btnCalcular;
        private Panel pnlDiagrama;
        private DataGridView dgtvReporte;
        private Label label1;
        private TextBox txtCuota1;
        private DataGridViewTextBoxColumn clmN;
        private DataGridViewTextBoxColumn clmCuota;
        private DataGridViewTextBoxColumn clmInteres;
        private DataGridViewTextBoxColumn clmAbono;
        private DataGridViewTextBoxColumn clmSaldo;
        private ErrorProvider errorProvider;
        private TextBox txtVF;
        private TextBox txtVP;
        private Label label3;
        private Label label2;
        private TextBox txtInteres;
        private Label lblInteres;
    }
}