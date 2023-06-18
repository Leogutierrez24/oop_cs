namespace ejercicio05
{
    partial class Frm_registrarJuez
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
            this.legajo_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nombre_textBox = new System.Windows.Forms.TextBox();
            this.apellido_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Registrar_btn = new System.Windows.Forms.Button();
            this.Cancelar_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.legajo_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // legajo_numericUpDown
            // 
            this.legajo_numericUpDown.Location = new System.Drawing.Point(120, 12);
            this.legajo_numericUpDown.Name = "legajo_numericUpDown";
            this.legajo_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.legajo_numericUpDown.TabIndex = 0;
            this.legajo_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "N° de Legajo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // nombre_textBox
            // 
            this.nombre_textBox.Location = new System.Drawing.Point(120, 47);
            this.nombre_textBox.Name = "nombre_textBox";
            this.nombre_textBox.Size = new System.Drawing.Size(120, 20);
            this.nombre_textBox.TabIndex = 3;
            // 
            // apellido_textBox
            // 
            this.apellido_textBox.Location = new System.Drawing.Point(120, 82);
            this.apellido_textBox.Name = "apellido_textBox";
            this.apellido_textBox.Size = new System.Drawing.Size(120, 20);
            this.apellido_textBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido:";
            // 
            // Registrar_btn
            // 
            this.Registrar_btn.Location = new System.Drawing.Point(15, 132);
            this.Registrar_btn.Name = "Registrar_btn";
            this.Registrar_btn.Size = new System.Drawing.Size(79, 35);
            this.Registrar_btn.TabIndex = 6;
            this.Registrar_btn.Text = "Registrar";
            this.Registrar_btn.UseVisualStyleBackColor = true;
            this.Registrar_btn.Click += new System.EventHandler(this.Registrar_btn_Click);
            // 
            // Cancelar_btn
            // 
            this.Cancelar_btn.Location = new System.Drawing.Point(120, 132);
            this.Cancelar_btn.Name = "Cancelar_btn";
            this.Cancelar_btn.Size = new System.Drawing.Size(79, 35);
            this.Cancelar_btn.TabIndex = 7;
            this.Cancelar_btn.Text = "Cancelar";
            this.Cancelar_btn.UseVisualStyleBackColor = true;
            this.Cancelar_btn.Click += new System.EventHandler(this.Cancelar_btn_Click);
            // 
            // Frm_registrarJuez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 182);
            this.Controls.Add(this.Cancelar_btn);
            this.Controls.Add(this.Registrar_btn);
            this.Controls.Add(this.apellido_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nombre_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.legajo_numericUpDown);
            this.Name = "Frm_registrarJuez";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Juez";
            ((System.ComponentModel.ISupportInitialize)(this.legajo_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown legajo_numericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre_textBox;
        private System.Windows.Forms.TextBox apellido_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Registrar_btn;
        private System.Windows.Forms.Button Cancelar_btn;
    }
}