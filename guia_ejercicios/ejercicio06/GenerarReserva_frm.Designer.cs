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
            this.Adicional_checkBox = new System.Windows.Forms.CheckBox();
            this.DiasReserva_monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.huespedes_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.habitacionElegida_textBox = new System.Windows.Forms.TextBox();
            this.checkin_textBox = new System.Windows.Forms.TextBox();
            this.checkout_textBox = new System.Windows.Forms.TextBox();
            this.totalDias_textBox = new System.Windows.Forms.TextBox();
            this.unLabel = new System.Windows.Forms.Label();
            this.huespedesElegidos_listBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Deposito_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.button4 = new System.Windows.Forms.Button();
            this.subtotal_textBox = new System.Windows.Forms.TextBox();
            this.totalDeposito_textBox = new System.Windows.Forms.TextBox();
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
            // 
            // Adicional_checkBox
            // 
            this.Adicional_checkBox.AutoSize = true;
            this.Adicional_checkBox.Location = new System.Drawing.Point(15, 52);
            this.Adicional_checkBox.Name = "Adicional_checkBox";
            this.Adicional_checkBox.Size = new System.Drawing.Size(162, 17);
            this.Adicional_checkBox.TabIndex = 3;
            this.Adicional_checkBox.Text = "Agregar cuna a la habitación";
            this.Adicional_checkBox.UseVisualStyleBackColor = true;
            // 
            // DiasReserva_monthCalendar
            // 
            this.DiasReserva_monthCalendar.Location = new System.Drawing.Point(15, 112);
            this.DiasReserva_monthCalendar.MaxSelectionCount = 14;
            this.DiasReserva_monthCalendar.Name = "DiasReserva_monthCalendar";
            this.DiasReserva_monthCalendar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Días a reservar";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox1.Controls.Add(this.totalDeposito_textBox);
            this.groupBox1.Controls.Add(this.subtotal_textBox);
            this.groupBox1.Controls.Add(this.totalDias_textBox);
            this.groupBox1.Controls.Add(this.checkout_textBox);
            this.groupBox1.Controls.Add(this.checkin_textBox);
            this.groupBox1.Controls.Add(this.habitacionElegida_textBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.huespedes_textBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(337, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 304);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumen";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Checkin:";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Días:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Personas que se hospedan:";
            // 
            // huespedes_textBox
            // 
            this.huespedes_textBox.Location = new System.Drawing.Point(9, 134);
            this.huespedes_textBox.Multiline = true;
            this.huespedes_textBox.Name = "huespedes_textBox";
            this.huespedes_textBox.ReadOnly = true;
            this.huespedes_textBox.Size = new System.Drawing.Size(246, 99);
            this.huespedes_textBox.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Subtotal:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Depósito:";
            // 
            // habitacionElegida_textBox
            // 
            this.habitacionElegida_textBox.Location = new System.Drawing.Point(73, 21);
            this.habitacionElegida_textBox.Name = "habitacionElegida_textBox";
            this.habitacionElegida_textBox.ReadOnly = true;
            this.habitacionElegida_textBox.Size = new System.Drawing.Size(261, 20);
            this.habitacionElegida_textBox.TabIndex = 15;
            // 
            // checkin_textBox
            // 
            this.checkin_textBox.Location = new System.Drawing.Point(73, 44);
            this.checkin_textBox.Name = "checkin_textBox";
            this.checkin_textBox.ReadOnly = true;
            this.checkin_textBox.Size = new System.Drawing.Size(103, 20);
            this.checkin_textBox.TabIndex = 16;
            // 
            // checkout_textBox
            // 
            this.checkout_textBox.Location = new System.Drawing.Point(73, 67);
            this.checkout_textBox.Name = "checkout_textBox";
            this.checkout_textBox.ReadOnly = true;
            this.checkout_textBox.Size = new System.Drawing.Size(103, 20);
            this.checkout_textBox.TabIndex = 17;
            // 
            // totalDias_textBox
            // 
            this.totalDias_textBox.Location = new System.Drawing.Point(73, 91);
            this.totalDias_textBox.Name = "totalDias_textBox";
            this.totalDias_textBox.ReadOnly = true;
            this.totalDias_textBox.Size = new System.Drawing.Size(103, 20);
            this.totalDias_textBox.TabIndex = 18;
            // 
            // unLabel
            // 
            this.unLabel.AutoSize = true;
            this.unLabel.Location = new System.Drawing.Point(12, 291);
            this.unLabel.Name = "unLabel";
            this.unLabel.Size = new System.Drawing.Size(61, 13);
            this.unLabel.TabIndex = 7;
            this.unLabel.Text = "Huéspedes";
            // 
            // huespedesElegidos_listBox
            // 
            this.huespedesElegidos_listBox.FormattingEnabled = true;
            this.huespedesElegidos_listBox.Location = new System.Drawing.Point(15, 316);
            this.huespedesElegidos_listBox.Name = "huespedesElegidos_listBox";
            this.huespedesElegidos_listBox.Size = new System.Drawing.Size(248, 121);
            this.huespedesElegidos_listBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Elegir Huésped";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(98, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 34);
            this.button2.TabIndex = 10;
            this.button2.Text = "Registrar Nuevo Huésped";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(346, 319);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 34);
            this.button3.TabIndex = 11;
            this.button3.Text = "Generar Reserva";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 497);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Depósito:";
            // 
            // Deposito_numericUpDown
            // 
            this.Deposito_numericUpDown.Location = new System.Drawing.Point(70, 495);
            this.Deposito_numericUpDown.Name = "Deposito_numericUpDown";
            this.Deposito_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.Deposito_numericUpDown.TabIndex = 13;
            this.Deposito_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(448, 319);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 34);
            this.button4.TabIndex = 14;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // subtotal_textBox
            // 
            this.subtotal_textBox.Location = new System.Drawing.Point(73, 249);
            this.subtotal_textBox.Name = "subtotal_textBox";
            this.subtotal_textBox.ReadOnly = true;
            this.subtotal_textBox.Size = new System.Drawing.Size(103, 20);
            this.subtotal_textBox.TabIndex = 19;
            // 
            // totalDeposito_textBox
            // 
            this.totalDeposito_textBox.Location = new System.Drawing.Point(73, 278);
            this.totalDeposito_textBox.Name = "totalDeposito_textBox";
            this.totalDeposito_textBox.ReadOnly = true;
            this.totalDeposito_textBox.Size = new System.Drawing.Size(103, 20);
            this.totalDeposito_textBox.TabIndex = 20;
            // 
            // GenerarReserva_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 524);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Deposito_numericUpDown);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.huespedesElegidos_listBox);
            this.Controls.Add(this.unLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DiasReserva_monthCalendar);
            this.Controls.Add(this.Adicional_checkBox);
            this.Controls.Add(this.Habitaciones_comboBox);
            this.Controls.Add(this.label1);
            this.Name = "GenerarReserva_frm";
            this.Text = "Nueva Reserva";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Deposito_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Habitaciones_comboBox;
        private System.Windows.Forms.CheckBox Adicional_checkBox;
        private System.Windows.Forms.MonthCalendar DiasReserva_monthCalendar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox huespedes_textBox;
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
        private System.Windows.Forms.ListBox huespedesElegidos_listBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown Deposito_numericUpDown;
        private System.Windows.Forms.TextBox totalDeposito_textBox;
        private System.Windows.Forms.TextBox subtotal_textBox;
        private System.Windows.Forms.Button button4;
    }
}