namespace ejercicio05
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.jueces_listBox = new System.Windows.Forms.ListBox();
            this.jueces_groupBox = new System.Windows.Forms.GroupBox();
            this.EliminarJuez_btn = new System.Windows.Forms.Button();
            this.RegistrarJuez_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.canchas_groupBox = new System.Windows.Forms.GroupBox();
            this.VerCancha_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.canchas_listBox = new System.Windows.Forms.ListBox();
            this.alquileres_groupBox = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.VerAlquiler_btn = new System.Windows.Forms.Button();
            this.CancelarAlquiler_btn = new System.Windows.Forms.Button();
            this.NuevoAlquiler_btn = new System.Windows.Forms.Button();
            this.alquileres_listBox = new System.Windows.Forms.ListBox();
            this.info_groupBox = new System.Windows.Forms.GroupBox();
            this.jMasRecaudacion_lbl = new System.Windows.Forms.Label();
            this.masPartidos_lbl = new System.Windows.Forms.Label();
            this.masAlquilada_lbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cMasRecaudacion_lbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.jueces_groupBox.SuspendLayout();
            this.canchas_groupBox.SuspendLayout();
            this.alquileres_groupBox.SuspendLayout();
            this.info_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // jueces_listBox
            // 
            this.jueces_listBox.FormattingEnabled = true;
            this.jueces_listBox.Location = new System.Drawing.Point(9, 41);
            this.jueces_listBox.Name = "jueces_listBox";
            this.jueces_listBox.Size = new System.Drawing.Size(304, 95);
            this.jueces_listBox.TabIndex = 0;
            // 
            // jueces_groupBox
            // 
            this.jueces_groupBox.Controls.Add(this.EliminarJuez_btn);
            this.jueces_groupBox.Controls.Add(this.RegistrarJuez_btn);
            this.jueces_groupBox.Controls.Add(this.label1);
            this.jueces_groupBox.Controls.Add(this.jueces_listBox);
            this.jueces_groupBox.Location = new System.Drawing.Point(12, 12);
            this.jueces_groupBox.Name = "jueces_groupBox";
            this.jueces_groupBox.Size = new System.Drawing.Size(337, 190);
            this.jueces_groupBox.TabIndex = 3;
            this.jueces_groupBox.TabStop = false;
            this.jueces_groupBox.Text = "Jueces";
            // 
            // EliminarJuez_btn
            // 
            this.EliminarJuez_btn.Location = new System.Drawing.Point(96, 142);
            this.EliminarJuez_btn.Name = "EliminarJuez_btn";
            this.EliminarJuez_btn.Size = new System.Drawing.Size(81, 41);
            this.EliminarJuez_btn.TabIndex = 3;
            this.EliminarJuez_btn.Text = "Eliminar Juez";
            this.EliminarJuez_btn.UseVisualStyleBackColor = true;
            this.EliminarJuez_btn.Click += new System.EventHandler(this.EliminarJuez_btn_Click);
            // 
            // RegistrarJuez_btn
            // 
            this.RegistrarJuez_btn.Location = new System.Drawing.Point(9, 142);
            this.RegistrarJuez_btn.Name = "RegistrarJuez_btn";
            this.RegistrarJuez_btn.Size = new System.Drawing.Size(81, 41);
            this.RegistrarJuez_btn.TabIndex = 2;
            this.RegistrarJuez_btn.Text = "Registrar juez";
            this.RegistrarJuez_btn.UseVisualStyleBackColor = true;
            this.RegistrarJuez_btn.Click += new System.EventHandler(this.RegistrarJuez_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de jueces";
            // 
            // canchas_groupBox
            // 
            this.canchas_groupBox.Controls.Add(this.VerCancha_btn);
            this.canchas_groupBox.Controls.Add(this.label2);
            this.canchas_groupBox.Controls.Add(this.canchas_listBox);
            this.canchas_groupBox.Location = new System.Drawing.Point(12, 208);
            this.canchas_groupBox.Name = "canchas_groupBox";
            this.canchas_groupBox.Size = new System.Drawing.Size(337, 190);
            this.canchas_groupBox.TabIndex = 4;
            this.canchas_groupBox.TabStop = false;
            this.canchas_groupBox.Text = "Canchas";
            // 
            // VerCancha_btn
            // 
            this.VerCancha_btn.Location = new System.Drawing.Point(9, 143);
            this.VerCancha_btn.Name = "VerCancha_btn";
            this.VerCancha_btn.Size = new System.Drawing.Size(81, 41);
            this.VerCancha_btn.TabIndex = 3;
            this.VerCancha_btn.Text = "Ver cancha";
            this.VerCancha_btn.UseVisualStyleBackColor = true;
            this.VerCancha_btn.Click += new System.EventHandler(this.VerCancha_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lista de canchas";
            // 
            // canchas_listBox
            // 
            this.canchas_listBox.FormattingEnabled = true;
            this.canchas_listBox.Location = new System.Drawing.Point(9, 41);
            this.canchas_listBox.Name = "canchas_listBox";
            this.canchas_listBox.Size = new System.Drawing.Size(304, 95);
            this.canchas_listBox.TabIndex = 0;
            // 
            // alquileres_groupBox
            // 
            this.alquileres_groupBox.Controls.Add(this.label8);
            this.alquileres_groupBox.Controls.Add(this.VerAlquiler_btn);
            this.alquileres_groupBox.Controls.Add(this.CancelarAlquiler_btn);
            this.alquileres_groupBox.Controls.Add(this.NuevoAlquiler_btn);
            this.alquileres_groupBox.Controls.Add(this.alquileres_listBox);
            this.alquileres_groupBox.Location = new System.Drawing.Point(355, 12);
            this.alquileres_groupBox.Name = "alquileres_groupBox";
            this.alquileres_groupBox.Size = new System.Drawing.Size(303, 190);
            this.alquileres_groupBox.TabIndex = 5;
            this.alquileres_groupBox.TabStop = false;
            this.alquileres_groupBox.Text = "Alquileres";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Lista de alquileres";
            // 
            // VerAlquiler_btn
            // 
            this.VerAlquiler_btn.Location = new System.Drawing.Point(9, 142);
            this.VerAlquiler_btn.Name = "VerAlquiler_btn";
            this.VerAlquiler_btn.Size = new System.Drawing.Size(81, 41);
            this.VerAlquiler_btn.TabIndex = 5;
            this.VerAlquiler_btn.Text = "Ver alquiler";
            this.VerAlquiler_btn.UseVisualStyleBackColor = true;
            this.VerAlquiler_btn.Click += new System.EventHandler(this.VerAlquiler_btn_Click);
            // 
            // CancelarAlquiler_btn
            // 
            this.CancelarAlquiler_btn.Location = new System.Drawing.Point(183, 142);
            this.CancelarAlquiler_btn.Name = "CancelarAlquiler_btn";
            this.CancelarAlquiler_btn.Size = new System.Drawing.Size(81, 41);
            this.CancelarAlquiler_btn.TabIndex = 4;
            this.CancelarAlquiler_btn.Text = "Cancelar alquiler";
            this.CancelarAlquiler_btn.UseVisualStyleBackColor = true;
            this.CancelarAlquiler_btn.Click += new System.EventHandler(this.CancelarAlquiler_btn_Click);
            // 
            // NuevoAlquiler_btn
            // 
            this.NuevoAlquiler_btn.Location = new System.Drawing.Point(96, 142);
            this.NuevoAlquiler_btn.Name = "NuevoAlquiler_btn";
            this.NuevoAlquiler_btn.Size = new System.Drawing.Size(81, 41);
            this.NuevoAlquiler_btn.TabIndex = 4;
            this.NuevoAlquiler_btn.Text = "Generar nuevo alquiler";
            this.NuevoAlquiler_btn.UseVisualStyleBackColor = true;
            this.NuevoAlquiler_btn.Click += new System.EventHandler(this.NuevoAlquiler_btn_Click);
            // 
            // alquileres_listBox
            // 
            this.alquileres_listBox.FormattingEnabled = true;
            this.alquileres_listBox.Location = new System.Drawing.Point(9, 41);
            this.alquileres_listBox.Name = "alquileres_listBox";
            this.alquileres_listBox.Size = new System.Drawing.Size(255, 95);
            this.alquileres_listBox.TabIndex = 4;
            // 
            // info_groupBox
            // 
            this.info_groupBox.Controls.Add(this.jMasRecaudacion_lbl);
            this.info_groupBox.Controls.Add(this.masPartidos_lbl);
            this.info_groupBox.Controls.Add(this.masAlquilada_lbl);
            this.info_groupBox.Controls.Add(this.label11);
            this.info_groupBox.Controls.Add(this.label10);
            this.info_groupBox.Controls.Add(this.label9);
            this.info_groupBox.Controls.Add(this.cMasRecaudacion_lbl);
            this.info_groupBox.Controls.Add(this.label7);
            this.info_groupBox.Controls.Add(this.label6);
            this.info_groupBox.Controls.Add(this.label5);
            this.info_groupBox.Controls.Add(this.label4);
            this.info_groupBox.Controls.Add(this.label3);
            this.info_groupBox.Location = new System.Drawing.Point(355, 208);
            this.info_groupBox.Name = "info_groupBox";
            this.info_groupBox.Size = new System.Drawing.Size(343, 190);
            this.info_groupBox.TabIndex = 6;
            this.info_groupBox.TabStop = false;
            this.info_groupBox.Text = "Información";
            // 
            // jMasRecaudacion_lbl
            // 
            this.jMasRecaudacion_lbl.AutoSize = true;
            this.jMasRecaudacion_lbl.Location = new System.Drawing.Point(164, 156);
            this.jMasRecaudacion_lbl.Name = "jMasRecaudacion_lbl";
            this.jMasRecaudacion_lbl.Size = new System.Drawing.Size(98, 13);
            this.jMasRecaudacion_lbl.TabIndex = 11;
            this.jMasRecaudacion_lbl.Text = "recaudacion_value";
            // 
            // masPartidos_lbl
            // 
            this.masPartidos_lbl.AutoSize = true;
            this.masPartidos_lbl.Location = new System.Drawing.Point(164, 127);
            this.masPartidos_lbl.Name = "masPartidos_lbl";
            this.masPartidos_lbl.Size = new System.Drawing.Size(96, 13);
            this.masPartidos_lbl.TabIndex = 10;
            this.masPartidos_lbl.Text = "masPartidos_value";
            // 
            // masAlquilada_lbl
            // 
            this.masAlquilada_lbl.AutoSize = true;
            this.masAlquilada_lbl.Location = new System.Drawing.Point(164, 76);
            this.masAlquilada_lbl.Name = "masAlquilada_lbl";
            this.masAlquilada_lbl.Size = new System.Drawing.Size(101, 13);
            this.masAlquilada_lbl.TabIndex = 9;
            this.masAlquilada_lbl.Text = "masAlquilada_value";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Juez con más recaudación:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Juez con más partidos:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Cancha con más recaudación:";
            // 
            // cMasRecaudacion_lbl
            // 
            this.cMasRecaudacion_lbl.AutoSize = true;
            this.cMasRecaudacion_lbl.Location = new System.Drawing.Point(164, 101);
            this.cMasRecaudacion_lbl.Name = "cMasRecaudacion_lbl";
            this.cMasRecaudacion_lbl.Size = new System.Drawing.Size(98, 13);
            this.cMasRecaudacion_lbl.TabIndex = 5;
            this.cMasRecaudacion_lbl.Text = "recaudacion_value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Cancha más alquilada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "ganancia_value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ganancia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "recaudacion_value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Recaudación:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 411);
            this.Controls.Add(this.info_groupBox);
            this.Controls.Add(this.alquileres_groupBox);
            this.Controls.Add(this.canchas_groupBox);
            this.Controls.Add(this.jueces_groupBox);
            this.Name = "Form1";
            this.Text = "Polideportivo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.jueces_groupBox.ResumeLayout(false);
            this.jueces_groupBox.PerformLayout();
            this.canchas_groupBox.ResumeLayout(false);
            this.canchas_groupBox.PerformLayout();
            this.alquileres_groupBox.ResumeLayout(false);
            this.alquileres_groupBox.PerformLayout();
            this.info_groupBox.ResumeLayout(false);
            this.info_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox jueces_listBox;
        private System.Windows.Forms.GroupBox jueces_groupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EliminarJuez_btn;
        private System.Windows.Forms.Button RegistrarJuez_btn;
        private System.Windows.Forms.GroupBox canchas_groupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox canchas_listBox;
        private System.Windows.Forms.GroupBox alquileres_groupBox;
        private System.Windows.Forms.Button CancelarAlquiler_btn;
        private System.Windows.Forms.Button NuevoAlquiler_btn;
        private System.Windows.Forms.ListBox alquileres_listBox;
        private System.Windows.Forms.Button VerAlquiler_btn;
        private System.Windows.Forms.GroupBox info_groupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label cMasRecaudacion_lbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label jMasRecaudacion_lbl;
        private System.Windows.Forms.Label masPartidos_lbl;
        private System.Windows.Forms.Label masAlquilada_lbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button VerCancha_btn;
    }
}

