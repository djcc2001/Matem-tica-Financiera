namespace AppMatematicaFinanciera
{
    partial class FormVan
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
            lblPeriodo = new Label();
            txtPeriodo = new TextBox();
            btnGenerar = new Button();
            dgvDatos = new DataGridView();
            clmPeriodo = new DataGridViewTextBoxColumn();
            clmEgresos = new DataGridViewTextBoxColumn();
            clmIngresos = new DataGridViewTextBoxColumn();
            clmFlujoNeto = new DataGridViewTextBoxColumn();
            lblTasa = new Label();
            txtTasa = new TextBox();
            bntLimpiar = new Button();
            btnCalcular = new Button();
            label1 = new Label();
            txtVan = new TextBox();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(272, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(196, 25);
            lblTitulo.TabIndex = 62;
            lblTitulo.Text = "Valor Actual Neto";
            // 
            // lblPeriodo
            // 
            lblPeriodo.AutoSize = true;
            lblPeriodo.Location = new Point(177, 65);
            lblPeriodo.Name = "lblPeriodo";
            lblPeriodo.Size = new Size(48, 15);
            lblPeriodo.TabIndex = 63;
            lblPeriodo.Text = "Periodo";
            // 
            // txtPeriodo
            // 
            txtPeriodo.Location = new Point(252, 62);
            txtPeriodo.Name = "txtPeriodo";
            txtPeriodo.Size = new Size(216, 23);
            txtPeriodo.TabIndex = 64;
            txtPeriodo.KeyPress += txtPeriodo_KeyPress;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(508, 61);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(75, 23);
            btnGenerar.TabIndex = 65;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { clmPeriodo, clmEgresos, clmIngresos, clmFlujoNeto });
            dgvDatos.Location = new Point(22, 110);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.Size = new Size(692, 410);
            dgvDatos.TabIndex = 66;
            dgvDatos.CellPainting += DgvDatos_CellPainting;
            // 
            // clmPeriodo
            // 
            clmPeriodo.HeaderText = "Periodo";
            clmPeriodo.Name = "clmPeriodo";
            clmPeriodo.ReadOnly = true;
            // 
            // clmEgresos
            // 
            clmEgresos.HeaderText = "Egresos";
            clmEgresos.Name = "clmEgresos";
            // 
            // clmIngresos
            // 
            clmIngresos.HeaderText = "Ingresos";
            clmIngresos.Name = "clmIngresos";
            // 
            // clmFlujoNeto
            // 
            clmFlujoNeto.HeaderText = "Flujo Neto";
            clmFlujoNeto.Name = "clmFlujoNeto";
            clmFlujoNeto.ReadOnly = true;
            // 
            // lblTasa
            // 
            lblTasa.AutoSize = true;
            lblTasa.Location = new Point(21, 547);
            lblTasa.Name = "lblTasa";
            lblTasa.Size = new Size(29, 15);
            lblTasa.TabIndex = 67;
            lblTasa.Text = "Tasa";
            // 
            // txtTasa
            // 
            txtTasa.Location = new Point(77, 544);
            txtTasa.Name = "txtTasa";
            txtTasa.Size = new Size(216, 23);
            txtTasa.TabIndex = 68;
            // 
            // bntLimpiar
            // 
            bntLimpiar.BackColor = Color.Red;
            bntLimpiar.Font = new Font("Sitka Display", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            bntLimpiar.ForeColor = Color.White;
            bntLimpiar.Location = new Point(77, 594);
            bntLimpiar.Name = "bntLimpiar";
            bntLimpiar.Size = new Size(87, 42);
            bntLimpiar.TabIndex = 71;
            bntLimpiar.Text = "Limpiar";
            bntLimpiar.UseVisualStyleBackColor = false;
            bntLimpiar.Click += bntLimpiar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Lime;
            btnCalcular.Font = new Font("Sitka Text", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcular.ForeColor = Color.Black;
            btnCalcular.Location = new Point(191, 593);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(102, 42);
            btnCalcular.TabIndex = 70;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(405, 546);
            label1.Name = "label1";
            label1.Size = new Size(149, 21);
            label1.TabIndex = 72;
            label1.Text = "Valor Actual Neto:";
            // 
            // txtVan
            // 
            txtVan.Location = new Point(405, 579);
            txtVan.Name = "txtVan";
            txtVan.ReadOnly = true;
            txtVan.Size = new Size(309, 23);
            txtVan.TabIndex = 73;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormVan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 666);
            Controls.Add(txtVan);
            Controls.Add(label1);
            Controls.Add(bntLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(txtTasa);
            Controls.Add(lblTasa);
            Controls.Add(dgvDatos);
            Controls.Add(btnGenerar);
            Controls.Add(txtPeriodo);
            Controls.Add(lblPeriodo);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormVan";
            Text = "VAN";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblPeriodo;
        private TextBox txtPeriodo;
        private Button btnGenerar;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn clmPeriodo;
        private DataGridViewTextBoxColumn clmEgresos;
        private DataGridViewTextBoxColumn clmIngresos;
        private DataGridViewTextBoxColumn clmFlujoNeto;
        private Label lblTasa;
        private TextBox txtTasa;
        private Button bntLimpiar;
        private Button btnCalcular;
        private Label label1;
        private TextBox txtVan;
        private ErrorProvider errorProvider;
    }
}