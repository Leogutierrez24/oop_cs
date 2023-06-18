namespace ejercicio05
{
    partial class Frm_nuevoAlquiler
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
            this.Cancha_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fecha_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Opciones_comboBox = new System.Windows.Forms.ComboBox();
            this.horas_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.totalValue_lbl = new System.Windows.Forms.Label();
            this.VerDisponibilidad_btn = new System.Windows.Forms.Button();
            this.Alquilar_btn = new System.Windows.Forms.Button();
            this.Cancelar_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.estadoValue_lbl = new System.Windows.Forms.Label();
            this.CalcularTotal_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.alquileres_listBox = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Horario_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.EstablecerJueces_btn = new System.Windows.Forms.Button();
            this.jueces_listBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.horas_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horario_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "* Cancha a reservar:";
            // 
            // Cancha_comboBox
            // 
            this.Cancha_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cancha_comboBox.FormattingEnabled = true;
            this.Cancha_comboBox.Location = new System.Drawing.Point(122, 6);
            this.Cancha_comboBox.Name = "Cancha_comboBox";
            this.Cancha_comboBox.Size = new System.Drawing.Size(252, 21);
            this.Cancha_comboBox.TabIndex = 1;
            this.Cancha_comboBox.SelectedIndexChanged += new System.EventHandler(this.Cancha_comboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "* Fecha:";
            // 
            // fecha_dateTimePicker
            // 
            this.fecha_dateTimePicker.Location = new System.Drawing.Point(122, 82);
            this.fecha_dateTimePicker.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.fecha_dateTimePicker.MinDate = new System.DateTime(2023, 6, 5, 0, 0, 0, 0);
            this.fecha_dateTimePicker.Name = "fecha_dateTimePicker";
            this.fecha_dateTimePicker.Size = new System.Drawing.Size(255, 20);
            this.fecha_dateTimePicker.TabIndex = 3;
            this.fecha_dateTimePicker.Value = new System.DateTime(2023, 6, 5, 0, 0, 0, 0);
            this.fecha_dateTimePicker.ValueChanged += new System.EventHandler(this.fecha_dateTimePicker_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "* Duración del alquiler:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Agregar extras:";
            // 
            // Opciones_comboBox
            // 
            this.Opciones_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Opciones_comboBox.FormattingEnabled = true;
            this.Opciones_comboBox.Location = new System.Drawing.Point(122, 49);
            this.Opciones_comboBox.Name = "Opciones_comboBox";
            this.Opciones_comboBox.Size = new System.Drawing.Size(255, 21);
            this.Opciones_comboBox.TabIndex = 6;
            this.Opciones_comboBox.SelectedIndexChanged += new System.EventHandler(this.Opciones_comboBox_SelectedIndexChanged);
            // 
            // horas_numericUpDown
            // 
            this.horas_numericUpDown.Location = new System.Drawing.Point(132, 117);
            this.horas_numericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.horas_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.horas_numericUpDown.Name = "horas_numericUpDown";
            this.horas_numericUpDown.Size = new System.Drawing.Size(54, 20);
            this.horas_numericUpDown.TabIndex = 7;
            this.horas_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.horas_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.horas_numericUpDown.ValueChanged += new System.EventHandler(this.horas_numericUpDown_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valor total:";
            // 
            // totalValue_lbl
            // 
            this.totalValue_lbl.AutoSize = true;
            this.totalValue_lbl.Location = new System.Drawing.Point(112, 290);
            this.totalValue_lbl.Name = "totalValue_lbl";
            this.totalValue_lbl.Size = new System.Drawing.Size(59, 13);
            this.totalValue_lbl.TabIndex = 9;
            this.totalValue_lbl.Text = "total_value";
            // 
            // VerDisponibilidad_btn
            // 
            this.VerDisponibilidad_btn.Location = new System.Drawing.Point(12, 378);
            this.VerDisponibilidad_btn.Name = "VerDisponibilidad_btn";
            this.VerDisponibilidad_btn.Size = new System.Drawing.Size(82, 38);
            this.VerDisponibilidad_btn.TabIndex = 10;
            this.VerDisponibilidad_btn.Text = "Ver Disponibilidad";
            this.VerDisponibilidad_btn.UseVisualStyleBackColor = true;
            this.VerDisponibilidad_btn.Click += new System.EventHandler(this.VerDisponibilidad_btn_Click);
            // 
            // Alquilar_btn
            // 
            this.Alquilar_btn.Location = new System.Drawing.Point(12, 422);
            this.Alquilar_btn.Name = "Alquilar_btn";
            this.Alquilar_btn.Size = new System.Drawing.Size(82, 38);
            this.Alquilar_btn.TabIndex = 11;
            this.Alquilar_btn.Text = "Alquilar";
            this.Alquilar_btn.UseVisualStyleBackColor = true;
            this.Alquilar_btn.Click += new System.EventHandler(this.Alquilar_btn_Click);
            // 
            // Cancelar_btn
            // 
            this.Cancelar_btn.Location = new System.Drawing.Point(427, 373);
            this.Cancelar_btn.Name = "Cancelar_btn";
            this.Cancelar_btn.Size = new System.Drawing.Size(82, 38);
            this.Cancelar_btn.TabIndex = 12;
            this.Cancelar_btn.Text = "Cancelar";
            this.Cancelar_btn.UseVisualStyleBackColor = true;
            this.Cancelar_btn.Click += new System.EventHandler(this.Cancelar_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Estado:";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 14;
            this.label8.Visible = false;
            // 
            // estadoValue_lbl
            // 
            this.estadoValue_lbl.AutoSize = true;
            this.estadoValue_lbl.Location = new System.Drawing.Point(149, 391);
            this.estadoValue_lbl.Name = "estadoValue_lbl";
            this.estadoValue_lbl.Size = new System.Drawing.Size(71, 13);
            this.estadoValue_lbl.TabIndex = 15;
            this.estadoValue_lbl.Text = "estado_value";
            this.estadoValue_lbl.Visible = false;
            // 
            // CalcularTotal_btn
            // 
            this.CalcularTotal_btn.Location = new System.Drawing.Point(12, 334);
            this.CalcularTotal_btn.Name = "CalcularTotal_btn";
            this.CalcularTotal_btn.Size = new System.Drawing.Size(82, 38);
            this.CalcularTotal_btn.TabIndex = 16;
            this.CalcularTotal_btn.Text = "Calcular total";
            this.CalcularTotal_btn.UseVisualStyleBackColor = true;
            this.CalcularTotal_btn.Click += new System.EventHandler(this.CalcularTotal_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(424, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Alquileres";
            // 
            // alquileres_listBox
            // 
            this.alquileres_listBox.FormattingEnabled = true;
            this.alquileres_listBox.Location = new System.Drawing.Point(427, 25);
            this.alquileres_listBox.Name = "alquileres_listBox";
            this.alquileres_listBox.Size = new System.Drawing.Size(272, 342);
            this.alquileres_listBox.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "campos obligatorios *";
            // 
            // Horario_numericUpDown
            // 
            this.Horario_numericUpDown.Location = new System.Drawing.Point(132, 148);
            this.Horario_numericUpDown.Maximum = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.Horario_numericUpDown.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.Horario_numericUpDown.Name = "Horario_numericUpDown";
            this.Horario_numericUpDown.Size = new System.Drawing.Size(54, 20);
            this.Horario_numericUpDown.TabIndex = 21;
            this.Horario_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Horario_numericUpDown.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.Horario_numericUpDown.ValueChanged += new System.EventHandler(this.Horario_numericUpDown_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "* Horario:";
            // 
            // EstablecerJueces_btn
            // 
            this.EstablecerJueces_btn.Location = new System.Drawing.Point(15, 179);
            this.EstablecerJueces_btn.Name = "EstablecerJueces_btn";
            this.EstablecerJueces_btn.Size = new System.Drawing.Size(75, 35);
            this.EstablecerJueces_btn.TabIndex = 22;
            this.EstablecerJueces_btn.Text = "Seleccionar jueces";
            this.EstablecerJueces_btn.UseVisualStyleBackColor = true;
            this.EstablecerJueces_btn.Click += new System.EventHandler(this.EstablecerJueces_btn_Click);
            // 
            // jueces_listBox
            // 
            this.jueces_listBox.FormattingEnabled = true;
            this.jueces_listBox.Location = new System.Drawing.Point(125, 179);
            this.jueces_listBox.Name = "jueces_listBox";
            this.jueces_listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.jueces_listBox.Size = new System.Drawing.Size(255, 95);
            this.jueces_listBox.TabIndex = 23;
            // 
            // Frm_nuevoAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 467);
            this.Controls.Add(this.jueces_listBox);
            this.Controls.Add(this.EstablecerJueces_btn);
            this.Controls.Add(this.Horario_numericUpDown);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.alquileres_listBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CalcularTotal_btn);
            this.Controls.Add(this.estadoValue_lbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Cancelar_btn);
            this.Controls.Add(this.Alquilar_btn);
            this.Controls.Add(this.VerDisponibilidad_btn);
            this.Controls.Add(this.totalValue_lbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.horas_numericUpDown);
            this.Controls.Add(this.Opciones_comboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fecha_dateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cancha_comboBox);
            this.Controls.Add(this.label1);
            this.Name = "Frm_nuevoAlquiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Alquiler";
            this.Load += new System.EventHandler(this.Frm_nuevoAlquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.horas_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horario_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cancha_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fecha_dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Opciones_comboBox;
        private System.Windows.Forms.NumericUpDown horas_numericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalValue_lbl;
        private System.Windows.Forms.Button VerDisponibilidad_btn;
        private System.Windows.Forms.Button Alquilar_btn;
        private System.Windows.Forms.Button Cancelar_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label estadoValue_lbl;
        private System.Windows.Forms.Button CalcularTotal_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox alquileres_listBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown Horario_numericUpDown;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button EstablecerJueces_btn;
        private System.Windows.Forms.ListBox jueces_listBox;
    }
}