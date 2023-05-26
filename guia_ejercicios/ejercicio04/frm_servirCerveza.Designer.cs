namespace ejercicio04
{
    partial class frm_servirCerveza
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
            this.cervezas_comboBox = new System.Windows.Forms.ComboBox();
            this.barriles_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vasos_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.total_lbl = new System.Windows.Forms.Label();
            this.servir_btn = new System.Windows.Forms.Button();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cantidad_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cerveza:";
            // 
            // cervezas_comboBox
            // 
            this.cervezas_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cervezas_comboBox.FormattingEnabled = true;
            this.cervezas_comboBox.Location = new System.Drawing.Point(67, 6);
            this.cervezas_comboBox.Name = "cervezas_comboBox";
            this.cervezas_comboBox.Size = new System.Drawing.Size(158, 21);
            this.cervezas_comboBox.TabIndex = 1;
            this.cervezas_comboBox.SelectedIndexChanged += new System.EventHandler(this.cervezas_comboBox_SelectedIndexChanged);
            // 
            // barriles_comboBox
            // 
            this.barriles_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.barriles_comboBox.FormattingEnabled = true;
            this.barriles_comboBox.Location = new System.Drawing.Point(67, 65);
            this.barriles_comboBox.Name = "barriles_comboBox";
            this.barriles_comboBox.Size = new System.Drawing.Size(158, 21);
            this.barriles_comboBox.TabIndex = 3;
            this.barriles_comboBox.SelectedIndexChanged += new System.EventHandler(this.barriles_comboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Barril:";
            // 
            // vasos_comboBox
            // 
            this.vasos_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vasos_comboBox.FormattingEnabled = true;
            this.vasos_comboBox.Location = new System.Drawing.Point(67, 145);
            this.vasos_comboBox.Name = "vasos_comboBox";
            this.vasos_comboBox.Size = new System.Drawing.Size(158, 21);
            this.vasos_comboBox.TabIndex = 5;
            this.vasos_comboBox.SelectedIndexChanged += new System.EventHandler(this.vasos_comboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vaso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total:";
            // 
            // total_lbl
            // 
            this.total_lbl.AutoSize = true;
            this.total_lbl.Location = new System.Drawing.Point(64, 190);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Size = new System.Drawing.Size(59, 13);
            this.total_lbl.TabIndex = 7;
            this.total_lbl.Text = "total_value";
            // 
            // servir_btn
            // 
            this.servir_btn.Enabled = false;
            this.servir_btn.Location = new System.Drawing.Point(15, 224);
            this.servir_btn.Name = "servir_btn";
            this.servir_btn.Size = new System.Drawing.Size(82, 30);
            this.servir_btn.TabIndex = 8;
            this.servir_btn.Text = "Servir";
            this.servir_btn.UseVisualStyleBackColor = true;
            this.servir_btn.Click += new System.EventHandler(this.servir_btn_Click);
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.Location = new System.Drawing.Point(103, 224);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(82, 30);
            this.cancelar_btn.TabIndex = 9;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.UseVisualStyleBackColor = true;
            this.cancelar_btn.Click += new System.EventHandler(this.cancelar_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cant. disponible:";
            // 
            // cantidad_lbl
            // 
            this.cantidad_lbl.AutoSize = true;
            this.cantidad_lbl.Location = new System.Drawing.Point(103, 108);
            this.cantidad_lbl.Name = "cantidad_lbl";
            this.cantidad_lbl.Size = new System.Drawing.Size(80, 13);
            this.cantidad_lbl.TabIndex = 11;
            this.cantidad_lbl.Text = "cantidad_value";
            // 
            // frm_servirCerveza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 266);
            this.Controls.Add(this.cantidad_lbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.servir_btn);
            this.Controls.Add(this.total_lbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vasos_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.barriles_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cervezas_comboBox);
            this.Controls.Add(this.label1);
            this.Name = "frm_servirCerveza";
            this.Text = "Preparar Pedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cervezas_comboBox;
        private System.Windows.Forms.ComboBox barriles_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox vasos_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label total_lbl;
        private System.Windows.Forms.Button servir_btn;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label cantidad_lbl;
    }
}