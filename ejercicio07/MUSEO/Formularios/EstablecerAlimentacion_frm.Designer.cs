namespace MUSEO.Formularios
{
    partial class EstablecerAlimentacion_frm
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
            this.ElegirCarnivoro_btn = new System.Windows.Forms.Button();
            this.animales_listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ElegirHerbivoro_btn = new System.Windows.Forms.Button();
            this.nombreAlimento_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.alimentosElegidos_listBox = new System.Windows.Forms.ListBox();
            this.Aceptar_btn = new System.Windows.Forms.Button();
            this.Cancelar_btn = new System.Windows.Forms.Button();
            this.QuitarAlimento_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ElegirCarnivoro_btn);
            this.groupBox1.Controls.Add(this.animales_listBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alimentación carnívora";
            // 
            // ElegirCarnivoro_btn
            // 
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
            this.animales_listBox.FormattingEnabled = true;
            this.animales_listBox.Location = new System.Drawing.Point(9, 43);
            this.animales_listBox.Name = "animales_listBox";
            this.animales_listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.animales_listBox.Size = new System.Drawing.Size(261, 134);
            this.animales_listBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Animales";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ElegirHerbivoro_btn);
            this.groupBox2.Controls.Add(this.nombreAlimento_textBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(315, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 106);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alimentación herbívora";
            // 
            // ElegirHerbivoro_btn
            // 
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
            this.nombreAlimento_textBox.Location = new System.Drawing.Point(9, 43);
            this.nombreAlimento_textBox.Name = "nombreAlimento_textBox";
            this.nombreAlimento_textBox.Size = new System.Drawing.Size(198, 20);
            this.nombreAlimento_textBox.TabIndex = 4;
            this.nombreAlimento_textBox.TextChanged += new System.EventHandler(this.nombreAlimento_textBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre del alimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alimentos agregados";
            // 
            // alimentosElegidos_listBox
            // 
            this.alimentosElegidos_listBox.FormattingEnabled = true;
            this.alimentosElegidos_listBox.Location = new System.Drawing.Point(12, 279);
            this.alimentosElegidos_listBox.Name = "alimentosElegidos_listBox";
            this.alimentosElegidos_listBox.Size = new System.Drawing.Size(270, 134);
            this.alimentosElegidos_listBox.TabIndex = 3;
            // 
            // Aceptar_btn
            // 
            this.Aceptar_btn.Location = new System.Drawing.Point(12, 419);
            this.Aceptar_btn.Name = "Aceptar_btn";
            this.Aceptar_btn.Size = new System.Drawing.Size(75, 23);
            this.Aceptar_btn.TabIndex = 6;
            this.Aceptar_btn.Text = "Aceptar";
            this.Aceptar_btn.UseVisualStyleBackColor = true;
            this.Aceptar_btn.Click += new System.EventHandler(this.Aceptar_btn_Click);
            // 
            // Cancelar_btn
            // 
            this.Cancelar_btn.Location = new System.Drawing.Point(93, 419);
            this.Cancelar_btn.Name = "Cancelar_btn";
            this.Cancelar_btn.Size = new System.Drawing.Size(75, 23);
            this.Cancelar_btn.TabIndex = 7;
            this.Cancelar_btn.Text = "Cancelar";
            this.Cancelar_btn.UseVisualStyleBackColor = true;
            this.Cancelar_btn.Click += new System.EventHandler(this.Cancelar_btn_Click);
            // 
            // QuitarAlimento_btn
            // 
            this.QuitarAlimento_btn.Location = new System.Drawing.Point(288, 279);
            this.QuitarAlimento_btn.Name = "QuitarAlimento_btn";
            this.QuitarAlimento_btn.Size = new System.Drawing.Size(75, 23);
            this.QuitarAlimento_btn.TabIndex = 8;
            this.QuitarAlimento_btn.Text = "Quitar";
            this.QuitarAlimento_btn.UseVisualStyleBackColor = true;
            this.QuitarAlimento_btn.Click += new System.EventHandler(this.QuitarAlimento_btn_Click);
            // 
            // EstablecerAlimentacion_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 472);
            this.Controls.Add(this.QuitarAlimento_btn);
            this.Controls.Add(this.Cancelar_btn);
            this.Controls.Add(this.Aceptar_btn);
            this.Controls.Add(this.alimentosElegidos_listBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EstablecerAlimentacion_frm";
            this.Text = "Establecer Alimentación";
            this.Load += new System.EventHandler(this.EstablecerAlimentacion_frm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ElegirCarnivoro_btn;
        private System.Windows.Forms.ListBox animales_listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ElegirHerbivoro_btn;
        private System.Windows.Forms.TextBox nombreAlimento_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox alimentosElegidos_listBox;
        private System.Windows.Forms.Button Aceptar_btn;
        private System.Windows.Forms.Button Cancelar_btn;
        private System.Windows.Forms.Button QuitarAlimento_btn;
    }
}