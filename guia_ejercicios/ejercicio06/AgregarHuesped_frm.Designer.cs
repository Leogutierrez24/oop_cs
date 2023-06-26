namespace ejercicio06
{
    partial class AgregarHuesped_frm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nombre_textBox = new System.Windows.Forms.TextBox();
            this.apellido_textBox = new System.Windows.Forms.TextBox();
            this.documento_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fechaNacimiento_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.edad_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Registrar_btn = new System.Windows.Forms.Button();
            this.Cancelar_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.documento_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edad_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Edad";
            // 
            // nombre_textBox
            // 
            this.nombre_textBox.Location = new System.Drawing.Point(29, 25);
            this.nombre_textBox.Name = "nombre_textBox";
            this.nombre_textBox.Size = new System.Drawing.Size(221, 20);
            this.nombre_textBox.TabIndex = 5;
            // 
            // apellido_textBox
            // 
            this.apellido_textBox.Location = new System.Drawing.Point(29, 73);
            this.apellido_textBox.Name = "apellido_textBox";
            this.apellido_textBox.Size = new System.Drawing.Size(221, 20);
            this.apellido_textBox.TabIndex = 6;
            // 
            // documento_numericUpDown
            // 
            this.documento_numericUpDown.Location = new System.Drawing.Point(29, 123);
            this.documento_numericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.documento_numericUpDown.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.documento_numericUpDown.Name = "documento_numericUpDown";
            this.documento_numericUpDown.Size = new System.Drawing.Size(221, 20);
            this.documento_numericUpDown.TabIndex = 7;
            this.documento_numericUpDown.Value = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            // 
            // fechaNacimiento_dateTimePicker
            // 
            this.fechaNacimiento_dateTimePicker.Location = new System.Drawing.Point(29, 179);
            this.fechaNacimiento_dateTimePicker.MaxDate = new System.DateTime(2023, 6, 26, 0, 0, 0, 0);
            this.fechaNacimiento_dateTimePicker.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.fechaNacimiento_dateTimePicker.Name = "fechaNacimiento_dateTimePicker";
            this.fechaNacimiento_dateTimePicker.Size = new System.Drawing.Size(221, 20);
            this.fechaNacimiento_dateTimePicker.TabIndex = 8;
            this.fechaNacimiento_dateTimePicker.Value = new System.DateTime(2023, 6, 26, 0, 0, 0, 0);
            // 
            // edad_numericUpDown
            // 
            this.edad_numericUpDown.Location = new System.Drawing.Point(29, 234);
            this.edad_numericUpDown.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.edad_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edad_numericUpDown.Name = "edad_numericUpDown";
            this.edad_numericUpDown.Size = new System.Drawing.Size(59, 20);
            this.edad_numericUpDown.TabIndex = 9;
            this.edad_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Registrar_btn
            // 
            this.Registrar_btn.Location = new System.Drawing.Point(29, 275);
            this.Registrar_btn.Name = "Registrar_btn";
            this.Registrar_btn.Size = new System.Drawing.Size(85, 39);
            this.Registrar_btn.TabIndex = 10;
            this.Registrar_btn.Text = "Registrar";
            this.Registrar_btn.UseVisualStyleBackColor = true;
            this.Registrar_btn.Click += new System.EventHandler(this.Registrar_btn_Click);
            // 
            // Cancelar_btn
            // 
            this.Cancelar_btn.Location = new System.Drawing.Point(165, 275);
            this.Cancelar_btn.Name = "Cancelar_btn";
            this.Cancelar_btn.Size = new System.Drawing.Size(85, 39);
            this.Cancelar_btn.TabIndex = 11;
            this.Cancelar_btn.Text = "Cancelar";
            this.Cancelar_btn.UseVisualStyleBackColor = true;
            this.Cancelar_btn.Click += new System.EventHandler(this.Cancelar_btn_Click);
            // 
            // AgregarHuesped_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 327);
            this.Controls.Add(this.Cancelar_btn);
            this.Controls.Add(this.Registrar_btn);
            this.Controls.Add(this.edad_numericUpDown);
            this.Controls.Add(this.fechaNacimiento_dateTimePicker);
            this.Controls.Add(this.documento_numericUpDown);
            this.Controls.Add(this.apellido_textBox);
            this.Controls.Add(this.nombre_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AgregarHuesped_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Nuevo Huesped";
            ((System.ComponentModel.ISupportInitialize)(this.documento_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edad_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nombre_textBox;
        private System.Windows.Forms.TextBox apellido_textBox;
        private System.Windows.Forms.NumericUpDown documento_numericUpDown;
        private System.Windows.Forms.DateTimePicker fechaNacimiento_dateTimePicker;
        private System.Windows.Forms.NumericUpDown edad_numericUpDown;
        private System.Windows.Forms.Button Registrar_btn;
        private System.Windows.Forms.Button Cancelar_btn;
    }
}