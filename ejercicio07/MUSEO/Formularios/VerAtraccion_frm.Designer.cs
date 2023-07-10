namespace MUSEO.Formularios
{
    partial class VerAtraccion_frm
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
            this.nombre_textBox = new System.Windows.Forms.TextBox();
            this.sector_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.precio_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.animales_listBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Atracción";
            // 
            // nombre_textBox
            // 
            this.nombre_textBox.Location = new System.Drawing.Point(15, 25);
            this.nombre_textBox.Name = "nombre_textBox";
            this.nombre_textBox.ReadOnly = true;
            this.nombre_textBox.Size = new System.Drawing.Size(173, 20);
            this.nombre_textBox.TabIndex = 1;
            // 
            // sector_textBox
            // 
            this.sector_textBox.Location = new System.Drawing.Point(15, 73);
            this.sector_textBox.Name = "sector_textBox";
            this.sector_textBox.ReadOnly = true;
            this.sector_textBox.Size = new System.Drawing.Size(173, 20);
            this.sector_textBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sector de animales";
            // 
            // precio_textBox
            // 
            this.precio_textBox.Location = new System.Drawing.Point(112, 107);
            this.precio_textBox.Name = "precio_textBox";
            this.precio_textBox.ReadOnly = true;
            this.precio_textBox.Size = new System.Drawing.Size(76, 20);
            this.precio_textBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio de visita: $";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Animales";
            // 
            // animales_listBox
            // 
            this.animales_listBox.FormattingEnabled = true;
            this.animales_listBox.Location = new System.Drawing.Point(260, 28);
            this.animales_listBox.Name = "animales_listBox";
            this.animales_listBox.Size = new System.Drawing.Size(288, 186);
            this.animales_listBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VerAtraccion_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 238);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.animales_listBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.precio_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sector_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombre_textBox);
            this.Controls.Add(this.label1);
            this.Name = "VerAtraccion_frm";
            this.Text = "Detalles de la atracción";
            this.Load += new System.EventHandler(this.VerAtraccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombre_textBox;
        private System.Windows.Forms.TextBox sector_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox precio_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox animales_listBox;
        private System.Windows.Forms.Button button1;
    }
}