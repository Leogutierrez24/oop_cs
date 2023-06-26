namespace ejercicio06
{
    partial class VerHabitacion_frm
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
            this.numero_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.costo_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.camas_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.electrodomesticos_textBox = new System.Windows.Forms.TextBox();
            this.Cerrar_btn = new System.Windows.Forms.Button();
            this.vistaMarValue_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Habitación N°:";
            // 
            // numero_textBox
            // 
            this.numero_textBox.Location = new System.Drawing.Point(126, 6);
            this.numero_textBox.Name = "numero_textBox";
            this.numero_textBox.ReadOnly = true;
            this.numero_textBox.Size = new System.Drawing.Size(147, 20);
            this.numero_textBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Costo p/noche:";
            // 
            // costo_textBox
            // 
            this.costo_textBox.Location = new System.Drawing.Point(126, 40);
            this.costo_textBox.Name = "costo_textBox";
            this.costo_textBox.ReadOnly = true;
            this.costo_textBox.Size = new System.Drawing.Size(147, 20);
            this.costo_textBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Camas:";
            // 
            // camas_textBox
            // 
            this.camas_textBox.Location = new System.Drawing.Point(126, 128);
            this.camas_textBox.Multiline = true;
            this.camas_textBox.Name = "camas_textBox";
            this.camas_textBox.ReadOnly = true;
            this.camas_textBox.Size = new System.Drawing.Size(147, 51);
            this.camas_textBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Electrodomésticos:";
            // 
            // electrodomesticos_textBox
            // 
            this.electrodomesticos_textBox.Location = new System.Drawing.Point(126, 185);
            this.electrodomesticos_textBox.Multiline = true;
            this.electrodomesticos_textBox.Name = "electrodomesticos_textBox";
            this.electrodomesticos_textBox.ReadOnly = true;
            this.electrodomesticos_textBox.Size = new System.Drawing.Size(147, 64);
            this.electrodomesticos_textBox.TabIndex = 7;
            // 
            // Cerrar_btn
            // 
            this.Cerrar_btn.Location = new System.Drawing.Point(92, 271);
            this.Cerrar_btn.Name = "Cerrar_btn";
            this.Cerrar_btn.Size = new System.Drawing.Size(101, 38);
            this.Cerrar_btn.TabIndex = 8;
            this.Cerrar_btn.Text = "Cerrar";
            this.Cerrar_btn.UseVisualStyleBackColor = true;
            this.Cerrar_btn.Click += new System.EventHandler(this.Cerrar_btn_Click);
            // 
            // vistaMarValue_textBox
            // 
            this.vistaMarValue_textBox.Location = new System.Drawing.Point(126, 81);
            this.vistaMarValue_textBox.Name = "vistaMarValue_textBox";
            this.vistaMarValue_textBox.ReadOnly = true;
            this.vistaMarValue_textBox.Size = new System.Drawing.Size(147, 20);
            this.vistaMarValue_textBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Vista al mar:";
            // 
            // VerHabitacion_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 324);
            this.Controls.Add(this.vistaMarValue_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cerrar_btn);
            this.Controls.Add(this.electrodomesticos_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.camas_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.costo_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numero_textBox);
            this.Controls.Add(this.label1);
            this.Name = "VerHabitacion_frm";
            this.Text = "Detalles de la Habitacion";
            this.Load += new System.EventHandler(this.VerHabitacion_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numero_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox costo_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox camas_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox electrodomesticos_textBox;
        private System.Windows.Forms.Button Cerrar_btn;
        private System.Windows.Forms.TextBox vistaMarValue_textBox;
        private System.Windows.Forms.Label label5;
    }
}