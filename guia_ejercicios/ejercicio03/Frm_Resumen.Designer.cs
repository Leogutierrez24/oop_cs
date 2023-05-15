namespace ejercicio03
{
    partial class Frm_Resumen
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cafeMasVendido_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cafeMenosVendido_lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cafeMasRecaudacion_lbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cafeMenosRecaudacion_lbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cafeteraMenosRecaudacion_lbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cafeteraMasRecaudacion_lbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cafeteraMenosSirvio_lbl = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cafeteraMasSirvio_lbl = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cafeteraVentas_listBox = new System.Windows.Forms.ListBox();
            this.cafeteraRecaudacion_listBox = new System.Windows.Forms.ListBox();
            this.cafeVentas_listBox = new System.Windows.Forms.ListBox();
            this.cafeRecaudacion_listBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cafeRecaudacion_listBox);
            this.groupBox1.Controls.Add(this.cafeMenosRecaudacion_lbl);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.cafeVentas_listBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.cafeMasRecaudacion_lbl);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cafeMenosVendido_lbl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cafeMasVendido_lbl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 411);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cafes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cafe más servido:";
            // 
            // cafeMasVendido_lbl
            // 
            this.cafeMasVendido_lbl.AutoSize = true;
            this.cafeMasVendido_lbl.Location = new System.Drawing.Point(103, 26);
            this.cafeMasVendido_lbl.Name = "cafeMasVendido_lbl";
            this.cafeMasVendido_lbl.Size = new System.Drawing.Size(50, 13);
            this.cafeMasVendido_lbl.TabIndex = 1;
            this.cafeMasVendido_lbl.Text = "resultado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cafe menos servido:";
            // 
            // cafeMenosVendido_lbl
            // 
            this.cafeMenosVendido_lbl.AutoSize = true;
            this.cafeMenosVendido_lbl.Location = new System.Drawing.Point(115, 54);
            this.cafeMenosVendido_lbl.Name = "cafeMenosVendido_lbl";
            this.cafeMenosVendido_lbl.Size = new System.Drawing.Size(50, 13);
            this.cafeMenosVendido_lbl.TabIndex = 3;
            this.cafeMenosVendido_lbl.Text = "resultado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cafe con más recaudación:";
            // 
            // cafeMasRecaudacion_lbl
            // 
            this.cafeMasRecaudacion_lbl.AutoSize = true;
            this.cafeMasRecaudacion_lbl.Location = new System.Drawing.Point(149, 82);
            this.cafeMasRecaudacion_lbl.Name = "cafeMasRecaudacion_lbl";
            this.cafeMasRecaudacion_lbl.Size = new System.Drawing.Size(50, 13);
            this.cafeMasRecaudacion_lbl.TabIndex = 5;
            this.cafeMasRecaudacion_lbl.Text = "resultado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cafe con menos recaudación:";
            // 
            // cafeMenosRecaudacion_lbl
            // 
            this.cafeMenosRecaudacion_lbl.AutoSize = true;
            this.cafeMenosRecaudacion_lbl.Location = new System.Drawing.Point(161, 109);
            this.cafeMenosRecaudacion_lbl.Name = "cafeMenosRecaudacion_lbl";
            this.cafeMenosRecaudacion_lbl.Size = new System.Drawing.Size(50, 13);
            this.cafeMenosRecaudacion_lbl.TabIndex = 7;
            this.cafeMenosRecaudacion_lbl.Text = "resultado";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cafeteraRecaudacion_listBox);
            this.groupBox2.Controls.Add(this.cafeteraVentas_listBox);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.cafeteraMenosRecaudacion_lbl);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cafeteraMasRecaudacion_lbl);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cafeteraMenosSirvio_lbl);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.cafeteraMasSirvio_lbl);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(245, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 411);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cafeteras";
            // 
            // cafeteraMenosRecaudacion_lbl
            // 
            this.cafeteraMenosRecaudacion_lbl.AutoSize = true;
            this.cafeteraMenosRecaudacion_lbl.Location = new System.Drawing.Point(179, 109);
            this.cafeteraMenosRecaudacion_lbl.Name = "cafeteraMenosRecaudacion_lbl";
            this.cafeteraMenosRecaudacion_lbl.Size = new System.Drawing.Size(50, 13);
            this.cafeteraMenosRecaudacion_lbl.TabIndex = 7;
            this.cafeteraMenosRecaudacion_lbl.Text = "resultado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Cafetera con menos recaudación:";
            // 
            // cafeteraMasRecaudacion_lbl
            // 
            this.cafeteraMasRecaudacion_lbl.AutoSize = true;
            this.cafeteraMasRecaudacion_lbl.Location = new System.Drawing.Point(167, 82);
            this.cafeteraMasRecaudacion_lbl.Name = "cafeteraMasRecaudacion_lbl";
            this.cafeteraMasRecaudacion_lbl.Size = new System.Drawing.Size(50, 13);
            this.cafeteraMasRecaudacion_lbl.TabIndex = 5;
            this.cafeteraMasRecaudacion_lbl.Text = "resultado";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Cafetera con más recaudación:";
            // 
            // cafeteraMenosSirvio_lbl
            // 
            this.cafeteraMenosSirvio_lbl.AutoSize = true;
            this.cafeteraMenosSirvio_lbl.Location = new System.Drawing.Point(130, 54);
            this.cafeteraMenosSirvio_lbl.Name = "cafeteraMenosSirvio_lbl";
            this.cafeteraMenosSirvio_lbl.Size = new System.Drawing.Size(50, 13);
            this.cafeteraMenosSirvio_lbl.TabIndex = 3;
            this.cafeteraMenosSirvio_lbl.Text = "resultado";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Cafe que menos servió:";
            // 
            // cafeteraMasSirvio_lbl
            // 
            this.cafeteraMasSirvio_lbl.AutoSize = true;
            this.cafeteraMasSirvio_lbl.Location = new System.Drawing.Point(136, 26);
            this.cafeteraMasSirvio_lbl.Name = "cafeteraMasSirvio_lbl";
            this.cafeteraMasSirvio_lbl.Size = new System.Drawing.Size(50, 13);
            this.cafeteraMasSirvio_lbl.TabIndex = 1;
            this.cafeteraMasSirvio_lbl.Text = "resultado";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Cafetera que más servió:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 150);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "Porcentaje de ventas";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 285);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(135, 13);
            this.label18.TabIndex = 9;
            this.label18.Text = "Porcentaje de recaudación";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 285);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(135, 13);
            this.label19.TabIndex = 11;
            this.label19.Text = "Porcentaje de recaudación";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 150);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(108, 13);
            this.label20.TabIndex = 10;
            this.label20.Text = "Porcentaje de ventas";
            // 
            // cafeteraVentas_listBox
            // 
            this.cafeteraVentas_listBox.FormattingEnabled = true;
            this.cafeteraVentas_listBox.Location = new System.Drawing.Point(6, 166);
            this.cafeteraVentas_listBox.Name = "cafeteraVentas_listBox";
            this.cafeteraVentas_listBox.Size = new System.Drawing.Size(207, 95);
            this.cafeteraVentas_listBox.TabIndex = 12;
            // 
            // cafeteraRecaudacion_listBox
            // 
            this.cafeteraRecaudacion_listBox.FormattingEnabled = true;
            this.cafeteraRecaudacion_listBox.Location = new System.Drawing.Point(6, 301);
            this.cafeteraRecaudacion_listBox.Name = "cafeteraRecaudacion_listBox";
            this.cafeteraRecaudacion_listBox.Size = new System.Drawing.Size(207, 95);
            this.cafeteraRecaudacion_listBox.TabIndex = 13;
            // 
            // cafeVentas_listBox
            // 
            this.cafeVentas_listBox.FormattingEnabled = true;
            this.cafeVentas_listBox.Location = new System.Drawing.Point(6, 166);
            this.cafeVentas_listBox.Name = "cafeVentas_listBox";
            this.cafeVentas_listBox.Size = new System.Drawing.Size(207, 95);
            this.cafeVentas_listBox.TabIndex = 14;
            // 
            // cafeRecaudacion_listBox
            // 
            this.cafeRecaudacion_listBox.FormattingEnabled = true;
            this.cafeRecaudacion_listBox.Location = new System.Drawing.Point(6, 301);
            this.cafeRecaudacion_listBox.Name = "cafeRecaudacion_listBox";
            this.cafeRecaudacion_listBox.Size = new System.Drawing.Size(207, 95);
            this.cafeRecaudacion_listBox.TabIndex = 14;
            // 
            // Frm_Resumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 435);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Resumen";
            this.Text = "Resumen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label cafeMenosRecaudacion_lbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label cafeMasRecaudacion_lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label cafeMenosVendido_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cafeMasVendido_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label cafeteraMenosRecaudacion_lbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label cafeteraMasRecaudacion_lbl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label cafeteraMenosSirvio_lbl;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label cafeteraMasSirvio_lbl;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ListBox cafeRecaudacion_listBox;
        private System.Windows.Forms.ListBox cafeVentas_listBox;
        private System.Windows.Forms.ListBox cafeteraRecaudacion_listBox;
        private System.Windows.Forms.ListBox cafeteraVentas_listBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}