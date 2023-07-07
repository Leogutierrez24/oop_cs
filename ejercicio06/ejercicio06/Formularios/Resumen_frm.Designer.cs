namespace ejercicio06.Formularios
{
    partial class Resumen_frm
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
            this.label1 = new System.Windows.Forms.Label();
            this.recaudacionTotal_lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.habMasElegida_lbl = new System.Windows.Forms.Label();
            this.habMasOcupada_lbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HabFiltrar_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.habFechaFinal_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.habFechaInicial_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.recaudacionParcial_lbl = new System.Windows.Forms.Label();
            this.RecauFiltrar_btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.recauFechaFinal_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.recauFechaInicial_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.huespedMVP = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recaudación total:";
            // 
            // recaudacionTotal_lbl
            // 
            this.recaudacionTotal_lbl.AutoSize = true;
            this.recaudacionTotal_lbl.Location = new System.Drawing.Point(109, 154);
            this.recaudacionTotal_lbl.Name = "recaudacionTotal_lbl";
            this.recaudacionTotal_lbl.Size = new System.Drawing.Size(122, 13);
            this.recaudacionTotal_lbl.TabIndex = 1;
            this.recaudacionTotal_lbl.Text = "recaudacionTotal_value";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.habMasElegida_lbl);
            this.groupBox1.Controls.Add(this.habMasOcupada_lbl);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.HabFiltrar_btn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.habFechaFinal_dateTimePicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.habFechaInicial_dateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 189);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Habitaciones";
            // 
            // habMasElegida_lbl
            // 
            this.habMasElegida_lbl.AutoSize = true;
            this.habMasElegida_lbl.Location = new System.Drawing.Point(140, 124);
            this.habMasElegida_lbl.Name = "habMasElegida_lbl";
            this.habMasElegida_lbl.Size = new System.Drawing.Size(143, 13);
            this.habMasElegida_lbl.TabIndex = 9;
            this.habMasElegida_lbl.Text = "habitacionMasElegida_value";
            // 
            // habMasOcupada_lbl
            // 
            this.habMasOcupada_lbl.AutoSize = true;
            this.habMasOcupada_lbl.Location = new System.Drawing.Point(140, 164);
            this.habMasOcupada_lbl.Name = "habMasOcupada_lbl";
            this.habMasOcupada_lbl.Size = new System.Drawing.Size(152, 13);
            this.habMasOcupada_lbl.TabIndex = 8;
            this.habMasOcupada_lbl.Text = "habitacionMasOcupada_value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Habitación más ocupada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Habitación más elegida:";
            // 
            // HabFiltrar_btn
            // 
            this.HabFiltrar_btn.Location = new System.Drawing.Point(312, 26);
            this.HabFiltrar_btn.Name = "HabFiltrar_btn";
            this.HabFiltrar_btn.Size = new System.Drawing.Size(92, 38);
            this.HabFiltrar_btn.TabIndex = 5;
            this.HabFiltrar_btn.Text = "Filtrar por fechas";
            this.HabFiltrar_btn.UseVisualStyleBackColor = true;
            this.HabFiltrar_btn.Click += new System.EventHandler(this.HabFiltrar_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha final:";
            // 
            // habFechaFinal_dateTimePicker
            // 
            this.habFechaFinal_dateTimePicker.Location = new System.Drawing.Point(81, 72);
            this.habFechaFinal_dateTimePicker.Name = "habFechaFinal_dateTimePicker";
            this.habFechaFinal_dateTimePicker.Size = new System.Drawing.Size(216, 20);
            this.habFechaFinal_dateTimePicker.TabIndex = 1;
            this.habFechaFinal_dateTimePicker.ValueChanged += new System.EventHandler(this.habFechaFinal_dateTimePicker_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha inicial:";
            // 
            // habFechaInicial_dateTimePicker
            // 
            this.habFechaInicial_dateTimePicker.Location = new System.Drawing.Point(81, 26);
            this.habFechaInicial_dateTimePicker.Name = "habFechaInicial_dateTimePicker";
            this.habFechaInicial_dateTimePicker.Size = new System.Drawing.Size(216, 20);
            this.habFechaInicial_dateTimePicker.TabIndex = 0;
            this.habFechaInicial_dateTimePicker.ValueChanged += new System.EventHandler(this.habFechaInicial_dateTimePicker_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.recaudacionParcial_lbl);
            this.groupBox2.Controls.Add(this.RecauFiltrar_btn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.recaudacionTotal_lbl);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.recauFechaFinal_dateTimePicker);
            this.groupBox2.Controls.Add(this.recauFechaInicial_dateTimePicker);
            this.groupBox2.Location = new System.Drawing.Point(12, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 189);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recaudación";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Recaudación por período:";
            // 
            // recaudacionParcial_lbl
            // 
            this.recaudacionParcial_lbl.AutoSize = true;
            this.recaudacionParcial_lbl.Location = new System.Drawing.Point(144, 122);
            this.recaudacionParcial_lbl.Name = "recaudacionParcial_lbl";
            this.recaudacionParcial_lbl.Size = new System.Drawing.Size(130, 13);
            this.recaudacionParcial_lbl.TabIndex = 16;
            this.recaudacionParcial_lbl.Text = "recaudacionParcial_value";
            // 
            // RecauFiltrar_btn
            // 
            this.RecauFiltrar_btn.Location = new System.Drawing.Point(312, 28);
            this.RecauFiltrar_btn.Name = "RecauFiltrar_btn";
            this.RecauFiltrar_btn.Size = new System.Drawing.Size(92, 38);
            this.RecauFiltrar_btn.TabIndex = 14;
            this.RecauFiltrar_btn.Text = "Filtrar por fechas";
            this.RecauFiltrar_btn.UseVisualStyleBackColor = true;
            this.RecauFiltrar_btn.Click += new System.EventHandler(this.RecauFiltrar_btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Fecha final:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Fecha inicial:";
            // 
            // recauFechaFinal_dateTimePicker
            // 
            this.recauFechaFinal_dateTimePicker.Location = new System.Drawing.Point(81, 74);
            this.recauFechaFinal_dateTimePicker.Name = "recauFechaFinal_dateTimePicker";
            this.recauFechaFinal_dateTimePicker.Size = new System.Drawing.Size(216, 20);
            this.recauFechaFinal_dateTimePicker.TabIndex = 11;
            this.recauFechaFinal_dateTimePicker.ValueChanged += new System.EventHandler(this.recauFechaFinal_dateTimePicker_ValueChanged);
            // 
            // recauFechaInicial_dateTimePicker
            // 
            this.recauFechaInicial_dateTimePicker.Location = new System.Drawing.Point(81, 28);
            this.recauFechaInicial_dateTimePicker.Name = "recauFechaInicial_dateTimePicker";
            this.recauFechaInicial_dateTimePicker.Size = new System.Drawing.Size(216, 20);
            this.recauFechaInicial_dateTimePicker.TabIndex = 10;
            this.recauFechaInicial_dateTimePicker.ValueChanged += new System.EventHandler(this.recauFechaInicial_dateTimePicker_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Huésped con más hospedajes:";
            // 
            // huespedMVP
            // 
            this.huespedMVP.AutoSize = true;
            this.huespedMVP.Location = new System.Drawing.Point(177, 408);
            this.huespedMVP.Name = "huespedMVP";
            this.huespedMVP.Size = new System.Drawing.Size(87, 13);
            this.huespedMVP.TabIndex = 18;
            this.huespedMVP.Text = "huespedMPV_lbl";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(159, 445);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 34);
            this.button3.TabIndex = 19;
            this.button3.Text = "Cerrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Resumen_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 498);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.huespedMVP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Resumen_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resumen";
            this.Load += new System.EventHandler(this.Resumen_frm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label recaudacionTotal_lbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label habMasElegida_lbl;
        private System.Windows.Forms.Label habMasOcupada_lbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button HabFiltrar_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker habFechaFinal_dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker habFechaInicial_dateTimePicker;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label recaudacionParcial_lbl;
        private System.Windows.Forms.Button RecauFiltrar_btn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker recauFechaFinal_dateTimePicker;
        private System.Windows.Forms.DateTimePicker recauFechaInicial_dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label huespedMVP;
        private System.Windows.Forms.Button button3;
    }
}