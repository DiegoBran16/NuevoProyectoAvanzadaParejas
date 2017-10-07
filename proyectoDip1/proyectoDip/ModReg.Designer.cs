namespace proyectoDip
{
    partial class ModReg
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
            this.txtLey = new System.Windows.Forms.TextBox();
            this.btnMod = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewReg = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ingrese la ley a la que pertenece el reglamento";
            // 
            // txtLey
            // 
            this.txtLey.Location = new System.Drawing.Point(3, 59);
            this.txtLey.Multiline = true;
            this.txtLey.Name = "txtLey";
            this.txtLey.Size = new System.Drawing.Size(326, 110);
            this.txtLey.TabIndex = 1;
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(435, 234);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(190, 23);
            this.btnMod.TabIndex = 2;
            this.btnMod.Text = "modificar";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "ingrese el reglamento a modificar";
            // 
            // txtReg
            // 
            this.txtReg.Location = new System.Drawing.Point(3, 247);
            this.txtReg.Multiline = true;
            this.txtReg.Name = "txtReg";
            this.txtReg.Size = new System.Drawing.Size(326, 110);
            this.txtReg.TabIndex = 4;
            this.txtReg.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "ingrese la nueva informaciion";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNewReg
            // 
            this.txtNewReg.Location = new System.Drawing.Point(390, 59);
            this.txtNewReg.Multiline = true;
            this.txtNewReg.Name = "txtNewReg";
            this.txtNewReg.Size = new System.Drawing.Size(326, 110);
            this.txtNewReg.TabIndex = 6;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(435, 286);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(190, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(435, 334);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(190, 23);
            this.btnRegresar.TabIndex = 8;
            this.btnRegresar.Text = "regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.button3_Click);
            // 
            // ModReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 475);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtNewReg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtReg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.txtLey);
            this.Controls.Add(this.label1);
            this.Name = "ModReg";
            this.Text = "ModReg";
            this.Load += new System.EventHandler(this.ModReg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLey;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewReg;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegresar;
    }
}