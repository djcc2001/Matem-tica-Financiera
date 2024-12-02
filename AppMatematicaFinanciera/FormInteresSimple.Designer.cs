namespace AppMatematicaFinanciera
{
    partial class FrmInteresSimple
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
            lblTitulo = new Label();
            lblMonto = new Label();
            txtCapital = new TextBox();
            groupBox1 = new GroupBox();
            rbtnAnual = new RadioButton();
            rbtnDiario = new RadioButton();
            rbtnMensual = new RadioButton();
            lblTea = new Label();
            txtTEA = new TextBox();
            tbtPeriodo = new Label();
            txtPeriodo = new TextBox();
            btnCalcular = new Button();
            label1 = new Label();
            label2 = new Label();
            txtInteres = new TextBox();
            txtMonto = new TextBox();
            bntLimpiar = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dgtvReporte = new DataGridView();
            clmPeriodo = new DataGridViewTextBoxColumn();
            clmInteresSimple = new DataGridViewTextBoxColumn();
            clmValorFuturo = new DataGridViewTextBoxColumn();
            errorProvider = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgtvReporte).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Swis721 Blk BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(227, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(308, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cálculo de Interes Simple";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(32, 62);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(61, 15);
            lblMonto.TabIndex = 1;
            lblMonto.Text = "Capital S/.";
            // 
            // txtCapital
            // 
            txtCapital.Location = new Point(116, 59);
            txtCapital.Name = "txtCapital";
            txtCapital.Size = new Size(252, 23);
            txtCapital.TabIndex = 2;
            txtCapital.TextAlign = HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnAnual);
            groupBox1.Controls.Add(rbtnDiario);
            groupBox1.Controls.Add(rbtnMensual);
            groupBox1.Location = new Point(32, 106);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(336, 75);
            groupBox1.TabIndex = 3;
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
            // lblTea
            // 
            lblTea.AutoSize = true;
            lblTea.Location = new Point(66, 205);
            lblTea.Name = "lblTea";
            lblTea.Size = new Size(27, 15);
            lblTea.TabIndex = 4;
            lblTea.Text = "TEA";
            // 
            // txtTEA
            // 
            txtTEA.Location = new Point(116, 202);
            txtTEA.Name = "txtTEA";
            txtTEA.Size = new Size(252, 23);
            txtTEA.TabIndex = 5;
            txtTEA.TextAlign = HorizontalAlignment.Right;
            // 
            // tbtPeriodo
            // 
            tbtPeriodo.AutoSize = true;
            tbtPeriodo.Location = new Point(45, 257);
            tbtPeriodo.Name = "tbtPeriodo";
            tbtPeriodo.Size = new Size(48, 15);
            tbtPeriodo.TabIndex = 6;
            tbtPeriodo.Text = "Periodo";
            // 
            // txtPeriodo
            // 
            txtPeriodo.Location = new Point(116, 254);
            txtPeriodo.Name = "txtPeriodo";
            txtPeriodo.Size = new Size(252, 23);
            txtPeriodo.TabIndex = 7;
            txtPeriodo.TextAlign = HorizontalAlignment.Right;
            txtPeriodo.KeyPress += txtPeriodo_KeyPress;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Lime;
            btnCalcular.Font = new Font("Sitka Text", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcular.ForeColor = Color.Black;
            btnCalcular.Location = new Point(266, 304);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(102, 42);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(415, 108);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 9;
            label1.Text = "Monto S/.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(412, 67);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 10;
            label2.Text = "Interes S/.";
            // 
            // txtInteres
            // 
            txtInteres.Location = new Point(483, 59);
            txtInteres.Name = "txtInteres";
            txtInteres.ReadOnly = true;
            txtInteres.Size = new Size(236, 23);
            txtInteres.TabIndex = 11;
            txtInteres.TextAlign = HorizontalAlignment.Right;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(483, 100);
            txtMonto.Name = "txtMonto";
            txtMonto.ReadOnly = true;
            txtMonto.Size = new Size(236, 23);
            txtMonto.TabIndex = 12;
            txtMonto.TextAlign = HorizontalAlignment.Right;
            // 
            // bntLimpiar
            // 
            bntLimpiar.BackColor = Color.Red;
            bntLimpiar.Font = new Font("Sitka Display", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            bntLimpiar.ForeColor = Color.White;
            bntLimpiar.Location = new Point(107, 304);
            bntLimpiar.Name = "bntLimpiar";
            bntLimpiar.Size = new Size(87, 42);
            bntLimpiar.TabIndex = 13;
            bntLimpiar.Text = "Limpiar";
            bntLimpiar.UseVisualStyleBackColor = false;
            bntLimpiar.Click += bntLimpiar_Click;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(418, 140);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(301, 206);
            chart1.TabIndex = 17;
            chart1.Text = "chart1";
            // 
            // dgtvReporte
            // 
            dgtvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgtvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgtvReporte.Columns.AddRange(new DataGridViewColumn[] { clmPeriodo, clmInteresSimple, clmValorFuturo });
            dgtvReporte.Location = new Point(32, 362);
            dgtvReporte.Name = "dgtvReporte";
            dgtvReporte.RowTemplate.Height = 25;
            dgtvReporte.Size = new Size(687, 292);
            dgtvReporte.TabIndex = 18;
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
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FrmInteresSimple
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
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
            Name = "FrmInteresSimple";
            Text = "Interes Simple";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgtvReporte).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblMonto;
        private TextBox txtCapital;
        private GroupBox groupBox1;
        private RadioButton rbtnMensual;
        private RadioButton rbtnAnual;
        private RadioButton rbtnDiario;
        private Label lblTea;
        private TextBox txtTEA;
        private Label tbtPeriodo;
        private TextBox txtPeriodo;
        private Button btnCalcular;
        private Label label1;
        private Label label2;
        private TextBox txtInteres;
        private TextBox txtMonto;
        private Button bntLimpiar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DataGridView dgtvReporte;
        private DataGridViewTextBoxColumn clmPeriodo;
        private DataGridViewTextBoxColumn clmInteresSimple;
        private DataGridViewTextBoxColumn clmValorFuturo;
        private ErrorProvider errorProvider;
    }
}