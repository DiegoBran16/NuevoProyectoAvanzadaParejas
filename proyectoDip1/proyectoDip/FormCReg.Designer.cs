﻿namespace proyectoDip
{
    partial class FormCReg
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
            this.txtInfoReg = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLey = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ingrese el reglamento que desesa crear";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtInfoReg
            // 
            this.txtInfoReg.Location = new System.Drawing.Point(53, 267);
            this.txtInfoReg.Multiline = true;
            this.txtInfoReg.Name = "txtInfoReg";
            this.txtInfoReg.Size = new System.Drawing.Size(257, 102);
            this.txtInfoReg.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "ingrese la ley a la que pertenece el reglamento";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtLey
            // 
            this.txtLey.Location = new System.Drawing.Point(53, 73);
            this.txtLey.Multiline = true;
            this.txtLey.Name = "txtLey";
            this.txtLey.Size = new System.Drawing.Size(257, 102);
            this.txtLey.TabIndex = 6;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(12, 386);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(83, 26);
            this.btnRegresar.TabIndex = 7;
            this.btnRegresar.Text = "regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // FormCReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 438);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.txtLey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtInfoReg);
            this.Controls.Add(this.label1);
            this.Name = "FormCReg";
            this.Text = "FormCReg";
            this.Load += new System.EventHandler(this.FormCReg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInfoReg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLey;
        private System.Windows.Forms.Button btnRegresar;
    }
}