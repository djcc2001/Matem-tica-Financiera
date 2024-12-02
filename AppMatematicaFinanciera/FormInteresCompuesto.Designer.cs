namespace AppMatematicaFinanciera
{
    partial class FrmInteresCompuesto
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            dgtvReporte = new DataGridView();
            clmPeriodo = new DataGridViewTextBoxColumn();
            clmInteresSimple = new DataGridViewTextBoxColumn();
            clmValorFuturo = new DataGridViewTextBoxColumn();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            bntLimpiar = new Button();
            txtMonto = new TextBox();
            txtInteres = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnCalcular = new Button();
            txtPeriodo = new TextBox();
            tbtPeriodo = new Label();
            txtTEA = new TextBox();
            lblTea = new Label();
            groupBox1 = new GroupBox();
            rbtnAnual = new RadioButton();
            rbtnDiario = new RadioButton();
            rbtnMensual = new RadioButton();
            txtCapital = new TextBox();
            lblMonto = new Label();
            lblTitulo = new Label();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgtvReporte).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // dgtvReporte
            // 
            dgtvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgtvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgtvReporte.Columns.AddRange(new DataGridViewColumn[] { clmPeriodo, clmInteresSimple, clmValorFuturo });
            dgtvReporte.Location = new Point(26, 364);
            dgtvReporte.Name = "dgtvReporte";
            dgtvReporte.RowTemplate.Height = 25;
            dgtvReporte.Size = new Size(687, 292);
            dgtvReporte.TabIndex = 34;
            // 
            // clmPeriodo
            // 
            clmPeriodo.HeaderText = "Periodo (n)";
            clmPeriodo.Name = "clmPeriodo";
            clmPeriodo.ReadOnly = true;
            // 
            // clmInteresSimple
            // 
            clmInteresSimple.HeaderText = "Interes Simple (I)";
            clmInteresSimple.Name = "clmInteresSimple";
            clmInteresSimple.ReadOnly = true;
            // 
            // clmValorFuturo
            // 
            clmValorFuturo.HeaderText = "Valor Futuro (F)";
            clmValorFuturo.Name = "clmValorFuturo";
            clmValorFuturo.ReadOnly = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(412, 142);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(301, 206);
            chart1.TabIndex = 33;
            chart1.Text = "chart1";
            // 
            // bntLimpiar
            // 
            bntLimpiar.BackColor = Color.Red;
            bntLimpiar.Font = new Font("Sitka Display", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            bntLimpiar.ForeColor = Color.White;
            bntLimpiar.Location = new Point(101, 306);
            bntLimpiar.Name = "bntLimpiar";
            bntLimpiar.Size = new Size(87, 42);
            bntLimpiar.TabIndex = 32;
            bntLimpiar.Text = "Limpiar";
            bntLimpiar.UseVisualStyleBackColor = false;
            bntLimpiar.Click += bntLimpiar_Click;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(477, 102);
            txtMonto.Name = "txtMonto";
            txtMonto.ReadOnly = true;
            txtMonto.Size = new Size(236, 23);
            txtMonto.TabIndex = 31;
            txtMonto.TextAlign = HorizontalAlignment.Right;
            // 
            // txtInteres
            // 
            txtInteres.Location = new Point(477, 61);
            txtInteres.Name = "txtInteres";
            txtInteres.ReadOnly = true;
            txtInteres.Size = new Size(236, 23);
            txtInteres.TabIndex = 30;
            txtInteres.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(406, 69);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 29;
            label2.Text = "Interes S/.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(409, 110);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 28;
            label1.Text = "Monto S/.";
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Lime;
            btnCalcular.Font = new Font("Sitka Text", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcular.ForeColor = Color.Black;
            btnCalcular.Location = new Point(260, 306);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(102, 42);
            btnCalcular.TabIndex = 27;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtPeriodo
            // 
            txtPeriodo.Location = new Point(110, 256);
            txtPeriodo.Name = "txtPeriodo";
            txtPeriodo.Size = new Size(252, 23);
            txtPeriodo.TabIndex = 26;
            txtPeriodo.TextAlign = HorizontalAlignment.Right;
            txtPeriodo.KeyPress += txtPeriodo_KeyPress;
            // 
            // tbtPeriodo
            // 
            tbtPeriodo.AutoSize = true;
            tbtPeriodo.Location = new Point(39, 259);
            tbtPeriodo.Name = "tbtPeriodo";
            tbtPeriodo.Size = new Size(48, 15);
            tbtPeriodo.TabIndex = 25;
            tbtPeriodo.Text = "Periodo";
            // 
            // txtTEA
            // 
            txtTEA.Location = new Point(110, 204);
            txtTEA.Name = "txtTEA";
            txtTEA.Size = new Size(252, 23);
            txtTEA.TabIndex = 24;
            txtTEA.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTea
            // 
            lblTea.AutoSize = true;
            lblTea.Location = new Point(60, 207);
            lblTea.Name = "lblTea";
            lblTea.Size = new Size(27, 15);
            lblTea.TabIndex = 23;
            lblTea.Text = "TEA";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnAnual);
            groupBox1.Controls.Add(rbtnDiario);
            groupBox1.Controls.Add(rbtnMensual);
            groupBox1.Location = new Point(26, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(336, 75);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Periodo";
            // 
            // rbtnAnual
            // 
            rbtnAnual.AutoSize = true;
            rbtnAnual.Location = new Point(256, 34);
            rbtnAnual.Name = "rbtnAnual";
            rbtnAnual.Size = new Size(56, 19);
            rbtnAnual.TabIndex = 4;
            rbtnAnual.TabStop = true;
            rbtnAnual.Text = "Anual";
            rbtnAnual.UseVisualStyleBackColor = true;
            // 
            // rbtnDiario
            // 
            rbtnDiario.AutoSize = true;
            rbtnDiario.Location = new Point(36, 34);
            rbtnDiario.Name = "rbtnDiario";
            rbtnDiario.Size = new Size(56, 19);
            rbtnDiario.TabIndex = 4;
            rbtnDiario.TabStop = true;
            rbtnDiario.Text = "Diario";
            rbtnDiario.UseVisualStyleBackColor = true;
            // 
            // rbtnMensual
            // 
            rbtnMensual.AutoSize = true;
            rbtnMensual.Location = new Point(143, 34);
            rbtnMensual.Name = "rbtnMensual";
            rbtnMensual.Size = new Size(70, 19);
            rbtnMensual.TabIndex = 0;
            rbtnMensual.TabStop = true;
            rbtnMensual.Text = "Mensual";
            rbtnMensual.UseVisualStyleBackColor = true;
            // 
            // txtCapital
            // 
            txtCapital.Location = new Point(110, 61);
            txtCapital.Name = "txtCapital";
            txtCapital.Size = new Size(252, 23);
            txtCapital.TabIndex = 21;
            txtCapital.TextAlign = HorizontalAlignment.Right;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(26, 64);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(61, 15);
            lblMonto.TabIndex = 20;
            lblMonto.Text = "Capital S/.";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(218, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(328, 25);
            lblTitulo.TabIndex = 19;
            lblTitulo.Text = "Cálculo de Interes Compuesto";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FrmInteresCompuesto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 666);
            Controls.Add(dgtvReporte);
            Controls.Add(chart1);
            Controls.Add(bntLimpiar);
            Controls.Add(txtMonto);
            Controls.Add(txtInteres);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCalcular);
            Controls.Add(txtPeriodo);
            Controls.Add(tbtPeriodo);
            Controls.Add(txtTEA);
            Controls.Add(lblTea);
            Controls.Add(groupBox1);
            Controls.Add(txtCapital);
            Controls.Add(lblMonto);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmInteresCompuesto";
            Text = "Interes Compuesto";
            ((System.ComponentModel.ISupportInitialize)dgtvReporte).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgtvReporte;
        private DataGridViewTextBoxColumn clmPeriodo;
        private DataGridViewTextBoxColumn clmInteresSimple;
        private DataGridViewTextBoxColumn clmValorFuturo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button bntLimpiar;
        private TextBox txtMonto;
        private TextBox txtInteres;
        private Label label2;
        private Label label1;
        private Button btnCalcular;
        private TextBox txtPeriodo;
        private Label tbtPeriodo;
        private TextBox txtTEA;
        private Label lblTea;
        private GroupBox groupBox1;
        private RadioButton rbtnAnual;
        private RadioButton rbtnDiario;
        private RadioButton rbtnMensual;
        private TextBox txtCapital;
        private Label lblMonto;
        private Label lblTitulo;
        private ErrorProvider errorProvider;
    }
}