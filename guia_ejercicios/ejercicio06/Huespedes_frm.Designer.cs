﻿namespace ejercicio06
{
    partial class Huespedes_frm
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
            this.huespedes_listBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // huespedes_listBox
            // 
            this.huespedes_listBox.FormattingEnabled = true;
            this.huespedes_listBox.Location = new System.Drawing.Point(12, 12);
            this.huespedes_listBox.Name = "huespedes_listBox";
            this.huespedes_listBox.Size = new System.Drawing.Size(310, 199);
            this.huespedes_listBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cerrar Lista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Huespedes_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 271);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.huespedes_listBox);
            this.Name = "Huespedes_frm";
            this.Text = "Huéspedes Registrados";
            this.Load += new System.EventHandler(this.Huespedes_frm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox huespedes_listBox;
        private System.Windows.Forms.Button button1;
    }
}