﻿namespace AppMatematicaFinanciera
{
    partial class FrmAmortizacionAmericano
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
            clmMes = new DataGridViewTextBoxColumn();
            clmInteres = new DataGridViewTextBoxColumn();
            clmAmortizacion = new DataGridViewTextBoxColumn();
            clmDeuda = new DataGridViewTextBoxColumn();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            bntLimpiar = new Button();
            btnCalcular = new Button();
            lblTitulo = new Label();
            errorProvider = new ErrorProvider(components);
            label1 = new Label();
            txtPago = new TextBox();
            txtTiempo = new TextBox();
            lblTiempo = new Label();
            txtInteres = new TextBox();
            lblInteres = new Label();
            txtDeuda = new TextBox();
            lvlDeuda = new Label();
            ((System.ComponentModel.ISupportInitialize)dgtvReporte).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // dgtvReporte
            // 
            dgtvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgtvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgtvReporte.Columns.AddRange(new DataGridViewColumn[] { clmMes, clmInteres, clmAmortizacion, clmDeuda });
            dgtvReporte.Location = new Point(25, 314);
            dgtvReporte.Name = "dgtvReporte";
            dgtvReporte.RowTemplate.Height = 25;
            dgtvReporte.Size = new Size(687, 333);
            dgtvReporte.TabIndex = 71;
            // 
            // clmMes
            // 
            clmMes.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            clmMes.HeaderText = "Mes";
            clmMes.Name = "clmMes";
            clmMes.ReadOnly = true;
            clmMes.Width = 54;
            // 
            // clmInteres
            // 
            clmInteres.HeaderText = "Interes";
            clmInteres.Name = "clmInteres";
            clmInteres.ReadOnly = true;
            // 
            // clmAmortizacion
            // 
            clmAmortizacion.HeaderText = "Amortizacion";
            clmAmortizacion.Name = "clmAmortizacion";
            // 
            // clmDeuda
            // 
            clmDeuda.HeaderText = "Cuota";
            clmDeuda.Name = "clmDeuda";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(356, 65);
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
            bntLimpiar.Location = new Point(109, 243);
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
            btnCalcular.Location = new Point(217, 242);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(102, 42);
            btnCalcular.TabIndex = 68;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(217, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(357, 25);
            lblTitulo.TabIndex = 61;
            lblTitulo.Text = "Amortización Sistema Americano";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 204);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 79;
            label1.Text = "Pago Mensual";
            // 
            // txtPago
            // 
            txtPago.Location = new Point(109, 201);
            txtPago.Name = "txtPago";
            txtPago.ReadOnly = true;
            txtPago.Size = new Size(210, 23);
            txtPago.TabIndex = 78;
            txtPago.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTiempo
            // 
            txtTiempo.Location = new Point(109, 156);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(210, 23);
            txtTiempo.TabIndex = 77;
            txtTiempo.TextAlign = HorizontalAlignment.Right;
            txtTiempo.KeyPress += txtTiempo_KeyPress;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(46, 159);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(47, 15);
            lblTiempo.TabIndex = 76;
            lblTiempo.Text = "Tiempo";
            // 
            // txtInteres
            // 
            txtInteres.Location = new Point(109, 111);
            txtInteres.Name = "txtInteres";
            txtInteres.Size = new Size(210, 23);
            txtInteres.TabIndex = 75;
            txtInteres.TextAlign = HorizontalAlignment.Right;
            // 
            // lblInteres
            // 
            lblInteres.AutoSize = true;
            lblInteres.Location = new Point(38, 114);
            lblInteres.Name = "lblInteres";
            lblInteres.Size = new Size(55, 15);
            lblInteres.TabIndex = 74;
            lblInteres.Text = "Interes %";
            // 
            // txtDeuda
            // 
            txtDeuda.Location = new Point(109, 70);
            txtDeuda.Name = "txtDeuda";
            txtDeuda.Size = new Size(210, 23);
            txtDeuda.TabIndex = 73;
            txtDeuda.TextAlign = HorizontalAlignment.Right;
            // 
            // lvlDeuda
            // 
            lvlDeuda.AutoSize = true;
            lvlDeuda.Location = new Point(35, 73);
            lvlDeuda.Name = "lvlDeuda";
            lvlDeuda.Size = new Size(58, 15);
            lvlDeuda.TabIndex = 72;
            lvlDeuda.Text = "Deuda S/.";
            // 
            // FrmAmortizacionAmericano
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 666);
            Controls.Add(label1);
            Controls.Add(txtPago);
            Controls.Add(txtTiempo);
            Controls.Add(lblTiempo);
            Controls.Add(txtInteres);
            Controls.Add(lblInteres);
            Controls.Add(txtDeuda);
            Controls.Add(lvlDeuda);
            Controls.Add(dgtvReporte);
            Controls.Add(chart1);
            Controls.Add(bntLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAmortizacionAmericano";
            Text = "Amortización Sistema Americano";
            ((System.ComponentModel.ISupportInitialize)dgtvReporte).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgtvReporte;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button bntLimpiar;
        private Button btnCalcular;
        private Label lblTitulo;
        private ErrorProvider errorProvider;
        private DataGridViewTextBoxColumn clmMes;
        private DataGridViewTextBoxColumn clmInteres;
        private DataGridViewTextBoxColumn clmAmortizacion;
        private DataGridViewTextBoxColumn clmDeuda;
        private Label label1;
        private TextBox txtPago;
        private TextBox txtTiempo;
        private Label lblTiempo;
        private TextBox txtInteres;
        private Label lblInteres;
        private TextBox txtDeuda;
        private Label lvlDeuda;
    }
}