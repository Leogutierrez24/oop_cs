namespace ejercicio06
{
    partial class Frm_Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VerHabitacion_btn = new System.Windows.Forms.Button();
            this.Habitaciones_listBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RegistrarCheckout_btn = new System.Windows.Forms.Button();
            this.RegistrarCheckin_btn = new System.Windows.Forms.Button();
            this.CancelarReserva_btn = new System.Windows.Forms.Button();
            this.VerReserva_btn = new System.Windows.Forms.Button();
            this.Reservas_listBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.VerHuespedes_btn = new System.Windows.Forms.Button();
            this.GenerarResumen_btn = new System.Windows.Forms.Button();
            this.GenerarReserva_btn = new System.Windows.Forms.Button();
            this.RegistrarHuesped_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VerHabitacion_btn);
            this.groupBox1.Controls.Add(this.Habitaciones_listBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 247);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Habitaciones";
            // 
            // VerHabitacion_btn
            // 
            this.VerHabitacion_btn.Location = new System.Drawing.Point(6, 198);
            this.VerHabitacion_btn.Name = "VerHabitacion_btn";
            this.VerHabitacion_btn.Size = new System.Drawing.Size(79, 39);
            this.VerHabitacion_btn.TabIndex = 1;
            this.VerHabitacion_btn.Text = "Ver Habitación";
            this.VerHabitacion_btn.UseVisualStyleBackColor = true;
            this.VerHabitacion_btn.Click += new System.EventHandler(this.VerHabitacion_btn_Click);
            // 
            // Habitaciones_listBox
            // 
            this.Habitaciones_listBox.FormattingEnabled = true;
            this.Habitaciones_listBox.Location = new System.Drawing.Point(6, 19);
            this.Habitaciones_listBox.Name = "Habitaciones_listBox";
            this.Habitaciones_listBox.Size = new System.Drawing.Size(295, 173);
            this.Habitaciones_listBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RegistrarCheckout_btn);
            this.groupBox2.Controls.Add(this.RegistrarCheckin_btn);
            this.groupBox2.Controls.Add(this.CancelarReserva_btn);
            this.groupBox2.Controls.Add(this.VerReserva_btn);
            this.groupBox2.Controls.Add(this.Reservas_listBox);
            this.groupBox2.Location = new System.Drawing.Point(344, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 289);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reservas";
            // 
            // RegistrarCheckout_btn
            // 
            this.RegistrarCheckout_btn.Location = new System.Drawing.Point(91, 243);
            this.RegistrarCheckout_btn.Name = "RegistrarCheckout_btn";
            this.RegistrarCheckout_btn.Size = new System.Drawing.Size(79, 39);
            this.RegistrarCheckout_btn.TabIndex = 4;
            this.RegistrarCheckout_btn.Text = "Registrar Checkout";
            this.RegistrarCheckout_btn.UseVisualStyleBackColor = true;
            this.RegistrarCheckout_btn.Click += new System.EventHandler(this.RegistrarCheckout_btn_Click);
            // 
            // RegistrarCheckin_btn
            // 
            this.RegistrarCheckin_btn.Location = new System.Drawing.Point(6, 243);
            this.RegistrarCheckin_btn.Name = "RegistrarCheckin_btn";
            this.RegistrarCheckin_btn.Size = new System.Drawing.Size(79, 39);
            this.RegistrarCheckin_btn.TabIndex = 3;
            this.RegistrarCheckin_btn.Text = "Registrar Checkin";
            this.RegistrarCheckin_btn.UseVisualStyleBackColor = true;
            this.RegistrarCheckin_btn.Click += new System.EventHandler(this.RegistrarCheckin_btn_Click);
            // 
            // CancelarReserva_btn
            // 
            this.CancelarReserva_btn.Location = new System.Drawing.Point(91, 198);
            this.CancelarReserva_btn.Name = "CancelarReserva_btn";
            this.CancelarReserva_btn.Size = new System.Drawing.Size(79, 39);
            this.CancelarReserva_btn.TabIndex = 3;
            this.CancelarReserva_btn.Text = "Cancelar Reserva";
            this.CancelarReserva_btn.UseVisualStyleBackColor = true;
            this.CancelarReserva_btn.Click += new System.EventHandler(this.CancelarReserva_btn_Click);
            // 
            // VerReserva_btn
            // 
            this.VerReserva_btn.Location = new System.Drawing.Point(6, 198);
            this.VerReserva_btn.Name = "VerReserva_btn";
            this.VerReserva_btn.Size = new System.Drawing.Size(79, 39);
            this.VerReserva_btn.TabIndex = 2;
            this.VerReserva_btn.Text = "Ver Reserva";
            this.VerReserva_btn.UseVisualStyleBackColor = true;
            this.VerReserva_btn.Click += new System.EventHandler(this.VerReserva_btn_Click);
            // 
            // Reservas_listBox
            // 
            this.Reservas_listBox.FormattingEnabled = true;
            this.Reservas_listBox.Location = new System.Drawing.Point(6, 19);
            this.Reservas_listBox.Name = "Reservas_listBox";
            this.Reservas_listBox.Size = new System.Drawing.Size(295, 173);
            this.Reservas_listBox.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.VerHuespedes_btn);
            this.groupBox3.Controls.Add(this.GenerarResumen_btn);
            this.groupBox3.Controls.Add(this.GenerarReserva_btn);
            this.groupBox3.Controls.Add(this.RegistrarHuesped_btn);
            this.groupBox3.Location = new System.Drawing.Point(12, 265);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 125);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operaciones";
            // 
            // VerHuespedes_btn
            // 
            this.VerHuespedes_btn.Location = new System.Drawing.Point(87, 32);
            this.VerHuespedes_btn.Name = "VerHuespedes_btn";
            this.VerHuespedes_btn.Size = new System.Drawing.Size(75, 39);
            this.VerHuespedes_btn.TabIndex = 3;
            this.VerHuespedes_btn.Text = "Ver Huéspedes";
            this.VerHuespedes_btn.UseVisualStyleBackColor = true;
            this.VerHuespedes_btn.Click += new System.EventHandler(this.VerHuespedes_btn_Click);
            // 
            // GenerarResumen_btn
            // 
            this.GenerarResumen_btn.Location = new System.Drawing.Point(6, 77);
            this.GenerarResumen_btn.Name = "GenerarResumen_btn";
            this.GenerarResumen_btn.Size = new System.Drawing.Size(75, 39);
            this.GenerarResumen_btn.TabIndex = 2;
            this.GenerarResumen_btn.Text = "Generar Resumen";
            this.GenerarResumen_btn.UseVisualStyleBackColor = true;
            this.GenerarResumen_btn.Click += new System.EventHandler(this.GenerarResumen_btn_Click);
            // 
            // GenerarReserva_btn
            // 
            this.GenerarReserva_btn.Location = new System.Drawing.Point(168, 32);
            this.GenerarReserva_btn.Name = "GenerarReserva_btn";
            this.GenerarReserva_btn.Size = new System.Drawing.Size(75, 39);
            this.GenerarReserva_btn.TabIndex = 1;
            this.GenerarReserva_btn.Text = "Generar Reserva";
            this.GenerarReserva_btn.UseVisualStyleBackColor = true;
            this.GenerarReserva_btn.Click += new System.EventHandler(this.GenerarReserva_btn_Click);
            // 
            // RegistrarHuesped_btn
            // 
            this.RegistrarHuesped_btn.Location = new System.Drawing.Point(6, 32);
            this.RegistrarHuesped_btn.Name = "RegistrarHuesped_btn";
            this.RegistrarHuesped_btn.Size = new System.Drawing.Size(75, 39);
            this.RegistrarHuesped_btn.TabIndex = 0;
            this.RegistrarHuesped_btn.Text = "Registrar Huésped";
            this.RegistrarHuesped_btn.UseVisualStyleBackColor = true;
            this.RegistrarHuesped_btn.Click += new System.EventHandler(this.RegistrarHuesped_btn_Click);
            // 
            // Frm_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 399);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Frm_Inicio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button VerHabitacion_btn;
        private System.Windows.Forms.ListBox Habitaciones_listBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CancelarReserva_btn;
        private System.Windows.Forms.Button VerReserva_btn;
        private System.Windows.Forms.ListBox Reservas_listBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button GenerarResumen_btn;
        private System.Windows.Forms.Button GenerarReserva_btn;
        private System.Windows.Forms.Button RegistrarHuesped_btn;
        private System.Windows.Forms.Button VerHuespedes_btn;
        private System.Windows.Forms.Button RegistrarCheckin_btn;
        private System.Windows.Forms.Button RegistrarCheckout_btn;
    }
}

