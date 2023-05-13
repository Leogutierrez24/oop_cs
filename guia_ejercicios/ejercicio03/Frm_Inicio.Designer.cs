namespace ejercicio03
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
            this.label1 = new System.Windows.Forms.Label();
            this.Cafeteras_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox_cafeteraInfo = new System.Windows.Forms.GroupBox();
            this.recaudacionCafe_lbl = new System.Windows.Forms.Label();
            this.precioCafe_lbl = new System.Windows.Forms.Label();
            this.cantidadCafe_lbl = new System.Windows.Forms.Label();
            this.nombreCafe_lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Recargar_btn = new System.Windows.Forms.Button();
            this.PrepararCafe_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OperarCafetera_btn = new System.Windows.Forms.Button();
            this.AgregarCafetera_btn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.total_lbl = new System.Windows.Forms.Label();
            this.groupBox_cafeteraInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cafeteras";
            // 
            // Cafeteras_comboBox
            // 
            this.Cafeteras_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cafeteras_comboBox.FormattingEnabled = true;
            this.Cafeteras_comboBox.Location = new System.Drawing.Point(16, 37);
            this.Cafeteras_comboBox.Name = "Cafeteras_comboBox";
            this.Cafeteras_comboBox.Size = new System.Drawing.Size(157, 21);
            this.Cafeteras_comboBox.TabIndex = 1;
            // 
            // groupBox_cafeteraInfo
            // 
            this.groupBox_cafeteraInfo.Controls.Add(this.recaudacionCafe_lbl);
            this.groupBox_cafeteraInfo.Controls.Add(this.precioCafe_lbl);
            this.groupBox_cafeteraInfo.Controls.Add(this.cantidadCafe_lbl);
            this.groupBox_cafeteraInfo.Controls.Add(this.nombreCafe_lbl);
            this.groupBox_cafeteraInfo.Controls.Add(this.label5);
            this.groupBox_cafeteraInfo.Controls.Add(this.label4);
            this.groupBox_cafeteraInfo.Controls.Add(this.Recargar_btn);
            this.groupBox_cafeteraInfo.Controls.Add(this.PrepararCafe_btn);
            this.groupBox_cafeteraInfo.Controls.Add(this.label3);
            this.groupBox_cafeteraInfo.Controls.Add(this.label2);
            this.groupBox_cafeteraInfo.Location = new System.Drawing.Point(196, 13);
            this.groupBox_cafeteraInfo.Name = "groupBox_cafeteraInfo";
            this.groupBox_cafeteraInfo.Size = new System.Drawing.Size(204, 195);
            this.groupBox_cafeteraInfo.TabIndex = 2;
            this.groupBox_cafeteraInfo.TabStop = false;
            this.groupBox_cafeteraInfo.Text = "cafetera_elegida";
            // 
            // recaudacionCafe_lbl
            // 
            this.recaudacionCafe_lbl.AutoSize = true;
            this.recaudacionCafe_lbl.Location = new System.Drawing.Point(96, 95);
            this.recaudacionCafe_lbl.Name = "recaudacionCafe_lbl";
            this.recaudacionCafe_lbl.Size = new System.Drawing.Size(40, 13);
            this.recaudacionCafe_lbl.TabIndex = 9;
            this.recaudacionCafe_lbl.Text = "000,00";
            // 
            // precioCafe_lbl
            // 
            this.precioCafe_lbl.AutoSize = true;
            this.precioCafe_lbl.Location = new System.Drawing.Point(61, 70);
            this.precioCafe_lbl.Name = "precioCafe_lbl";
            this.precioCafe_lbl.Size = new System.Drawing.Size(40, 13);
            this.precioCafe_lbl.TabIndex = 8;
            this.precioCafe_lbl.Text = "000,00";
            // 
            // cantidadCafe_lbl
            // 
            this.cantidadCafe_lbl.AutoSize = true;
            this.cantidadCafe_lbl.Location = new System.Drawing.Point(148, 46);
            this.cantidadCafe_lbl.Name = "cantidadCafe_lbl";
            this.cantidadCafe_lbl.Size = new System.Drawing.Size(48, 13);
            this.cantidadCafe_lbl.TabIndex = 7;
            this.cantidadCafe_lbl.Text = "cafe_qty";
            // 
            // nombreCafe_lbl
            // 
            this.nombreCafe_lbl.AutoSize = true;
            this.nombreCafe_lbl.Location = new System.Drawing.Point(44, 24);
            this.nombreCafe_lbl.Name = "nombreCafe_lbl";
            this.nombreCafe_lbl.Size = new System.Drawing.Size(60, 13);
            this.nombreCafe_lbl.TabIndex = 6;
            this.nombreCafe_lbl.Text = "cafe_name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total vendido: $";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Precio: $";
            // 
            // Recargar_btn
            // 
            this.Recargar_btn.Location = new System.Drawing.Point(121, 140);
            this.Recargar_btn.Name = "Recargar_btn";
            this.Recargar_btn.Size = new System.Drawing.Size(75, 40);
            this.Recargar_btn.TabIndex = 3;
            this.Recargar_btn.Text = "Recargar";
            this.Recargar_btn.UseVisualStyleBackColor = true;
            // 
            // PrepararCafe_btn
            // 
            this.PrepararCafe_btn.Location = new System.Drawing.Point(9, 140);
            this.PrepararCafe_btn.Name = "PrepararCafe_btn";
            this.PrepararCafe_btn.Size = new System.Drawing.Size(75, 40);
            this.PrepararCafe_btn.TabIndex = 2;
            this.PrepararCafe_btn.Text = "Preparar Café";
            this.PrepararCafe_btn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cantidad disponible (Litros):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cafe:";
            // 
            // OperarCafetera_btn
            // 
            this.OperarCafetera_btn.Location = new System.Drawing.Point(16, 68);
            this.OperarCafetera_btn.Name = "OperarCafetera_btn";
            this.OperarCafetera_btn.Size = new System.Drawing.Size(75, 40);
            this.OperarCafetera_btn.TabIndex = 10;
            this.OperarCafetera_btn.Text = "Operar Cafetera";
            this.OperarCafetera_btn.UseVisualStyleBackColor = true;
            // 
            // AgregarCafetera_btn
            // 
            this.AgregarCafetera_btn.Location = new System.Drawing.Point(98, 68);
            this.AgregarCafetera_btn.Name = "AgregarCafetera_btn";
            this.AgregarCafetera_btn.Size = new System.Drawing.Size(75, 40);
            this.AgregarCafetera_btn.TabIndex = 11;
            this.AgregarCafetera_btn.Text = "Agregar Cafetera";
            this.AgregarCafetera_btn.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(16, 168);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 40);
            this.button5.TabIndex = 12;
            this.button5.Text = "Generar Resumen";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Recaudación total: $";
            // 
            // total_lbl
            // 
            this.total_lbl.AutoSize = true;
            this.total_lbl.Location = new System.Drawing.Point(125, 143);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Size = new System.Drawing.Size(46, 13);
            this.total_lbl.TabIndex = 13;
            this.total_lbl.Text = "0000,00";
            // 
            // Frm_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 224);
            this.Controls.Add(this.total_lbl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.AgregarCafetera_btn);
            this.Controls.Add(this.OperarCafetera_btn);
            this.Controls.Add(this.groupBox_cafeteraInfo);
            this.Controls.Add(this.Cafeteras_comboBox);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Inicio";
            this.Text = "Cafeteria";
            this.groupBox_cafeteraInfo.ResumeLayout(false);
            this.groupBox_cafeteraInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cafeteras_comboBox;
        private System.Windows.Forms.GroupBox groupBox_cafeteraInfo;
        private System.Windows.Forms.Label recaudacionCafe_lbl;
        private System.Windows.Forms.Label precioCafe_lbl;
        private System.Windows.Forms.Label cantidadCafe_lbl;
        private System.Windows.Forms.Label nombreCafe_lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Recargar_btn;
        private System.Windows.Forms.Button PrepararCafe_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OperarCafetera_btn;
        private System.Windows.Forms.Button AgregarCafetera_btn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label total_lbl;
    }
}

