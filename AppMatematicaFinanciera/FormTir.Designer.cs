namespace AppMatematicaFinanciera
{
    partial class FormTir
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
            txtTir = new TextBox();
            label1 = new Label();
            dgvDatos = new DataGridView();
            clmPeriodo = new DataGridViewTextBoxColumn();
            clmEgresos = new DataGridViewTextBoxColumn();
            clmIngresos = new DataGridViewTextBoxColumn();
            clmFlujoNeto = new DataGridViewTextBoxColumn();
            btnGenerar = new Button();
            txtPeriodo = new TextBox();
            lblPeriodo = new Label();
            lblTitulo = new Label();
            errorProvider = new ErrorProvider(components);
            bntLimpiar = new Button();
            btnCalcular = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // txtTir
            // 
            txtTir.Location = new Point(386, 608);
            txtTir.Name = "txtTir";
            txtTir.ReadOnly = true;
            txtTir.Size = new Size(309, 23);
            txtTir.TabIndex = 84;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(386, 575);
            label1.Name = "label1";
            label1.Size = new Size(194, 21);
            label1.TabIndex = 83;
            label1.Text = "Tasa Interna de Retorno:";
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { clmPeriodo, clmEgresos, clmIngresos, clmFlujoNeto });
            dgvDatos.Location = new Point(23, 110);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.Size = new Size(692, 445);
            dgvDatos.TabIndex = 78;
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
            // btnGenerar
            // 
            btnGenerar.Location = new Point(509, 61);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(75, 23);
            btnGenerar.TabIndex = 77;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // txtPeriodo
            // 
            txtPeriodo.Location = new Point(253, 62);
            txtPeriodo.Name = "txtPeriodo";
            txtPeriodo.Size = new Size(216, 23);
            txtPeriodo.TabIndex = 76;
            txtPeriodo.KeyPress += txtPeriodo_KeyPress;
            // 
            // lblPeriodo
            // 
            lblPeriodo.AutoSize = true;
            lblPeriodo.Location = new Point(178, 65);
            lblPeriodo.Name = "lblPeriodo";
            lblPeriodo.Size = new Size(48, 15);
            lblPeriodo.TabIndex = 75;
            lblPeriodo.Text = "Periodo";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(237, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(267, 25);
            lblTitulo.TabIndex = 74;
            lblTitulo.Text = "Tasa Interna de Retorno";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // bntLimpiar
            // 
            bntLimpiar.BackColor = Color.Red;
            bntLimpiar.Font = new Font("Sitka Display", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            bntLimpiar.ForeColor = Color.White;
            bntLimpiar.Location = new Point(60, 590);
            bntLimpiar.Name = "bntLimpiar";
            bntLimpiar.Size = new Size(87, 42);
            bntLimpiar.TabIndex = 88;
            bntLimpiar.Text = "Limpiar";
            bntLimpiar.UseVisualStyleBackColor = false;
            bntLimpiar.Click += bntLimpiar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Lime;
            btnCalcular.Font = new Font("Sitka Text", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcular.ForeColor = Color.Black;
            btnCalcular.Location = new Point(174, 589);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(102, 42);
            btnCalcular.TabIndex = 87;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // FormTir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 666);
            Controls.Add(bntLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(txtTir);
            Controls.Add(label1);
            Controls.Add(dgvDatos);
            Controls.Add(btnGenerar);
            Controls.Add(txtPeriodo);
            Controls.Add(lblPeriodo);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTir";
            Text = "TRI";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTir;
        private Label label1;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn clmPeriodo;
        private DataGridViewTextBoxColumn clmEgresos;
        private DataGridViewTextBoxColumn clmIngresos;
        private DataGridViewTextBoxColumn clmFlujoNeto;
        private Button btnGenerar;
        private TextBox txtPeriodo;
        private Label lblPeriodo;
        private Label lblTitulo;
        private ErrorProvider errorProvider;
        private Button bntLimpiar;
        private Button btnCalcular;
    }
}