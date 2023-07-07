namespace ejercicio02
{
    partial class Formulario_Venta
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CerrarVenta_btn = new System.Windows.Forms.Button();
            this.CancelarVenta_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Nafta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "nafta_name";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(97, 36);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "(Litros)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "$0000,00";
            // 
            // CerrarVenta_btn
            // 
            this.CerrarVenta_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CerrarVenta_btn.Location = new System.Drawing.Point(16, 95);
            this.CerrarVenta_btn.Name = "CerrarVenta_btn";
            this.CerrarVenta_btn.Size = new System.Drawing.Size(89, 44);
            this.CerrarVenta_btn.TabIndex = 7;
            this.CerrarVenta_btn.Text = "Cerrar venta";
            this.CerrarVenta_btn.UseVisualStyleBackColor = true;
            this.CerrarVenta_btn.Click += new System.EventHandler(this.CerrarVenta_btn_Click);
            // 
            // CancelarVenta_btn
            // 
            this.CancelarVenta_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelarVenta_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelarVenta_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelarVenta_btn.Location = new System.Drawing.Point(129, 95);
            this.CancelarVenta_btn.Name = "CancelarVenta_btn";
            this.CancelarVenta_btn.Size = new System.Drawing.Size(72, 44);
            this.CancelarVenta_btn.TabIndex = 8;
            this.CancelarVenta_btn.Text = "Cancelar";
            this.CancelarVenta_btn.UseVisualStyleBackColor = false;
            this.CancelarVenta_btn.Click += new System.EventHandler(this.CancelarVenta_btn_Click);
            // 
            // Formulario_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 164);
            this.Controls.Add(this.CancelarVenta_btn);
            this.Controls.Add(this.CerrarVenta_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Formulario_Venta";
            this.Text = "Formulario de venta";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CerrarVenta_btn;
        private System.Windows.Forms.Button CancelarVenta_btn;
    }
}