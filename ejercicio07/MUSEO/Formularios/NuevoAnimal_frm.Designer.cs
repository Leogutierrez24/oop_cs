namespace MUSEO.Formularios
{
    partial class NuevoAnimal_frm
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
            this.Habitat_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TipoAlimentacion_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nombre_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Exoesqueleto_comboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Postura_comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Periodo_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Velocidad_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.Vision_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.QuitarAlimento_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.alimentosElegidos_listBox = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ElegirHerbivoro_btn = new System.Windows.Forms.Button();
            this.nombreAlimento_textBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ElegirCarnivoro_btn = new System.Windows.Forms.Button();
            this.animales_listBox = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Periodo_numericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Velocidad_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vision_numericUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Habitat_comboBox
            // 
            this.Habitat_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Habitat_comboBox.FormattingEnabled = true;
            this.Habitat_comboBox.Location = new System.Drawing.Point(12, 25);
            this.Habitat_comboBox.Name = "Habitat_comboBox";
            this.Habitat_comboBox.Size = new System.Drawing.Size(220, 21);
            this.Habitat_comboBox.TabIndex = 0;
            this.Habitat_comboBox.SelectedIndexChanged += new System.EventHandler(this.Habitat_comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hábitat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de alimentación";
            // 
            // TipoAlimentacion_comboBox
            // 
            this.TipoAlimentacion_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoAlimentacion_comboBox.FormattingEnabled = true;
            this.TipoAlimentacion_comboBox.Location = new System.Drawing.Point(12, 84);
            this.TipoAlimentacion_comboBox.Name = "TipoAlimentacion_comboBox";
            this.TipoAlimentacion_comboBox.Size = new System.Drawing.Size(220, 21);
            this.TipoAlimentacion_comboBox.TabIndex = 2;
            this.TipoAlimentacion_comboBox.SelectedIndexChanged += new System.EventHandler(this.TipoAlimentacion_comboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // Nombre_textBox
            // 
            this.Nombre_textBox.Location = new System.Drawing.Point(12, 144);
            this.Nombre_textBox.Name = "Nombre_textBox";
            this.Nombre_textBox.Size = new System.Drawing.Size(220, 20);
            this.Nombre_textBox.TabIndex = 5;
            this.Nombre_textBox.TextChanged += new System.EventHandler(this.Nombre_textBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Exoesqueleto_comboBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Postura_comboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(260, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 102);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animal terrestre";
            // 
            // Exoesqueleto_comboBox
            // 
            this.Exoesqueleto_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Exoesqueleto_comboBox.Enabled = false;
            this.Exoesqueleto_comboBox.FormattingEnabled = true;
            this.Exoesqueleto_comboBox.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.Exoesqueleto_comboBox.Location = new System.Drawing.Point(86, 64);
            this.Exoesqueleto_comboBox.Name = "Exoesqueleto_comboBox";
            this.Exoesqueleto_comboBox.Size = new System.Drawing.Size(146, 21);
            this.Exoesqueleto_comboBox.TabIndex = 9;
            this.Exoesqueleto_comboBox.SelectedIndexChanged += new System.EventHandler(this.Exoesqueleto_comboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Exoesqueleto:";
            // 
            // Postura_comboBox
            // 
            this.Postura_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Postura_comboBox.Enabled = false;
            this.Postura_comboBox.FormattingEnabled = true;
            this.Postura_comboBox.Location = new System.Drawing.Point(86, 25);
            this.Postura_comboBox.Name = "Postura_comboBox";
            this.Postura_comboBox.Size = new System.Drawing.Size(146, 21);
            this.Postura_comboBox.TabIndex = 7;
            this.Postura_comboBox.SelectedIndexChanged += new System.EventHandler(this.Postura_comboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Postura:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Características";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Período de existencia";
            // 
            // Periodo_numericUpDown
            // 
            this.Periodo_numericUpDown.Location = new System.Drawing.Point(128, 187);
            this.Periodo_numericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.Periodo_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Periodo_numericUpDown.Name = "Periodo_numericUpDown";
            this.Periodo_numericUpDown.Size = new System.Drawing.Size(104, 20);
            this.Periodo_numericUpDown.TabIndex = 9;
            this.Periodo_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Periodo_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Periodo_numericUpDown.ValueChanged += new System.EventHandler(this.Periodo_numericUpDown_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.Velocidad_numericUpDown);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.Vision_numericUpDown);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(260, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 102);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Animal Aéreo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(184, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "(km/h)";
            // 
            // Velocidad_numericUpDown
            // 
            this.Velocidad_numericUpDown.Enabled = false;
            this.Velocidad_numericUpDown.Location = new System.Drawing.Point(113, 65);
            this.Velocidad_numericUpDown.Name = "Velocidad_numericUpDown";
            this.Velocidad_numericUpDown.Size = new System.Drawing.Size(65, 20);
            this.Velocidad_numericUpDown.TabIndex = 10;
            this.Velocidad_numericUpDown.ValueChanged += new System.EventHandler(this.Velocidad_numericUpDown_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(184, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "(metros)";
            // 
            // Vision_numericUpDown
            // 
            this.Vision_numericUpDown.Enabled = false;
            this.Vision_numericUpDown.Location = new System.Drawing.Point(113, 26);
            this.Vision_numericUpDown.Name = "Vision_numericUpDown";
            this.Vision_numericUpDown.Size = new System.Drawing.Size(65, 20);
            this.Vision_numericUpDown.TabIndex = 9;
            this.Vision_numericUpDown.ValueChanged += new System.EventHandler(this.Vision_numericUpDown_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Velocidad de vuelo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Alcance de visión:";
            // 
            // QuitarAlimento_btn
            // 
            this.QuitarAlimento_btn.Location = new System.Drawing.Point(291, 502);
            this.QuitarAlimento_btn.Name = "QuitarAlimento_btn";
            this.QuitarAlimento_btn.Size = new System.Drawing.Size(75, 23);
            this.QuitarAlimento_btn.TabIndex = 20;
            this.QuitarAlimento_btn.Text = "Quitar";
            this.QuitarAlimento_btn.UseVisualStyleBackColor = true;
            this.QuitarAlimento_btn.Click += new System.EventHandler(this.QuitarAlimento_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 642);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 642);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // alimentosElegidos_listBox
            // 
            this.alimentosElegidos_listBox.FormattingEnabled = true;
            this.alimentosElegidos_listBox.Location = new System.Drawing.Point(15, 502);
            this.alimentosElegidos_listBox.Name = "alimentosElegidos_listBox";
            this.alimentosElegidos_listBox.Size = new System.Drawing.Size(270, 134);
            this.alimentosElegidos_listBox.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 486);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Alimentos agregados";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ElegirHerbivoro_btn);
            this.groupBox3.Controls.Add(this.nombreAlimento_textBox);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(315, 241);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 106);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alimentación herbívora";
            // 
            // ElegirHerbivoro_btn
            // 
            this.ElegirHerbivoro_btn.Enabled = false;
            this.ElegirHerbivoro_btn.Location = new System.Drawing.Point(9, 69);
            this.ElegirHerbivoro_btn.Name = "ElegirHerbivoro_btn";
            this.ElegirHerbivoro_btn.Size = new System.Drawing.Size(75, 23);
            this.ElegirHerbivoro_btn.TabIndex = 3;
            this.ElegirHerbivoro_btn.Text = "Elegir";
            this.ElegirHerbivoro_btn.UseVisualStyleBackColor = true;
            this.ElegirHerbivoro_btn.Click += new System.EventHandler(this.ElegirHerbivoro_btn_Click);
            // 
            // nombreAlimento_textBox
            // 
            this.nombreAlimento_textBox.Enabled = false;
            this.nombreAlimento_textBox.Location = new System.Drawing.Point(9, 43);
            this.nombreAlimento_textBox.Name = "nombreAlimento_textBox";
            this.nombreAlimento_textBox.Size = new System.Drawing.Size(198, 20);
            this.nombreAlimento_textBox.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Nombre del alimento";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ElegirCarnivoro_btn);
            this.groupBox4.Controls.Add(this.animales_listBox);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(12, 241);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(286, 232);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Alimentación carnívora";
            // 
            // ElegirCarnivoro_btn
            // 
            this.ElegirCarnivoro_btn.Enabled = false;
            this.ElegirCarnivoro_btn.Location = new System.Drawing.Point(9, 183);
            this.ElegirCarnivoro_btn.Name = "ElegirCarnivoro_btn";
            this.ElegirCarnivoro_btn.Size = new System.Drawing.Size(75, 23);
            this.ElegirCarnivoro_btn.TabIndex = 2;
            this.ElegirCarnivoro_btn.Text = "Elegir";
            this.ElegirCarnivoro_btn.UseVisualStyleBackColor = true;
            this.ElegirCarnivoro_btn.Click += new System.EventHandler(this.ElegirCarnivoro_btn_Click);
            // 
            // animales_listBox
            // 
            this.animales_listBox.Enabled = false;
            this.animales_listBox.FormattingEnabled = true;
            this.animales_listBox.Location = new System.Drawing.Point(9, 43);
            this.animales_listBox.Name = "animales_listBox";
            this.animales_listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.animales_listBox.Size = new System.Drawing.Size(261, 134);
            this.animales_listBox.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Animales";
            // 
            // NuevoAnimal_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(557, 682);
            this.Controls.Add(this.QuitarAlimento_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.alimentosElegidos_listBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Periodo_numericUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Nombre_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TipoAlimentacion_comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Habitat_comboBox);
            this.Name = "NuevoAnimal_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Animal";
            this.Load += new System.EventHandler(this.NuevoAnimal_frm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Periodo_numericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Velocidad_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vision_numericUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Habitat_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TipoAlimentacion_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Nombre_textBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Postura_comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Exoesqueleto_comboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown Periodo_numericUpDown;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown Velocidad_numericUpDown;
        private System.Windows.Forms.NumericUpDown Vision_numericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button QuitarAlimento_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox alimentosElegidos_listBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ElegirHerbivoro_btn;
        private System.Windows.Forms.TextBox nombreAlimento_textBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button ElegirCarnivoro_btn;
        private System.Windows.Forms.ListBox animales_listBox;
        private System.Windows.Forms.Label label14;
    }
}