namespace ejercicio04
{
    partial class frm_Resumen
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
            this.cerveza_groupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cervezaVentas_listBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cervezaRecaudacion_listBox = new System.Windows.Forms.ListBox();
            this.cervezaMenosVendida2_lbl = new System.Windows.Forms.Label();
            this.cervezaMasVendida2_lbl = new System.Windows.Forms.Label();
            this.cervezaMasRecaudacion_lbl = new System.Windows.Forms.Label();
            this.cervezaMasVendida_lbl = new System.Windows.Forms.Label();
            this.barril_groupBox = new System.Windows.Forms.GroupBox();
            this.barrilMasVendido_lbl = new System.Windows.Forms.Label();
            this.barrilMasRecaudacion_lbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.barrilRecaudacion_listBox = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.barrilVentas_listBox = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.vaso_groupBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.vasoMasSolicitado_lbl = new System.Windows.Forms.Label();
            this.barrilMenosVendido_lbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cerveza_groupBox.SuspendLayout();
            this.barril_groupBox.SuspendLayout();
            this.vaso_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cerveza_groupBox
            // 
            this.cerveza_groupBox.Controls.Add(this.cervezaMasVendida_lbl);
            this.cerveza_groupBox.Controls.Add(this.cervezaMasRecaudacion_lbl);
            this.cerveza_groupBox.Controls.Add(this.cervezaMasVendida2_lbl);
            this.cerveza_groupBox.Controls.Add(this.cervezaMenosVendida2_lbl);
            this.cerveza_groupBox.Controls.Add(this.label6);
            this.cerveza_groupBox.Controls.Add(this.cervezaRecaudacion_listBox);
            this.cerveza_groupBox.Controls.Add(this.label5);
            this.cerveza_groupBox.Controls.Add(this.cervezaVentas_listBox);
            this.cerveza_groupBox.Controls.Add(this.label4);
            this.cerveza_groupBox.Controls.Add(this.label3);
            this.cerveza_groupBox.Controls.Add(this.label2);
            this.cerveza_groupBox.Controls.Add(this.label1);
            this.cerveza_groupBox.Location = new System.Drawing.Point(12, 12);
            this.cerveza_groupBox.Name = "cerveza_groupBox";
            this.cerveza_groupBox.Size = new System.Drawing.Size(334, 380);
            this.cerveza_groupBox.TabIndex = 0;
            this.cerveza_groupBox.TabStop = false;
            this.cerveza_groupBox.Text = "Cerveza";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Más vendida:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Más ganancia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Más vendida p/Litro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Menos vendida p/Litro:";
            // 
            // cervezaVentas_listBox
            // 
            this.cervezaVentas_listBox.FormattingEnabled = true;
            this.cervezaVentas_listBox.Location = new System.Drawing.Point(9, 152);
            this.cervezaVentas_listBox.Name = "cervezaVentas_listBox";
            this.cervezaVentas_listBox.Size = new System.Drawing.Size(235, 95);
            this.cervezaVentas_listBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Porcentaje de ventas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Porcentaje de recaudación";
            // 
            // cervezaRecaudacion_listBox
            // 
            this.cervezaRecaudacion_listBox.FormattingEnabled = true;
            this.cervezaRecaudacion_listBox.Location = new System.Drawing.Point(9, 274);
            this.cervezaRecaudacion_listBox.Name = "cervezaRecaudacion_listBox";
            this.cervezaRecaudacion_listBox.Size = new System.Drawing.Size(235, 95);
            this.cervezaRecaudacion_listBox.TabIndex = 6;
            // 
            // cervezaMenosVendida2_lbl
            // 
            this.cervezaMenosVendida2_lbl.AutoSize = true;
            this.cervezaMenosVendida2_lbl.Location = new System.Drawing.Point(129, 109);
            this.cervezaMenosVendida2_lbl.Name = "cervezaMenosVendida2_lbl";
            this.cervezaMenosVendida2_lbl.Size = new System.Drawing.Size(115, 13);
            this.cervezaMenosVendida2_lbl.TabIndex = 8;
            this.cervezaMenosVendida2_lbl.Text = "menosVendida2_value";
            // 
            // cervezaMasVendida2_lbl
            // 
            this.cervezaMasVendida2_lbl.AutoSize = true;
            this.cervezaMasVendida2_lbl.Location = new System.Drawing.Point(129, 82);
            this.cervezaMasVendida2_lbl.Name = "cervezaMasVendida2_lbl";
            this.cervezaMasVendida2_lbl.Size = new System.Drawing.Size(103, 13);
            this.cervezaMasVendida2_lbl.TabIndex = 9;
            this.cervezaMasVendida2_lbl.Text = "masVendida2_value";
            // 
            // cervezaMasRecaudacion_lbl
            // 
            this.cervezaMasRecaudacion_lbl.AutoSize = true;
            this.cervezaMasRecaudacion_lbl.Location = new System.Drawing.Point(129, 56);
            this.cervezaMasRecaudacion_lbl.Name = "cervezaMasRecaudacion_lbl";
            this.cervezaMasRecaudacion_lbl.Size = new System.Drawing.Size(109, 13);
            this.cervezaMasRecaudacion_lbl.TabIndex = 10;
            this.cervezaMasRecaudacion_lbl.Text = "menosVendida_value";
            // 
            // cervezaMasVendida_lbl
            // 
            this.cervezaMasVendida_lbl.AutoSize = true;
            this.cervezaMasVendida_lbl.Location = new System.Drawing.Point(129, 30);
            this.cervezaMasVendida_lbl.Name = "cervezaMasVendida_lbl";
            this.cervezaMasVendida_lbl.Size = new System.Drawing.Size(97, 13);
            this.cervezaMasVendida_lbl.TabIndex = 11;
            this.cervezaMasVendida_lbl.Text = "masVendida_value";
            // 
            // barril_groupBox
            // 
            this.barril_groupBox.Controls.Add(this.barrilMenosVendido_lbl);
            this.barril_groupBox.Controls.Add(this.label9);
            this.barril_groupBox.Controls.Add(this.barrilMasVendido_lbl);
            this.barril_groupBox.Controls.Add(this.barrilMasRecaudacion_lbl);
            this.barril_groupBox.Controls.Add(this.label11);
            this.barril_groupBox.Controls.Add(this.barrilRecaudacion_listBox);
            this.barril_groupBox.Controls.Add(this.label12);
            this.barril_groupBox.Controls.Add(this.barrilVentas_listBox);
            this.barril_groupBox.Controls.Add(this.label15);
            this.barril_groupBox.Controls.Add(this.label16);
            this.barril_groupBox.Location = new System.Drawing.Point(352, 12);
            this.barril_groupBox.Name = "barril_groupBox";
            this.barril_groupBox.Size = new System.Drawing.Size(328, 380);
            this.barril_groupBox.TabIndex = 12;
            this.barril_groupBox.TabStop = false;
            this.barril_groupBox.Text = "Barril";
            // 
            // barrilMasVendido_lbl
            // 
            this.barrilMasVendido_lbl.AutoSize = true;
            this.barrilMasVendido_lbl.Location = new System.Drawing.Point(129, 30);
            this.barrilMasVendido_lbl.Name = "barrilMasVendido_lbl";
            this.barrilMasVendido_lbl.Size = new System.Drawing.Size(91, 13);
            this.barrilMasVendido_lbl.TabIndex = 11;
            this.barrilMasVendido_lbl.Text = "masVendio_value";
            // 
            // barrilMasRecaudacion_lbl
            // 
            this.barrilMasRecaudacion_lbl.AutoSize = true;
            this.barrilMasRecaudacion_lbl.Location = new System.Drawing.Point(129, 82);
            this.barrilMasRecaudacion_lbl.Name = "barrilMasRecaudacion_lbl";
            this.barrilMasRecaudacion_lbl.Size = new System.Drawing.Size(114, 13);
            this.barrilMasRecaudacion_lbl.TabIndex = 10;
            this.barrilMasRecaudacion_lbl.Text = "masRecaudado_value";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Porcentaje de recaudación";
            // 
            // barrilRecaudacion_listBox
            // 
            this.barrilRecaudacion_listBox.FormattingEnabled = true;
            this.barrilRecaudacion_listBox.Location = new System.Drawing.Point(9, 274);
            this.barrilRecaudacion_listBox.Name = "barrilRecaudacion_listBox";
            this.barrilRecaudacion_listBox.Size = new System.Drawing.Size(229, 95);
            this.barrilRecaudacion_listBox.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Porcentaje de ventas";
            // 
            // barrilVentas_listBox
            // 
            this.barrilVentas_listBox.FormattingEnabled = true;
            this.barrilVentas_listBox.Location = new System.Drawing.Point(9, 152);
            this.barrilVentas_listBox.Name = "barrilVentas_listBox";
            this.barrilVentas_listBox.Size = new System.Drawing.Size(229, 95);
            this.barrilVentas_listBox.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Más recaudación:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Más cervezas vendió:";
            // 
            // vaso_groupBox
            // 
            this.vaso_groupBox.Controls.Add(this.vasoMasSolicitado_lbl);
            this.vaso_groupBox.Controls.Add(this.label7);
            this.vaso_groupBox.Location = new System.Drawing.Point(686, 12);
            this.vaso_groupBox.Name = "vaso_groupBox";
            this.vaso_groupBox.Size = new System.Drawing.Size(200, 69);
            this.vaso_groupBox.TabIndex = 13;
            this.vaso_groupBox.TabStop = false;
            this.vaso_groupBox.Text = "Vaso";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Más solicitado:";
            // 
            // vasoMasSolicitado_lbl
            // 
            this.vasoMasSolicitado_lbl.AutoSize = true;
            this.vasoMasSolicitado_lbl.Location = new System.Drawing.Point(89, 30);
            this.vasoMasSolicitado_lbl.Name = "vasoMasSolicitado_lbl";
            this.vasoMasSolicitado_lbl.Size = new System.Drawing.Size(104, 13);
            this.vasoMasSolicitado_lbl.TabIndex = 12;
            this.vasoMasSolicitado_lbl.Text = "masSolicitado_value";
            // 
            // barrilMenosVendido_lbl
            // 
            this.barrilMenosVendido_lbl.AutoSize = true;
            this.barrilMenosVendido_lbl.Location = new System.Drawing.Point(129, 56);
            this.barrilMenosVendido_lbl.Name = "barrilMenosVendido_lbl";
            this.barrilMenosVendido_lbl.Size = new System.Drawing.Size(109, 13);
            this.barrilMenosVendido_lbl.TabIndex = 13;
            this.barrilMenosVendido_lbl.Text = "menosVendido_value";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Menos cervezas vendió:";
            // 
            // frm_Resumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 412);
            this.Controls.Add(this.vaso_groupBox);
            this.Controls.Add(this.barril_groupBox);
            this.Controls.Add(this.cerveza_groupBox);
            this.Name = "frm_Resumen";
            this.Text = "Resumen";
            this.Load += new System.EventHandler(this.frm_Resumen_Load);
            this.cerveza_groupBox.ResumeLayout(false);
            this.cerveza_groupBox.PerformLayout();
            this.barril_groupBox.ResumeLayout(false);
            this.barril_groupBox.PerformLayout();
            this.vaso_groupBox.ResumeLayout(false);
            this.vaso_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cerveza_groupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cervezaMasVendida_lbl;
        private System.Windows.Forms.Label cervezaMasRecaudacion_lbl;
        private System.Windows.Forms.Label cervezaMasVendida2_lbl;
        private System.Windows.Forms.Label cervezaMenosVendida2_lbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox cervezaRecaudacion_listBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox cervezaVentas_listBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox barril_groupBox;
        private System.Windows.Forms.Label barrilMasVendido_lbl;
        private System.Windows.Forms.Label barrilMasRecaudacion_lbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox barrilRecaudacion_listBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox barrilVentas_listBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox vaso_groupBox;
        private System.Windows.Forms.Label vasoMasSolicitado_lbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label barrilMenosVendido_lbl;
        private System.Windows.Forms.Label label9;
    }
}