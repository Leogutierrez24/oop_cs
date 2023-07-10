
namespace MUSEO
{
    partial class Inicio_frm
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
            this.atracciones_listBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VerAtraccion_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ConsultarAnimales_btn = new System.Windows.Forms.Button();
            this.AgregarNuevoAnimal_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ConsultarRecaudacion_btn = new System.Windows.Forms.Button();
            this.VenderEntrada_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // atracciones_listBox
            // 
            this.atracciones_listBox.FormattingEnabled = true;
            this.atracciones_listBox.Location = new System.Drawing.Point(6, 19);
            this.atracciones_listBox.Name = "atracciones_listBox";
            this.atracciones_listBox.Size = new System.Drawing.Size(233, 173);
            this.atracciones_listBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VerAtraccion_btn);
            this.groupBox1.Controls.Add(this.atracciones_listBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Atracciones";
            // 
            // VerAtraccion_btn
            // 
            this.VerAtraccion_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VerAtraccion_btn.Location = new System.Drawing.Point(245, 19);
            this.VerAtraccion_btn.Name = "VerAtraccion_btn";
            this.VerAtraccion_btn.Size = new System.Drawing.Size(102, 26);
            this.VerAtraccion_btn.TabIndex = 2;
            this.VerAtraccion_btn.Text = "Ver atracción";
            this.VerAtraccion_btn.UseVisualStyleBackColor = true;
            this.VerAtraccion_btn.Click += new System.EventHandler(this.VerAtraccion_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ConsultarAnimales_btn);
            this.groupBox2.Controls.Add(this.AgregarNuevoAnimal_btn);
            this.groupBox2.Location = new System.Drawing.Point(385, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Animales";
            // 
            // ConsultarAnimales_btn
            // 
            this.ConsultarAnimales_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultarAnimales_btn.Location = new System.Drawing.Point(98, 30);
            this.ConsultarAnimales_btn.Name = "ConsultarAnimales_btn";
            this.ConsultarAnimales_btn.Size = new System.Drawing.Size(86, 38);
            this.ConsultarAnimales_btn.TabIndex = 4;
            this.ConsultarAnimales_btn.Text = "Consultar animales";
            this.ConsultarAnimales_btn.UseVisualStyleBackColor = true;
            this.ConsultarAnimales_btn.Click += new System.EventHandler(this.ConsultarAnimales_btn_Click);
            // 
            // AgregarNuevoAnimal_btn
            // 
            this.AgregarNuevoAnimal_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgregarNuevoAnimal_btn.Location = new System.Drawing.Point(6, 30);
            this.AgregarNuevoAnimal_btn.Name = "AgregarNuevoAnimal_btn";
            this.AgregarNuevoAnimal_btn.Size = new System.Drawing.Size(86, 38);
            this.AgregarNuevoAnimal_btn.TabIndex = 3;
            this.AgregarNuevoAnimal_btn.Text = "Agregar nuevo animal";
            this.AgregarNuevoAnimal_btn.UseVisualStyleBackColor = true;
            this.AgregarNuevoAnimal_btn.Click += new System.EventHandler(this.AgregarNuevoAnimal_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ConsultarRecaudacion_btn);
            this.groupBox3.Controls.Add(this.VenderEntrada_btn);
            this.groupBox3.Location = new System.Drawing.Point(385, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(192, 109);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ventas";
            // 
            // ConsultarRecaudacion_btn
            // 
            this.ConsultarRecaudacion_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultarRecaudacion_btn.Location = new System.Drawing.Point(98, 35);
            this.ConsultarRecaudacion_btn.Name = "ConsultarRecaudacion_btn";
            this.ConsultarRecaudacion_btn.Size = new System.Drawing.Size(86, 38);
            this.ConsultarRecaudacion_btn.TabIndex = 5;
            this.ConsultarRecaudacion_btn.Text = "Consultar recaudación";
            this.ConsultarRecaudacion_btn.UseVisualStyleBackColor = true;
            this.ConsultarRecaudacion_btn.Click += new System.EventHandler(this.ConsultarRecaudacion_btn_Click);
            // 
            // VenderEntrada_btn
            // 
            this.VenderEntrada_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VenderEntrada_btn.Location = new System.Drawing.Point(6, 35);
            this.VenderEntrada_btn.Name = "VenderEntrada_btn";
            this.VenderEntrada_btn.Size = new System.Drawing.Size(86, 38);
            this.VenderEntrada_btn.TabIndex = 5;
            this.VenderEntrada_btn.Text = "Vender entrada";
            this.VenderEntrada_btn.UseVisualStyleBackColor = true;
            this.VenderEntrada_btn.Click += new System.EventHandler(this.VenderEntrada_btn_Click);
            // 
            // Inicio_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 240);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Inicio_frm";
            this.Text = "Museo";
            this.Load += new System.EventHandler(this.Inicio_frm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox atracciones_listBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button VerAtraccion_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ConsultarAnimales_btn;
        private System.Windows.Forms.Button AgregarNuevoAnimal_btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ConsultarRecaudacion_btn;
        private System.Windows.Forms.Button VenderEntrada_btn;
    }
}

