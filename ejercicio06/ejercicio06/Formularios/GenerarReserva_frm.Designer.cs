namespace ejercicio06
{
    partial class GenerarReserva_frm
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
            this.Habitaciones_comboBox = new System.Windows.Forms.ComboBox();
            this.Adicional1_checkBox = new System.Windows.Forms.CheckBox();
            this.DiasReserva_monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EliminarHuesped_btn = new System.Windows.Forms.Button();
            this.EliminarAgregado_btn = new System.Windows.Forms.Button();
            this.HuespedesElegidos_listBox = new System.Windows.Forms.ListBox();
            this.AgregadosElegidos_listBox = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.totalDeposito_textBox = new System.Windows.Forms.TextBox();
            this.subtotal_textBox = new System.Windows.Forms.TextBox();
            this.totalDias_textBox = new System.Windows.Forms.TextBox();
            this.checkout_textBox = new System.Windows.Forms.TextBox();
            this.checkin_textBox = new System.Windows.Forms.TextBox();
            this.habitacionElegida_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.unLabel = new System.Windows.Forms.Label();
            this.Huespedes_listBox = new System.Windows.Forms.ListBox();
            this.ElegirHuesped_btn = new System.Windows.Forms.Button();
            this.RegistrarHuesped_btn = new System.Windows.Forms.Button();
            this.GenerarReserva_btn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Deposito_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Cancelar_btn = new System.Windows.Forms.Button();
            this.Adicional2_checkBox = new System.Windows.Forms.CheckBox();
            this.AgregarExtra_btn = new System.Windows.Forms.Button();
            this.error_lbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Deposito_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Habitación a reservar";
            // 
            // Habitaciones_comboBox
            // 
            this.Habitaciones_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Habitaciones_comboBox.FormattingEnabled = true;
            this.Habitaciones_comboBox.Location = new System.Drawing.Point(15, 25);
            this.Habitaciones_comboBox.Name = "Habitaciones_comboBox";
            this.Habitaciones_comboBox.Size = new System.Drawing.Size(255, 21);
            this.Habitaciones_comboBox.TabIndex = 1;
            this.Habitaciones_comboBox.SelectedIndexChanged += new System.EventHandler(this.Habitaciones_comboBox_SelectedIndexChanged);
            // 
            // Adicional1_checkBox
            // 
            this.Adicional1_checkBox.AutoSize = true;
            this.Adicional1_checkBox.Location = new System.Drawing.Point(15, 52);
            this.Adicional1_checkBox.Name = "Adicional1_checkBox";
            this.Adicional1_checkBox.Size = new System.Drawing.Size(162, 17);
            this.Adicional1_checkBox.TabIndex = 3;
            this.Adicional1_checkBox.Text = "Agregar cuna a la habitación";
            this.Adicional1_checkBox.UseVisualStyleBackColor = true;
            this.Adicional1_checkBox.CheckedChanged += new System.EventHandler(this.Adicional1_checkBox_CheckedChanged);
            // 
            // DiasReserva_monthCalendar
            // 
            this.DiasReserva_monthCalendar.Location = new System.Drawing.Point(15, 151);
            this.DiasReserva_monthCalendar.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.DiasReserva_monthCalendar.MaxSelectionCount = 14;
            this.DiasReserva_monthCalendar.MinDate = new System.DateTime(2023, 6, 30, 0, 0, 0, 0);
            this.DiasReserva_monthCalendar.Name = "DiasReserva_monthCalendar";
            this.DiasReserva_monthCalendar.TabIndex = 4;
            this.DiasReserva_monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.DiasReserva_monthCalendar_DateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Días a reservar";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox1.Controls.Add(this.EliminarHuesped_btn);
            this.groupBox1.Controls.Add(this.EliminarAgregado_btn);
            this.groupBox1.Controls.Add(this.HuespedesElegidos_listBox);
            this.groupBox1.Controls.Add(this.AgregadosElegidos_listBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.totalDeposito_textBox);
            this.groupBox1.Controls.Add(this.subtotal_textBox);
            this.groupBox1.Controls.Add(this.totalDias_textBox);
            this.groupBox1.Controls.Add(this.checkout_textBox);
            this.groupBox1.Controls.Add(this.checkin_textBox);
            this.groupBox1.Controls.Add(this.habitacionElegida_textBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(337, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 400);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumen";
            // 
            // EliminarHuesped_btn
            // 
            this.EliminarHuesped_btn.Location = new System.Drawing.Point(265, 225);
            this.EliminarHuesped_btn.Name = "EliminarHuesped_btn";
            this.EliminarHuesped_btn.Size = new System.Drawing.Size(69, 23);
            this.EliminarHuesped_btn.TabIndex = 24;
            this.EliminarHuesped_btn.Text = "Eliminar";
            this.EliminarHuesped_btn.UseVisualStyleBackColor = true;
            this.EliminarHuesped_btn.Click += new System.EventHandler(this.EliminarHuesped_btn_Click);
            // 
            // EliminarAgregado_btn
            // 
            this.EliminarAgregado_btn.Location = new System.Drawing.Point(265, 136);
            this.EliminarAgregado_btn.Name = "EliminarAgregado_btn";
            this.EliminarAgregado_btn.Size = new System.Drawing.Size(69, 23);
            this.EliminarAgregado_btn.TabIndex = 23;
            this.EliminarAgregado_btn.Text = "Eliminar";
            this.EliminarAgregado_btn.UseVisualStyleBackColor = true;
            this.EliminarAgregado_btn.Click += new System.EventHandler(this.EliminarAgregado_btn_Click);
            // 
            // HuespedesElegidos_listBox
            // 
            this.HuespedesElegidos_listBox.FormattingEnabled = true;
            this.HuespedesElegidos_listBox.Location = new System.Drawing.Point(11, 225);
            this.HuespedesElegidos_listBox.Name = "HuespedesElegidos_listBox";
            this.HuespedesElegidos_listBox.Size = new System.Drawing.Size(248, 108);
            this.HuespedesElegidos_listBox.TabIndex = 22;
            // 
            // AgregadosElegidos_listBox
            // 
            this.AgregadosElegidos_listBox.FormattingEnabled = true;
            this.AgregadosElegidos_listBox.Location = new System.Drawing.Point(11, 136);
            this.AgregadosElegidos_listBox.Name = "AgregadosElegidos_listBox";
            this.AgregadosElegidos_listBox.Size = new System.Drawing.Size(248, 69);
            this.AgregadosElegidos_listBox.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Agregados a la habitación:";
            // 
            // totalDeposito_textBox
            // 
            this.totalDeposito_textBox.Location = new System.Drawing.Point(73, 369);
            this.totalDeposito_textBox.Name = "totalDeposito_textBox";
            this.totalDeposito_textBox.ReadOnly = true;
            this.totalDeposito_textBox.Size = new System.Drawing.Size(103, 20);
            this.totalDeposito_textBox.TabIndex = 20;
            // 
            // subtotal_textBox
            // 
            this.subtotal_textBox.Location = new System.Drawing.Point(73, 340);
            this.subtotal_textBox.Name = "subtotal_textBox";
            this.subtotal_textBox.ReadOnly = true;
            this.subtotal_textBox.Size = new System.Drawing.Size(103, 20);
            this.subtotal_textBox.TabIndex = 19;
            // 
            // totalDias_textBox
            // 
            this.totalDias_textBox.Location = new System.Drawing.Point(73, 91);
            this.totalDias_textBox.Name = "totalDias_textBox";
            this.totalDias_textBox.ReadOnly = true;
            this.totalDias_textBox.Size = new System.Drawing.Size(103, 20);
            this.totalDias_textBox.TabIndex = 18;
            // 
            // checkout_textBox
            // 
            this.checkout_textBox.Location = new System.Drawing.Point(73, 67);
            this.checkout_textBox.Name = "checkout_textBox";
            this.checkout_textBox.ReadOnly = true;
            this.checkout_textBox.Size = new System.Drawing.Size(103, 20);
            this.checkout_textBox.TabIndex = 17;
            // 
            // checkin_textBox
            // 
            this.checkin_textBox.Location = new System.Drawing.Point(73, 44);
            this.checkin_textBox.Name = "checkin_textBox";
            this.checkin_textBox.ReadOnly = true;
            this.checkin_textBox.Size = new System.Drawing.Size(103, 20);
            this.checkin_textBox.TabIndex = 16;
            // 
            // habitacionElegida_textBox
            // 
            this.habitacionElegida_textBox.Location = new System.Drawing.Point(73, 21);
            this.habitacionElegida_textBox.Name = "habitacionElegida_textBox";
            this.habitacionElegida_textBox.ReadOnly = true;
            this.habitacionElegida_textBox.Size = new System.Drawing.Size(261, 20);
            this.habitacionElegida_textBox.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Depósito:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Subtotal:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Personas que se hospedan:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Días:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Checkout:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Checkin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Habitación:";
            // 
            // unLabel
            // 
            this.unLabel.AutoSize = true;
            this.unLabel.Location = new System.Drawing.Point(12, 330);
            this.unLabel.Name = "unLabel";
            this.unLabel.Size = new System.Drawing.Size(61, 13);
            this.unLabel.TabIndex = 7;
            this.unLabel.Text = "Huéspedes";
            // 
            // Huespedes_listBox
            // 
            this.Huespedes_listBox.FormattingEnabled = true;
            this.Huespedes_listBox.Location = new System.Drawing.Point(15, 355);
            this.Huespedes_listBox.Name = "Huespedes_listBox";
            this.Huespedes_listBox.Size = new System.Drawing.Size(248, 121);
            this.Huespedes_listBox.TabIndex = 8;
            // 
            // ElegirHuesped_btn
            // 
            this.ElegirHuesped_btn.Location = new System.Drawing.Point(15, 482);
            this.ElegirHuesped_btn.Name = "ElegirHuesped_btn";
            this.ElegirHuesped_btn.Size = new System.Drawing.Size(77, 34);
            this.ElegirHuesped_btn.TabIndex = 9;
            this.ElegirHuesped_btn.Text = "Elegir Huésped";
            this.ElegirHuesped_btn.UseVisualStyleBackColor = true;
            this.ElegirHuesped_btn.Click += new System.EventHandler(this.ElegirHuesped_btn_Click);
            // 
            // RegistrarHuesped_btn
            // 
            this.RegistrarHuesped_btn.Location = new System.Drawing.Point(98, 482);
            this.RegistrarHuesped_btn.Name = "RegistrarHuesped_btn";
            this.RegistrarHuesped_btn.Size = new System.Drawing.Size(98, 34);
            this.RegistrarHuesped_btn.TabIndex = 10;
            this.RegistrarHuesped_btn.Text = "Registrar Nuevo Huésped";
            this.RegistrarHuesped_btn.UseVisualStyleBackColor = true;
            this.RegistrarHuesped_btn.Click += new System.EventHandler(this.RegistrarHuesped_btn_Click);
            // 
            // GenerarReserva_btn
            // 
            this.GenerarReserva_btn.Location = new System.Drawing.Point(348, 415);
            this.GenerarReserva_btn.Name = "GenerarReserva_btn";
            this.GenerarReserva_btn.Size = new System.Drawing.Size(82, 34);
            this.GenerarReserva_btn.TabIndex = 11;
            this.GenerarReserva_btn.Text = "Generar Reserva";
            this.GenerarReserva_btn.UseVisualStyleBackColor = true;
            this.GenerarReserva_btn.Click += new System.EventHandler(this.GenerarReserva_btn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 536);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Depósito:";
            // 
            // Deposito_numericUpDown
            // 
            this.Deposito_numericUpDown.DecimalPlaces = 2;
            this.Deposito_numericUpDown.Location = new System.Drawing.Point(70, 534);
            this.Deposito_numericUpDown.Name = "Deposito_numericUpDown";
            this.Deposito_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.Deposito_numericUpDown.TabIndex = 13;
            this.Deposito_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Deposito_numericUpDown.ValueChanged += new System.EventHandler(this.Deposito_numericUpDown_ValueChanged);
            // 
            // Cancelar_btn
            // 
            this.Cancelar_btn.Location = new System.Drawing.Point(450, 415);
            this.Cancelar_btn.Name = "Cancelar_btn";
            this.Cancelar_btn.Size = new System.Drawing.Size(82, 34);
            this.Cancelar_btn.TabIndex = 14;
            this.Cancelar_btn.Text = "Cancelar";
            this.Cancelar_btn.UseVisualStyleBackColor = true;
            this.Cancelar_btn.Click += new System.EventHandler(this.Cancelar_btn_Click);
            // 
            // Adicional2_checkBox
            // 
            this.Adicional2_checkBox.AutoSize = true;
            this.Adicional2_checkBox.Location = new System.Drawing.Point(15, 75);
            this.Adicional2_checkBox.Name = "Adicional2_checkBox";
            this.Adicional2_checkBox.Size = new System.Drawing.Size(162, 17);
            this.Adicional2_checkBox.TabIndex = 15;
            this.Adicional2_checkBox.Text = "Agregar consumo de frigobar";
            this.Adicional2_checkBox.UseVisualStyleBackColor = true;
            this.Adicional2_checkBox.CheckedChanged += new System.EventHandler(this.Adicional2_checkBox_CheckedChanged);
            // 
            // AgregarExtra_btn
            // 
            this.AgregarExtra_btn.Location = new System.Drawing.Point(15, 100);
            this.AgregarExtra_btn.Name = "AgregarExtra_btn";
            this.AgregarExtra_btn.Size = new System.Drawing.Size(90, 23);
            this.AgregarExtra_btn.TabIndex = 16;
            this.AgregarExtra_btn.Text = "Agregar otros";
            this.AgregarExtra_btn.UseVisualStyleBackColor = true;
            this.AgregarExtra_btn.Click += new System.EventHandler(this.AgregarExtra_btn_Click);
            // 
            // error_lbl
            // 
            this.error_lbl.AutoSize = true;
            this.error_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_lbl.ForeColor = System.Drawing.Color.Firebrick;
            this.error_lbl.Location = new System.Drawing.Point(334, 463);
            this.error_lbl.Name = "error_lbl";
            this.error_lbl.Size = new System.Drawing.Size(339, 15);
            this.error_lbl.TabIndex = 17;
            this.error_lbl.Text = "* El rango de fechas establecido coincide con uno existente *";
            this.error_lbl.Visible = false;
            // 
            // GenerarReserva_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 565);
            this.Controls.Add(this.error_lbl);
            this.Controls.Add(this.AgregarExtra_btn);
            this.Controls.Add(this.Adicional2_checkBox);
            this.Controls.Add(this.Cancelar_btn);
            this.Controls.Add(this.Deposito_numericUpDown);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.GenerarReserva_btn);
            this.Controls.Add(this.RegistrarHuesped_btn);
            this.Controls.Add(this.ElegirHuesped_btn);
            this.Controls.Add(this.Huespedes_listBox);
            this.Controls.Add(this.unLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DiasReserva_monthCalendar);
            this.Controls.Add(this.Adicional1_checkBox);
            this.Controls.Add(this.Habitaciones_comboBox);
            this.Controls.Add(this.label1);
            this.Name = "GenerarReserva_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Reserva";
            this.Load += new System.EventHandler(this.GenerarReserva_frm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Deposito_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Habitaciones_comboBox;
        private System.Windows.Forms.CheckBox Adicional1_checkBox;
        private System.Windows.Forms.MonthCalendar DiasReserva_monthCalendar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox totalDias_textBox;
        private System.Windows.Forms.TextBox checkout_textBox;
        private System.Windows.Forms.TextBox checkin_textBox;
        private System.Windows.Forms.TextBox habitacionElegida_textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label unLabel;
        private System.Windows.Forms.ListBox Huespedes_listBox;
        private System.Windows.Forms.Button ElegirHuesped_btn;
        private System.Windows.Forms.Button RegistrarHuesped_btn;
        private System.Windows.Forms.Button GenerarReserva_btn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown Deposito_numericUpDown;
        private System.Windows.Forms.TextBox totalDeposito_textBox;
        private System.Windows.Forms.TextBox subtotal_textBox;
        private System.Windows.Forms.Button Cancelar_btn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox Adicional2_checkBox;
        private System.Windows.Forms.Button AgregarExtra_btn;
        private System.Windows.Forms.ListBox HuespedesElegidos_listBox;
        private System.Windows.Forms.ListBox AgregadosElegidos_listBox;
        private System.Windows.Forms.Button EliminarHuesped_btn;
        private System.Windows.Forms.Button EliminarAgregado_btn;
        private System.Windows.Forms.Label error_lbl;
    }
}