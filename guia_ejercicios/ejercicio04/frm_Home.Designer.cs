namespace ejercicio04
{
    partial class frm_Home
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.servirCerveza_btn = new System.Windows.Forms.Button();
            this.agregarBarril_btn = new System.Windows.Forms.Button();
            this.cervezas_listBox = new System.Windows.Forms.ListBox();
            this.vasos_listBox = new System.Windows.Forms.ListBox();
            this.barriles_listBox = new System.Windows.Forms.ListBox();
            this.resumen_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.recaudacion_lbl = new System.Windows.Forms.Label();
            this.quitarBarril_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cervezas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vasos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Barriles";
            // 
            // servirCerveza_btn
            // 
            this.servirCerveza_btn.Location = new System.Drawing.Point(12, 126);
            this.servirCerveza_btn.Name = "servirCerveza_btn";
            this.servirCerveza_btn.Size = new System.Drawing.Size(80, 47);
            this.servirCerveza_btn.TabIndex = 6;
            this.servirCerveza_btn.Text = "Servir cerveza";
            this.servirCerveza_btn.UseVisualStyleBackColor = true;
            this.servirCerveza_btn.Click += new System.EventHandler(this.servirCerveza_btn_Click);
            // 
            // agregarBarril_btn
            // 
            this.agregarBarril_btn.Location = new System.Drawing.Point(98, 126);
            this.agregarBarril_btn.Name = "agregarBarril_btn";
            this.agregarBarril_btn.Size = new System.Drawing.Size(80, 47);
            this.agregarBarril_btn.TabIndex = 7;
            this.agregarBarril_btn.Text = "Agregar nuevo barril";
            this.agregarBarril_btn.UseVisualStyleBackColor = true;
            this.agregarBarril_btn.Click += new System.EventHandler(this.agregarBarril_btn_Click);
            // 
            // cervezas_listBox
            // 
            this.cervezas_listBox.FormattingEnabled = true;
            this.cervezas_listBox.Location = new System.Drawing.Point(12, 25);
            this.cervezas_listBox.Name = "cervezas_listBox";
            this.cervezas_listBox.Size = new System.Drawing.Size(192, 95);
            this.cervezas_listBox.TabIndex = 9;
            // 
            // vasos_listBox
            // 
            this.vasos_listBox.FormattingEnabled = true;
            this.vasos_listBox.Location = new System.Drawing.Point(224, 25);
            this.vasos_listBox.Name = "vasos_listBox";
            this.vasos_listBox.Size = new System.Drawing.Size(192, 95);
            this.vasos_listBox.TabIndex = 10;
            // 
            // barriles_listBox
            // 
            this.barriles_listBox.FormattingEnabled = true;
            this.barriles_listBox.Location = new System.Drawing.Point(438, 25);
            this.barriles_listBox.Name = "barriles_listBox";
            this.barriles_listBox.Size = new System.Drawing.Size(192, 95);
            this.barriles_listBox.TabIndex = 11;
            // 
            // resumen_btn
            // 
            this.resumen_btn.Location = new System.Drawing.Point(270, 126);
            this.resumen_btn.Name = "resumen_btn";
            this.resumen_btn.Size = new System.Drawing.Size(80, 47);
            this.resumen_btn.TabIndex = 12;
            this.resumen_btn.Text = "Generar Resumen";
            this.resumen_btn.UseVisualStyleBackColor = true;
            this.resumen_btn.Click += new System.EventHandler(this.resumen_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Recaudación total:";
            // 
            // recaudacion_lbl
            // 
            this.recaudacion_lbl.AutoSize = true;
            this.recaudacion_lbl.Location = new System.Drawing.Point(459, 143);
            this.recaudacion_lbl.Name = "recaudacion_lbl";
            this.recaudacion_lbl.Size = new System.Drawing.Size(98, 13);
            this.recaudacion_lbl.TabIndex = 14;
            this.recaudacion_lbl.Text = "recaudacion_value";
            // 
            // quitarBarril_btn
            // 
            this.quitarBarril_btn.Location = new System.Drawing.Point(184, 126);
            this.quitarBarril_btn.Name = "quitarBarril_btn";
            this.quitarBarril_btn.Size = new System.Drawing.Size(80, 47);
            this.quitarBarril_btn.TabIndex = 15;
            this.quitarBarril_btn.Text = "Quitar barril";
            this.quitarBarril_btn.UseVisualStyleBackColor = true;
            this.quitarBarril_btn.Click += new System.EventHandler(this.quitarBarril_btn_Click);
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 185);
            this.Controls.Add(this.quitarBarril_btn);
            this.Controls.Add(this.recaudacion_lbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resumen_btn);
            this.Controls.Add(this.agregarBarril_btn);
            this.Controls.Add(this.servirCerveza_btn);
            this.Controls.Add(this.barriles_listBox);
            this.Controls.Add(this.vasos_listBox);
            this.Controls.Add(this.cervezas_listBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Home";
            this.Text = "After Office";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button servirCerveza_btn;
        private System.Windows.Forms.Button agregarBarril_btn;
        private System.Windows.Forms.ListBox cervezas_listBox;
        private System.Windows.Forms.ListBox vasos_listBox;
        private System.Windows.Forms.ListBox barriles_listBox;
        private System.Windows.Forms.Button resumen_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label recaudacion_lbl;
        private System.Windows.Forms.Button quitarBarril_btn;
    }
}

