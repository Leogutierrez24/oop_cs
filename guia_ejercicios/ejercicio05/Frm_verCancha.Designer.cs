namespace ejercicio05
{
    partial class Frm_verCancha
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.opciones_listBox = new System.Windows.Forms.ListBox();
            this.precio_textBox = new System.Windows.Forms.TextBox();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.tipo_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Información";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cancha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio p/hora:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Opcionales";
            // 
            // opciones_listBox
            // 
            this.opciones_listBox.FormattingEnabled = true;
            this.opciones_listBox.HorizontalScrollbar = true;
            this.opciones_listBox.Location = new System.Drawing.Point(17, 144);
            this.opciones_listBox.Name = "opciones_listBox";
            this.opciones_listBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.opciones_listBox.Size = new System.Drawing.Size(281, 95);
            this.opciones_listBox.TabIndex = 6;
            // 
            // precio_textBox
            // 
            this.precio_textBox.Location = new System.Drawing.Point(95, 98);
            this.precio_textBox.Name = "precio_textBox";
            this.precio_textBox.ReadOnly = true;
            this.precio_textBox.Size = new System.Drawing.Size(142, 20);
            this.precio_textBox.TabIndex = 7;
            // 
            // id_textBox
            // 
            this.id_textBox.Location = new System.Drawing.Point(95, 45);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.ReadOnly = true;
            this.id_textBox.Size = new System.Drawing.Size(142, 20);
            this.id_textBox.TabIndex = 8;
            // 
            // tipo_textBox
            // 
            this.tipo_textBox.Location = new System.Drawing.Point(95, 70);
            this.tipo_textBox.Name = "tipo_textBox";
            this.tipo_textBox.ReadOnly = true;
            this.tipo_textBox.Size = new System.Drawing.Size(142, 20);
            this.tipo_textBox.TabIndex = 9;
            // 
            // Frm_verCancha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 252);
            this.Controls.Add(this.tipo_textBox);
            this.Controls.Add(this.id_textBox);
            this.Controls.Add(this.precio_textBox);
            this.Controls.Add(this.opciones_listBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_verCancha";
            this.Text = "s";
            this.Load += new System.EventHandler(this.Frm_verCancha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox opciones_listBox;
        private System.Windows.Forms.TextBox precio_textBox;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.TextBox tipo_textBox;
    }
}