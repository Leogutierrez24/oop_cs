namespace ejercicio04
{
    partial class frm_agregarBarril
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
            this.cervezas_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.capacidad_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.id_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.agregar_btn = new System.Windows.Forms.Button();
            this.cancelar_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.capacidad_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // cervezas_comboBox
            // 
            this.cervezas_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cervezas_comboBox.FormattingEnabled = true;
            this.cervezas_comboBox.Location = new System.Drawing.Point(83, 12);
            this.cervezas_comboBox.Name = "cervezas_comboBox";
            this.cervezas_comboBox.Size = new System.Drawing.Size(158, 21);
            this.cervezas_comboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cerveza:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Capacidad:";
            // 
            // capacidad_numericUpDown
            // 
            this.capacidad_numericUpDown.Location = new System.Drawing.Point(83, 74);
            this.capacidad_numericUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.capacidad_numericUpDown.Name = "capacidad_numericUpDown";
            this.capacidad_numericUpDown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.capacidad_numericUpDown.Size = new System.Drawing.Size(158, 20);
            this.capacidad_numericUpDown.TabIndex = 5;
            this.capacidad_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.capacidad_numericUpDown.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "min: 6 / max: 30";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Identificador:";
            // 
            // id_numericUpDown
            // 
            this.id_numericUpDown.Location = new System.Drawing.Point(83, 109);
            this.id_numericUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.id_numericUpDown.Name = "id_numericUpDown";
            this.id_numericUpDown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.id_numericUpDown.Size = new System.Drawing.Size(158, 20);
            this.id_numericUpDown.TabIndex = 8;
            this.id_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.id_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // agregar_btn
            // 
            this.agregar_btn.Location = new System.Drawing.Point(15, 147);
            this.agregar_btn.Name = "agregar_btn";
            this.agregar_btn.Size = new System.Drawing.Size(75, 23);
            this.agregar_btn.TabIndex = 9;
            this.agregar_btn.Text = "Agregar";
            this.agregar_btn.UseVisualStyleBackColor = true;
            this.agregar_btn.Click += new System.EventHandler(this.agregar_btn_Click);
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.Location = new System.Drawing.Point(96, 147);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(75, 23);
            this.cancelar_btn.TabIndex = 10;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.UseVisualStyleBackColor = true;
            this.cancelar_btn.Click += new System.EventHandler(this.cancelar_btn_Click);
            // 
            // frm_agregarBarril
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 178);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.agregar_btn);
            this.Controls.Add(this.id_numericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.capacidad_numericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cervezas_comboBox);
            this.Controls.Add(this.label1);
            this.Name = "frm_agregarBarril";
            this.Text = "Agregar Barril";
            ((System.ComponentModel.ISupportInitialize)(this.capacidad_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cervezas_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown capacidad_numericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown id_numericUpDown;
        private System.Windows.Forms.Button agregar_btn;
        private System.Windows.Forms.Button cancelar_btn;
    }
}