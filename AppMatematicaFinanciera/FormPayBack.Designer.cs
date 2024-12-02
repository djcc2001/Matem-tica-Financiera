namespace AppMatematicaFinanciera
{
    partial class FormPayBack
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
            txtPb = new TextBox();
            label1 = new Label();
            dgvDatos = new DataGridView();
            clmPeriodo = new DataGridViewTextBoxColumn();
            clmEgresos = new DataGridViewTextBoxColumn();
            clmIngresos = new DataGridViewTextBoxColumn();
            btnGenerar = new Button();
            txtPeriodo = new TextBox();
            lblPeriodo = new Label();
            lblTitulo = new Label();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // bntLimpiar
            // 
            bntLimpiar.BackColor = Color.Red;
            bntLimpiar.Font = new Font("Sitka Display", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            bntLimpiar.ForeColor = Color.White;
            bntLimpiar.Location = new Point(61, 589);
            bntLimpiar.Name = "bntLimpiar";
            bntLimpiar.Size = new Size(87, 42);
            bntLimpiar.TabIndex = 97;
            bntLimpiar.Text = "Limpiar";
            bntLimpiar.UseVisualStyleBackColor = false;
            bntLimpiar.Click += bntLimpiar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Lime;
            btnCalcular.Font = new Font("Sitka Text", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcular.ForeColor = Color.Black;
            btnCalcular.Location = new Point(175, 588);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(102, 42);
            btnCalcular.TabIndex = 96;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtPb
            // 
            txtPb.Location = new Point(387, 607);
            txtPb.Name = "txtPb";
            txtPb.ReadOnly = true;
            txtPb.Size = new Size(309, 23);
            txtPb.TabIndex = 95;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(387, 574);
            label1.Name = "label1";
            label1.Size = new Size(74, 21);
            label1.TabIndex = 94;
            label1.Text = "PayBack";
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { clmPeriodo, clmEgresos, clmIngresos });
            dgvDatos.Location = new Point(24, 109);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.Size = new Size(692, 445);
            dgvDatos.TabIndex = 93;
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
            clmEgresos.HeaderText = "Flujo de Caja";
            clmEgresos.Name = "clmEgresos";
            // 
            // clmIngresos
            // 
            clmIngresos.HeaderText = "Flujo de Caja Acumulado";
            clmIngresos.Name = "clmIngresos";
            clmIngresos.ReadOnly = true;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(510, 60);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(75, 23);
            btnGenerar.TabIndex = 92;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // txtPeriodo
            // 
            txtPeriodo.Location = new Point(254, 61);
            txtPeriodo.Name = "txtPeriodo";
            txtPeriodo.Size = new Size(216, 23);
            txtPeriodo.TabIndex = 91;
            txtPeriodo.KeyPress += txtPeriodo_KeyPress;
            // 
            // lblPeriodo
            // 
            lblPeriodo.AutoSize = true;
            lblPeriodo.Location = new Point(179, 64);
            lblPeriodo.Name = "lblPeriodo";
            lblPeriodo.Size = new Size(48, 15);
            lblPeriodo.TabIndex = 90;
            lblPeriodo.Text = "Periodo";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(319, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(104, 25);
            lblTitulo.TabIndex = 89;
            lblTitulo.Text = "PayBack";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormPayBack
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 666);
            Controls.Add(bntLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(txtPb);
            Controls.Add(label1);
            Controls.Add(dgvDatos);
            Controls.Add(btnGenerar);
            Controls.Add(txtPeriodo);
            Controls.Add(lblPeriodo);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPayBack";
            Text = "PayBack";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bntLimpiar;
        private Button btnCalcular;
        private TextBox txtPb;
        private Label label1;
        private DataGridView dgvDatos;
        private Button btnGenerar;
        private TextBox txtPeriodo;
        private Label lblPeriodo;
        private Label lblTitulo;
        private ErrorProvider errorProvider;
        private DataGridViewTextBoxColumn clmPeriodo;
        private DataGridViewTextBoxColumn clmEgresos;
        private DataGridViewTextBoxColumn clmIngresos;
    }
}