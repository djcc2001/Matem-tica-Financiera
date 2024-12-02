namespace AppMatematicaFinanciera
{
    partial class FormDepreciacion
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
            label1 = new Label();
            txtDepreciacion = new TextBox();
            dgvDatos = new DataGridView();
            clmAnio = new DataGridViewTextBoxColumn();
            clmCuota = new DataGridViewTextBoxColumn();
            clmInteres = new DataGridViewTextBoxColumn();
            clmAmortizacion = new DataGridViewTextBoxColumn();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            bntLimpiar = new Button();
            btnCalcular = new Button();
            txtVida = new TextBox();
            lblTiempo = new Label();
            txtValor = new TextBox();
            lblInteres = new Label();
            txtCoto = new TextBox();
            lvlDeuda = new Label();
            lblTitulo = new Label();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 211);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 73;
            label1.Text = "Depreciación";
            // 
            // txtDepreciacion
            // 
            txtDepreciacion.Location = new Point(117, 208);
            txtDepreciacion.Name = "txtDepreciacion";
            txtDepreciacion.ReadOnly = true;
            txtDepreciacion.Size = new Size(210, 23);
            txtDepreciacion.TabIndex = 72;
            txtDepreciacion.TextAlign = HorizontalAlignment.Right;
            // 
            // dgvDatos
            // 
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { clmAnio, clmCuota, clmInteres, clmAmortizacion });
            dgvDatos.Location = new Point(33, 321);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.Size = new Size(687, 333);
            dgvDatos.TabIndex = 71;
            // 
            // clmAnio
            // 
            clmAnio.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            clmAnio.HeaderText = "Año";
            clmAnio.Name = "clmAnio";
            clmAnio.ReadOnly = true;
            clmAnio.Width = 54;
            // 
            // clmCuota
            // 
            clmCuota.HeaderText = "Valor en Libros";
            clmCuota.Name = "clmCuota";
            clmCuota.ReadOnly = true;
            // 
            // clmInteres
            // 
            clmInteres.HeaderText = "Depreciación";
            clmInteres.Name = "clmInteres";
            clmInteres.ReadOnly = true;
            // 
            // clmAmortizacion
            // 
            clmAmortizacion.HeaderText = "Depreciacion Acumulada";
            clmAmortizacion.Name = "clmAmortizacion";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(364, 72);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(356, 219);
            chart1.TabIndex = 70;
            chart1.Text = "chart1";
            // 
            // bntLimpiar
            // 
            bntLimpiar.BackColor = Color.Red;
            bntLimpiar.Font = new Font("Sitka Display", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            bntLimpiar.ForeColor = Color.White;
            bntLimpiar.Location = new Point(117, 250);
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
            btnCalcular.Location = new Point(225, 249);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(102, 42);
            btnCalcular.TabIndex = 68;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtVida
            // 
            txtVida.Location = new Point(117, 163);
            txtVida.Name = "txtVida";
            txtVida.Size = new Size(210, 23);
            txtVida.TabIndex = 67;
            txtVida.TextAlign = HorizontalAlignment.Right;
            txtVida.KeyPress += txtVida_KeyPress;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(50, 166);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(51, 15);
            lblTiempo.TabIndex = 66;
            lblTiempo.Text = "Vida Util";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(117, 118);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(210, 23);
            txtValor.TabIndex = 65;
            txtValor.TextAlign = HorizontalAlignment.Right;
            // 
            // lblInteres
            // 
            lblInteres.AutoSize = true;
            lblInteres.Location = new Point(9, 121);
            lblInteres.Name = "lblInteres";
            lblInteres.Size = new Size(92, 15);
            lblInteres.TabIndex = 64;
            lblInteres.Text = "Valor de Rescate";
            // 
            // txtCoto
            // 
            txtCoto.Location = new Point(117, 77);
            txtCoto.Name = "txtCoto";
            txtCoto.Size = new Size(210, 23);
            txtCoto.TabIndex = 63;
            txtCoto.TextAlign = HorizontalAlignment.Right;
            // 
            // lvlDeuda
            // 
            lvlDeuda.AutoSize = true;
            lvlDeuda.Location = new Point(35, 80);
            lvlDeuda.Name = "lvlDeuda";
            lvlDeuda.Size = new Size(66, 15);
            lvlDeuda.TabIndex = 62;
            lvlDeuda.Text = "Costo Total";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(276, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(150, 25);
            lblTitulo.TabIndex = 61;
            lblTitulo.Text = "Depreciación";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormDepreciacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 666);
            Controls.Add(label1);
            Controls.Add(txtDepreciacion);
            Controls.Add(dgvDatos);
            Controls.Add(chart1);
            Controls.Add(bntLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(txtVida);
            Controls.Add(lblTiempo);
            Controls.Add(txtValor);
            Controls.Add(lblInteres);
            Controls.Add(txtCoto);
            Controls.Add(lvlDeuda);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDepreciacion";
            Text = "FormDepreciacion";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDepreciacion;
        private DataGridView dgvDatos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button bntLimpiar;
        private Button btnCalcular;
        private TextBox txtVida;
        private Label lblTiempo;
        private TextBox txtValor;
        private Label lblInteres;
        private TextBox txtCoto;
        private Label lvlDeuda;
        private Label lblTitulo;
        private DataGridViewTextBoxColumn clmAnio;
        private DataGridViewTextBoxColumn clmCuota;
        private DataGridViewTextBoxColumn clmInteres;
        private DataGridViewTextBoxColumn clmAmortizacion;
        private ErrorProvider errorProvider;
    }
}