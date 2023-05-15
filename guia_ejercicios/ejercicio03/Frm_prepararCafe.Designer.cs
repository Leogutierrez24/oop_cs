namespace ejercicio03
{
    partial class Frm_prepararCafe
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
            this.Vasos_comboBox = new System.Windows.Forms.ComboBox();
            this.cafe_textBox = new System.Windows.Forms.TextBox();
            this.Precio_textBox = new System.Windows.Forms.TextBox();
            this.PrepararCafe_btn = new System.Windows.Forms.Button();
            this.Cancelar_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Café:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opciones de vasos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total: $";
            // 
            // Vasos_comboBox
            // 
            this.Vasos_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Vasos_comboBox.FormattingEnabled = true;
            this.Vasos_comboBox.Location = new System.Drawing.Point(119, 36);
            this.Vasos_comboBox.Name = "Vasos_comboBox";
            this.Vasos_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Vasos_comboBox.TabIndex = 3;
            this.Vasos_comboBox.SelectedIndexChanged += new System.EventHandler(this.Vasos_comboBox_SelectedIndexChanged);
            // 
            // cafe_textBox
            // 
            this.cafe_textBox.Location = new System.Drawing.Point(119, 6);
            this.cafe_textBox.Name = "cafe_textBox";
            this.cafe_textBox.ReadOnly = true;
            this.cafe_textBox.Size = new System.Drawing.Size(121, 20);
            this.cafe_textBox.TabIndex = 4;
            // 
            // Precio_textBox
            // 
            this.Precio_textBox.Location = new System.Drawing.Point(119, 67);
            this.Precio_textBox.Name = "Precio_textBox";
            this.Precio_textBox.ReadOnly = true;
            this.Precio_textBox.Size = new System.Drawing.Size(121, 20);
            this.Precio_textBox.TabIndex = 5;
            // 
            // PrepararCafe_btn
            // 
            this.PrepararCafe_btn.Location = new System.Drawing.Point(15, 110);
            this.PrepararCafe_btn.Name = "PrepararCafe_btn";
            this.PrepararCafe_btn.Size = new System.Drawing.Size(88, 36);
            this.PrepararCafe_btn.TabIndex = 6;
            this.PrepararCafe_btn.Text = "Preparar Café";
            this.PrepararCafe_btn.UseVisualStyleBackColor = true;
            this.PrepararCafe_btn.Click += new System.EventHandler(this.PrepararCafe_btn_Click);
            // 
            // Cancelar_btn
            // 
            this.Cancelar_btn.Location = new System.Drawing.Point(119, 110);
            this.Cancelar_btn.Name = "Cancelar_btn";
            this.Cancelar_btn.Size = new System.Drawing.Size(88, 36);
            this.Cancelar_btn.TabIndex = 7;
            this.Cancelar_btn.Text = "Cancelar";
            this.Cancelar_btn.UseVisualStyleBackColor = true;
            this.Cancelar_btn.Click += new System.EventHandler(this.Cancelar_btn_Click);
            // 
            // Frm_prepararCafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 162);
            this.Controls.Add(this.Cancelar_btn);
            this.Controls.Add(this.PrepararCafe_btn);
            this.Controls.Add(this.Precio_textBox);
            this.Controls.Add(this.cafe_textBox);
            this.Controls.Add(this.Vasos_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_prepararCafe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preparar Café";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Vasos_comboBox;
        private System.Windows.Forms.TextBox cafe_textBox;
        private System.Windows.Forms.TextBox Precio_textBox;
        private System.Windows.Forms.Button PrepararCafe_btn;
        private System.Windows.Forms.Button Cancelar_btn;
    }
}