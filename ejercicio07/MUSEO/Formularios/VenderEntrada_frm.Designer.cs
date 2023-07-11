namespace MUSEO.Formularios
{
    partial class VenderEntrada_frm
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
            this.fechaNacimiento_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.documento_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.apellido_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nombre_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ElegirAtraccion_btn = new System.Windows.Forms.Button();
            this.atracciones_listBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.total_lbl = new System.Windows.Forms.Label();
            this.subtotal_lbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.QuitarAtraccion_btn = new System.Windows.Forms.Button();
            this.atraccionesElegidas_listBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Aceptar_btn = new System.Windows.Forms.Button();
            this.Cancelar_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documento_numericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fechaNacimiento_dateTimePicker);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.documento_numericUpDown);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.apellido_textBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nombre_textBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del visitante";
            // 
            // fechaNacimiento_dateTimePicker
            // 
            this.fechaNacimiento_dateTimePicker.Location = new System.Drawing.Point(212, 83);
            this.fechaNacimiento_dateTimePicker.MaxDate = new System.DateTime(2023, 7, 10, 0, 0, 0, 0);
            this.fechaNacimiento_dateTimePicker.MinDate = new System.DateTime(1945, 1, 1, 0, 0, 0, 0);
            this.fechaNacimiento_dateTimePicker.Name = "fechaNacimiento_dateTimePicker";
            this.fechaNacimiento_dateTimePicker.Size = new System.Drawing.Size(204, 20);
            this.fechaNacimiento_dateTimePicker.TabIndex = 7;
            this.fechaNacimiento_dateTimePicker.Value = new System.DateTime(2023, 7, 10, 0, 0, 0, 0);
            this.fechaNacimiento_dateTimePicker.ValueChanged += new System.EventHandler(this.fechaNacimiento_dateTimePicker_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de nacimiento";
            // 
            // documento_numericUpDown
            // 
            this.documento_numericUpDown.Location = new System.Drawing.Point(212, 36);
            this.documento_numericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.documento_numericUpDown.Minimum = new decimal(new int[] {
            11111111,
            0,
            0,
            0});
            this.documento_numericUpDown.Name = "documento_numericUpDown";
            this.documento_numericUpDown.Size = new System.Drawing.Size(204, 20);
            this.documento_numericUpDown.TabIndex = 5;
            this.documento_numericUpDown.Value = new decimal(new int[] {
            11111111,
            0,
            0,
            0});
            this.documento_numericUpDown.ValueChanged += new System.EventHandler(this.documento_numericUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Documento";
            // 
            // apellido_textBox
            // 
            this.apellido_textBox.Location = new System.Drawing.Point(10, 83);
            this.apellido_textBox.Name = "apellido_textBox";
            this.apellido_textBox.Size = new System.Drawing.Size(188, 20);
            this.apellido_textBox.TabIndex = 3;
            this.apellido_textBox.TextChanged += new System.EventHandler(this.apellido_textBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // nombre_textBox
            // 
            this.nombre_textBox.Location = new System.Drawing.Point(10, 36);
            this.nombre_textBox.Name = "nombre_textBox";
            this.nombre_textBox.Size = new System.Drawing.Size(188, 20);
            this.nombre_textBox.TabIndex = 1;
            this.nombre_textBox.TextChanged += new System.EventHandler(this.nombre_textBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ElegirAtraccion_btn);
            this.groupBox2.Controls.Add(this.atracciones_listBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(15, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 149);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de entrada";
            // 
            // ElegirAtraccion_btn
            // 
            this.ElegirAtraccion_btn.Location = new System.Drawing.Point(240, 41);
            this.ElegirAtraccion_btn.Name = "ElegirAtraccion_btn";
            this.ElegirAtraccion_btn.Size = new System.Drawing.Size(75, 35);
            this.ElegirAtraccion_btn.TabIndex = 2;
            this.ElegirAtraccion_btn.Text = "Elegir atracción";
            this.ElegirAtraccion_btn.UseVisualStyleBackColor = true;
            this.ElegirAtraccion_btn.Click += new System.EventHandler(this.ElegirAtraccion_btn_Click);
            // 
            // atracciones_listBox
            // 
            this.atracciones_listBox.FormattingEnabled = true;
            this.atracciones_listBox.Location = new System.Drawing.Point(9, 41);
            this.atracciones_listBox.Name = "atracciones_listBox";
            this.atracciones_listBox.Size = new System.Drawing.Size(213, 95);
            this.atracciones_listBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Atracciones";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.total_lbl);
            this.groupBox.Controls.Add(this.subtotal_lbl);
            this.groupBox.Controls.Add(this.label8);
            this.groupBox.Controls.Add(this.QuitarAtraccion_btn);
            this.groupBox.Controls.Add(this.atraccionesElegidas_listBox);
            this.groupBox.Controls.Add(this.label6);
            this.groupBox.Location = new System.Drawing.Point(15, 302);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(427, 134);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Detalle de entrada";
            // 
            // total_lbl
            // 
            this.total_lbl.AutoSize = true;
            this.total_lbl.Location = new System.Drawing.Point(80, 110);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Size = new System.Drawing.Size(59, 13);
            this.total_lbl.TabIndex = 7;
            this.total_lbl.Text = "total_value";
            // 
            // subtotal_lbl
            // 
            this.subtotal_lbl.AutoSize = true;
            this.subtotal_lbl.Location = new System.Drawing.Point(80, 88);
            this.subtotal_lbl.Name = "subtotal_lbl";
            this.subtotal_lbl.Size = new System.Drawing.Size(76, 13);
            this.subtotal_lbl.TabIndex = 5;
            this.subtotal_lbl.Text = "subtotal_value";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Total:";
            // 
            // QuitarAtraccion_btn
            // 
            this.QuitarAtraccion_btn.Location = new System.Drawing.Point(240, 19);
            this.QuitarAtraccion_btn.Name = "QuitarAtraccion_btn";
            this.QuitarAtraccion_btn.Size = new System.Drawing.Size(75, 35);
            this.QuitarAtraccion_btn.TabIndex = 3;
            this.QuitarAtraccion_btn.Text = "Quitar atracción";
            this.QuitarAtraccion_btn.UseVisualStyleBackColor = true;
            this.QuitarAtraccion_btn.Click += new System.EventHandler(this.QuitarAtraccion_btn_Click);
            // 
            // atraccionesElegidas_listBox
            // 
            this.atraccionesElegidas_listBox.FormattingEnabled = true;
            this.atraccionesElegidas_listBox.Location = new System.Drawing.Point(9, 19);
            this.atraccionesElegidas_listBox.Name = "atraccionesElegidas_listBox";
            this.atraccionesElegidas_listBox.Size = new System.Drawing.Size(213, 56);
            this.atraccionesElegidas_listBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Subtotal:";
            // 
            // Aceptar_btn
            // 
            this.Aceptar_btn.Location = new System.Drawing.Point(282, 442);
            this.Aceptar_btn.Name = "Aceptar_btn";
            this.Aceptar_btn.Size = new System.Drawing.Size(75, 29);
            this.Aceptar_btn.TabIndex = 3;
            this.Aceptar_btn.Text = "Aceptar";
            this.Aceptar_btn.UseVisualStyleBackColor = true;
            this.Aceptar_btn.Click += new System.EventHandler(this.Aceptar_btn_Click);
            // 
            // Cancelar_btn
            // 
            this.Cancelar_btn.Location = new System.Drawing.Point(365, 442);
            this.Cancelar_btn.Name = "Cancelar_btn";
            this.Cancelar_btn.Size = new System.Drawing.Size(75, 29);
            this.Cancelar_btn.TabIndex = 4;
            this.Cancelar_btn.Text = "Cancelar";
            this.Cancelar_btn.UseVisualStyleBackColor = true;
            this.Cancelar_btn.Click += new System.EventHandler(this.Cancelar_btn_Click);
            // 
            // VenderEntrada_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 483);
            this.Controls.Add(this.Cancelar_btn);
            this.Controls.Add(this.Aceptar_btn);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "VenderEntrada_frm";
            this.Text = "Vender Entrada";
            this.Load += new System.EventHandler(this.VenderEntrada_frm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documento_numericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nombre_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox apellido_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fechaNacimiento_dateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown documento_numericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ElegirAtraccion_btn;
        private System.Windows.Forms.ListBox atracciones_listBox;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button QuitarAtraccion_btn;
        private System.Windows.Forms.ListBox atraccionesElegidas_listBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label total_lbl;
        private System.Windows.Forms.Label subtotal_lbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Aceptar_btn;
        private System.Windows.Forms.Button Cancelar_btn;
    }
}