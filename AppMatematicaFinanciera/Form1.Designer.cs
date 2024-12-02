namespace AppMatematicaFinanciera
{
    partial class frmVentanaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentanaPrincipal));
            bntInteresSimple = new Button();
            tsMenu2 = new ToolStrip();
            tsdbOperaciones = new ToolStripDropDownButton();
            interesSimpleToolStripMenuItem = new ToolStripMenuItem();
            interesCompuestoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            tsdbAmortizaciones = new ToolStripDropDownButton();
            sistemaFrancesToolStripMenuItem = new ToolStripMenuItem();
            sistemaAlemanToolStripMenuItem = new ToolStripMenuItem();
            sistemaAmericanoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            anualidadVencidaToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripDropDownButton2 = new ToolStripDropDownButton();
            gradienteAritmeticaToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripDropDownButton3 = new ToolStripDropDownButton();
            eToolStripMenuItem = new ToolStripMenuItem();
            tIRToolStripMenuItem = new ToolStripMenuItem();
            payBackToolStripMenuItem = new ToolStripMenuItem();
            tsMenu = new ToolStripMenuItem();
            panelBase = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripButton();
            tsMenu2.SuspendLayout();
            panelBase.SuspendLayout();
            SuspendLayout();
            // 
            // bntInteresSimple
            // 
            bntInteresSimple.Location = new Point(0, 0);
            bntInteresSimple.Name = "bntInteresSimple";
            bntInteresSimple.Size = new Size(75, 23);
            bntInteresSimple.TabIndex = 3;
            // 
            // tsMenu2
            // 
            tsMenu2.Items.AddRange(new ToolStripItem[] { tsdbOperaciones, toolStripSeparator1, tsdbAmortizaciones, toolStripSeparator2, toolStripDropDownButton1, toolStripSeparator3, toolStripDropDownButton2, toolStripSeparator4, toolStripDropDownButton3, toolStripSeparator5, toolStripButton1 });
            tsMenu2.Location = new Point(0, 0);
            tsMenu2.Name = "tsMenu2";
            tsMenu2.Size = new Size(744, 25);
            tsMenu2.TabIndex = 2;
            tsMenu2.Text = "toolStrip1";
            // 
            // tsdbOperaciones
            // 
            tsdbOperaciones.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsdbOperaciones.DropDownItems.AddRange(new ToolStripItem[] { interesSimpleToolStripMenuItem, interesCompuestoToolStripMenuItem });
            tsdbOperaciones.Image = (Image)resources.GetObject("tsdbOperaciones.Image");
            tsdbOperaciones.ImageTransparentColor = Color.Magenta;
            tsdbOperaciones.Name = "tsdbOperaciones";
            tsdbOperaciones.Size = new Size(55, 22);
            tsdbOperaciones.Text = "Interes";
            tsdbOperaciones.ToolTipText = "Operaciones";
            // 
            // interesSimpleToolStripMenuItem
            // 
            interesSimpleToolStripMenuItem.Name = "interesSimpleToolStripMenuItem";
            interesSimpleToolStripMenuItem.Size = new Size(174, 22);
            interesSimpleToolStripMenuItem.Text = "Interes Simple";
            interesSimpleToolStripMenuItem.Click += interesSimpleToolStripMenuItem_Click;
            // 
            // interesCompuestoToolStripMenuItem
            // 
            interesCompuestoToolStripMenuItem.Name = "interesCompuestoToolStripMenuItem";
            interesCompuestoToolStripMenuItem.Size = new Size(174, 22);
            interesCompuestoToolStripMenuItem.Text = "Interes Compuesto";
            interesCompuestoToolStripMenuItem.Click += interesCompuestoToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // tsdbAmortizaciones
            // 
            tsdbAmortizaciones.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsdbAmortizaciones.DropDownItems.AddRange(new ToolStripItem[] { sistemaFrancesToolStripMenuItem, sistemaAlemanToolStripMenuItem, sistemaAmericanoToolStripMenuItem });
            tsdbAmortizaciones.ForeColor = SystemColors.ActiveCaptionText;
            tsdbAmortizaciones.ImageTransparentColor = Color.Magenta;
            tsdbAmortizaciones.Name = "tsdbAmortizaciones";
            tsdbAmortizaciones.Size = new Size(102, 22);
            tsdbAmortizaciones.Text = "Amortizaciones";
            // 
            // sistemaFrancesToolStripMenuItem
            // 
            sistemaFrancesToolStripMenuItem.Name = "sistemaFrancesToolStripMenuItem";
            sistemaFrancesToolStripMenuItem.Size = new Size(176, 22);
            sistemaFrancesToolStripMenuItem.Text = "Sistema Francés";
            sistemaFrancesToolStripMenuItem.Click += sistemaFrancesToolStripMenuItem_Click;
            // 
            // sistemaAlemanToolStripMenuItem
            // 
            sistemaAlemanToolStripMenuItem.Name = "sistemaAlemanToolStripMenuItem";
            sistemaAlemanToolStripMenuItem.Size = new Size(176, 22);
            sistemaAlemanToolStripMenuItem.Text = "Sistema Alemán";
            sistemaAlemanToolStripMenuItem.Click += sistemaAlemanToolStripMenuItem_Click;
            // 
            // sistemaAmericanoToolStripMenuItem
            // 
            sistemaAmericanoToolStripMenuItem.Name = "sistemaAmericanoToolStripMenuItem";
            sistemaAmericanoToolStripMenuItem.Size = new Size(176, 22);
            sistemaAmericanoToolStripMenuItem.Text = "Sistema Americano";
            sistemaAmericanoToolStripMenuItem.Click += sistemaAmericanoToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { anualidadVencidaToolStripMenuItem1 });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(74, 22);
            toolStripDropDownButton1.Text = "Anualidad";
            // 
            // anualidadVencidaToolStripMenuItem1
            // 
            anualidadVencidaToolStripMenuItem1.Name = "anualidadVencidaToolStripMenuItem1";
            anualidadVencidaToolStripMenuItem1.Size = new Size(172, 22);
            anualidadVencidaToolStripMenuItem1.Text = "Anualidad Vencida";
            anualidadVencidaToolStripMenuItem1.Click += anualidadVencidaToolStripMenuItem1_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // toolStripDropDownButton2
            // 
            toolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton2.DropDownItems.AddRange(new ToolStripItem[] { gradienteAritmeticaToolStripMenuItem });
            toolStripDropDownButton2.Image = (Image)resources.GetObject("toolStripDropDownButton2.Image");
            toolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            toolStripDropDownButton2.Size = new Size(71, 22);
            toolStripDropDownButton2.Text = "Gradiente";
            // 
            // gradienteAritmeticaToolStripMenuItem
            // 
            gradienteAritmeticaToolStripMenuItem.Name = "gradienteAritmeticaToolStripMenuItem";
            gradienteAritmeticaToolStripMenuItem.Size = new Size(184, 22);
            gradienteAritmeticaToolStripMenuItem.Text = "Gradiente Aritmético";
            gradienteAritmeticaToolStripMenuItem.Click += gradienteAritmeticaToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 25);
            // 
            // toolStripDropDownButton3
            // 
            toolStripDropDownButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton3.DropDownItems.AddRange(new ToolStripItem[] { eToolStripMenuItem, tIRToolStripMenuItem, payBackToolStripMenuItem });
            toolStripDropDownButton3.Image = (Image)resources.GetObject("toolStripDropDownButton3.Image");
            toolStripDropDownButton3.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            toolStripDropDownButton3.Size = new Size(96, 22);
            toolStripDropDownButton3.Text = "Eva. Proyectos";
            // 
            // eToolStripMenuItem
            // 
            eToolStripMenuItem.Name = "eToolStripMenuItem";
            eToolStripMenuItem.Size = new Size(180, 22);
            eToolStripMenuItem.Text = "VAN";
            eToolStripMenuItem.Click += eToolStripMenuItem_Click;
            // 
            // tIRToolStripMenuItem
            // 
            tIRToolStripMenuItem.Name = "tIRToolStripMenuItem";
            tIRToolStripMenuItem.Size = new Size(180, 22);
            tIRToolStripMenuItem.Text = "TIR";
            tIRToolStripMenuItem.Click += tIRToolStripMenuItem_Click;
            // 
            // payBackToolStripMenuItem
            // 
            payBackToolStripMenuItem.Name = "payBackToolStripMenuItem";
            payBackToolStripMenuItem.Size = new Size(180, 22);
            payBackToolStripMenuItem.Text = "PayBack";
            payBackToolStripMenuItem.Click += payBackToolStripMenuItem_Click;
            // 
            // tsMenu
            // 
            tsMenu.Name = "tsMenu";
            tsMenu.Size = new Size(180, 22);
            tsMenu.Text = "Interes Simple";
            // 
            // panelBase
            // 
            panelBase.Controls.Add(label3);
            panelBase.Controls.Add(label2);
            panelBase.Controls.Add(label1);
            panelBase.Dock = DockStyle.Fill;
            panelBase.Location = new Point(0, 25);
            panelBase.Name = "panelBase";
            panelBase.Size = new Size(744, 665);
            panelBase.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(91, 284);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(100, 91);
            label2.Name = "label2";
            label2.Size = new Size(507, 147);
            label2.TabIndex = 3;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(230, 24);
            label1.Name = "label1";
            label1.Size = new Size(288, 31);
            label1.TabIndex = 2;
            label1.Text = "Matemática Financiera";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 25);
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(80, 22);
            toolStripButton1.Text = "Depreciación";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // frmVentanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(744, 690);
            Controls.Add(panelBase);
            Controls.Add(tsMenu2);
            Controls.Add(bntInteresSimple);
            Name = "frmVentanaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Matematica Financiera";
            tsMenu2.ResumeLayout(false);
            tsMenu2.PerformLayout();
            panelBase.ResumeLayout(false);
            panelBase.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bntInteresSimple;
        private ToolStrip tsMenu2;
        private ToolStripMenuItem tsMenu;
        private ToolStripDropDownButton tsdbOperaciones;
        private ToolStripMenuItem interesSimpleToolStripMenuItem;
        private Panel panelBase;
        private Label label1;
        private ToolStripMenuItem interesCompuestoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton tsdbAmortizaciones;
        private ToolStripMenuItem sistemaFrancesToolStripMenuItem;
        private ToolStripMenuItem sistemaAlemanToolStripMenuItem;
        private ToolStripMenuItem sistemaAmericanoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem anualidadVencidaToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripMenuItem gradienteAritmeticaToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripDropDownButton toolStripDropDownButton3;
        private ToolStripMenuItem eToolStripMenuItem;
        private ToolStripMenuItem tIRToolStripMenuItem;
        private ToolStripMenuItem payBackToolStripMenuItem;
        private Label label2;
        private Label label3;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton toolStripButton1;
    }
}
