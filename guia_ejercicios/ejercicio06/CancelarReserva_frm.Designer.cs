namespace ejercicio06
{
    partial class CancelarReserva_frm
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
            this.numeroReserva_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.montoAbonado_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkin_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.devolucion_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.motivo_textBox = new System.Windows.Forms.TextBox();
            this.Confirmar_btn = new System.Windows.Forms.Button();
            this.Cancelar_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° de reserva:";
            // 
            // numeroReserva_textBox
            // 
            this.numeroReserva_textBox.Location = new System.Drawing.Point(116, 9);
            this.numeroReserva_textBox.Name = "numeroReserva_textBox";
            this.numeroReserva_textBox.ReadOnly = true;
            this.numeroReserva_textBox.Size = new System.Drawing.Size(100, 20);
            this.numeroReserva_textBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monto abonado:";
            // 
            // montoAbonado_textBox
            // 
            this.montoAbonado_textBox.Location = new System.Drawing.Point(116, 39);
            this.montoAbonado_textBox.Name = "montoAbonado_textBox";
            this.montoAbonado_textBox.ReadOnly = true;
            this.montoAbonado_textBox.Size = new System.Drawing.Size(100, 20);
            this.montoAbonado_textBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha del checkin:";
            // 
            // checkin_textBox
            // 
            this.checkin_textBox.Location = new System.Drawing.Point(116, 72);
            this.checkin_textBox.Name = "checkin_textBox";
            this.checkin_textBox.ReadOnly = true;
            this.checkin_textBox.Size = new System.Drawing.Size(100, 20);
            this.checkin_textBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Devolución:";
            // 
            // devolucion_textBox
            // 
            this.devolucion_textBox.Location = new System.Drawing.Point(116, 106);
            this.devolucion_textBox.Name = "devolucion_textBox";
            this.devolucion_textBox.ReadOnly = true;
            this.devolucion_textBox.Size = new System.Drawing.Size(100, 20);
            this.devolucion_textBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Motivo:";
            // 
            // motivo_textBox
            // 
            this.motivo_textBox.Location = new System.Drawing.Point(18, 159);
            this.motivo_textBox.Multiline = true;
            this.motivo_textBox.Name = "motivo_textBox";
            this.motivo_textBox.ReadOnly = true;
            this.motivo_textBox.Size = new System.Drawing.Size(198, 92);
            this.motivo_textBox.TabIndex = 9;
            // 
            // Confirmar_btn
            // 
            this.Confirmar_btn.Location = new System.Drawing.Point(80, 257);
            this.Confirmar_btn.Name = "Confirmar_btn";
            this.Confirmar_btn.Size = new System.Drawing.Size(75, 23);
            this.Confirmar_btn.TabIndex = 10;
            this.Confirmar_btn.Text = "Confirmar";
            this.Confirmar_btn.UseVisualStyleBackColor = true;
            this.Confirmar_btn.Click += new System.EventHandler(this.Confirmar_btn_Click);
            // 
            // Cancelar_btn
            // 
            this.Cancelar_btn.Location = new System.Drawing.Point(80, 286);
            this.Cancelar_btn.Name = "Cancelar_btn";
            this.Cancelar_btn.Size = new System.Drawing.Size(75, 23);
            this.Cancelar_btn.TabIndex = 11;
            this.Cancelar_btn.Text = "Cancelar";
            this.Cancelar_btn.UseVisualStyleBackColor = true;
            this.Cancelar_btn.Click += new System.EventHandler(this.Cancelar_btn_Click);
            // 
            // CancelarReserva_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 328);
            this.Controls.Add(this.Cancelar_btn);
            this.Controls.Add(this.Confirmar_btn);
            this.Controls.Add(this.motivo_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.devolucion_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkin_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.montoAbonado_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numeroReserva_textBox);
            this.Controls.Add(this.label1);
            this.Name = "CancelarReserva_frm";
            this.Text = "Cancelar Reserva";
            this.Load += new System.EventHandler(this.CancelarReserva_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numeroReserva_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox montoAbonado_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox checkin_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox devolucion_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox motivo_textBox;
        private System.Windows.Forms.Button Confirmar_btn;
        private System.Windows.Forms.Button Cancelar_btn;
    }
}