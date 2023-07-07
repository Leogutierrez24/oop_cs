namespace ejercicio03
{
    partial class Frm_agregarCafetera
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
            this.Cafes_comboBox = new System.Windows.Forms.ComboBox();
            this.AgregarCafetera_btn = new System.Windows.Forms.Button();
            this.Cancelar_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de café:";
            // 
            // Cafes_comboBox
            // 
            this.Cafes_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cafes_comboBox.FormattingEnabled = true;
            this.Cafes_comboBox.Location = new System.Drawing.Point(88, 16);
            this.Cafes_comboBox.Name = "Cafes_comboBox";
            this.Cafes_comboBox.Size = new System.Drawing.Size(165, 21);
            this.Cafes_comboBox.TabIndex = 1;
            // 
            // AgregarCafetera_btn
            // 
            this.AgregarCafetera_btn.Location = new System.Drawing.Point(15, 91);
            this.AgregarCafetera_btn.Name = "AgregarCafetera_btn";
            this.AgregarCafetera_btn.Size = new System.Drawing.Size(76, 41);
            this.AgregarCafetera_btn.TabIndex = 2;
            this.AgregarCafetera_btn.Text = "Agregar Cafetera";
            this.AgregarCafetera_btn.UseVisualStyleBackColor = true;
            this.AgregarCafetera_btn.Click += new System.EventHandler(this.AgregarCafetera_btn_Click);
            // 
            // Cancelar_btn
            // 
            this.Cancelar_btn.Location = new System.Drawing.Point(106, 91);
            this.Cancelar_btn.Name = "Cancelar_btn";
            this.Cancelar_btn.Size = new System.Drawing.Size(76, 41);
            this.Cancelar_btn.TabIndex = 3;
            this.Cancelar_btn.Text = "Cancelar";
            this.Cancelar_btn.UseVisualStyleBackColor = true;
            this.Cancelar_btn.Click += new System.EventHandler(this.Cancelar_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Etiqueta de identificación:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(103, 20);
            this.textBox1.TabIndex = 5;
            // 
            // Frm_agregarCafetera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 144);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cancelar_btn);
            this.Controls.Add(this.AgregarCafetera_btn);
            this.Controls.Add(this.Cafes_comboBox);
            this.Controls.Add(this.label1);
            this.Name = "Frm_agregarCafetera";
            this.Text = "Agregar Cafetera";
            this.Load += new System.EventHandler(this.Frm_agregarCafetera_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cafes_comboBox;
        private System.Windows.Forms.Button AgregarCafetera_btn;
        private System.Windows.Forms.Button Cancelar_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}