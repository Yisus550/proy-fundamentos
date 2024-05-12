namespace borrador
{
    partial class frm_principal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRegistroMascotas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nombreveterinaria1 = new System.Windows.Forms.TextBox();
            this.logotipo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logotipo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnRegistroMascotas);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 835);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nombreveterinaria1);
            this.panel2.Controls.Add(this.logotipo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 180);
            this.panel2.TabIndex = 1;
            // 
            // btnRegistroMascotas
            // 
            this.btnRegistroMascotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.btnRegistroMascotas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistroMascotas.FlatAppearance.BorderSize = 0;
            this.btnRegistroMascotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroMascotas.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroMascotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.btnRegistroMascotas.Location = new System.Drawing.Point(0, 180);
            this.btnRegistroMascotas.Name = "btnRegistroMascotas";
            this.btnRegistroMascotas.Size = new System.Drawing.Size(230, 45);
            this.btnRegistroMascotas.TabIndex = 2;
            this.btnRegistroMascotas.Text = "Registro de citas";
            this.btnRegistroMascotas.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.button1.Location = new System.Drawing.Point(0, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Registro de mascotas";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // nombreveterinaria1
            // 
            this.nombreveterinaria1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.nombreveterinaria1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombreveterinaria1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreveterinaria1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.nombreveterinaria1.Location = new System.Drawing.Point(11, 115);
            this.nombreveterinaria1.Margin = new System.Windows.Forms.Padding(2);
            this.nombreveterinaria1.Name = "nombreveterinaria1";
            this.nombreveterinaria1.Size = new System.Drawing.Size(209, 26);
            this.nombreveterinaria1.TabIndex = 4;
            this.nombreveterinaria1.Text = "PATITAS CONTENTAS";
            // 
            // logotipo
            // 
            this.logotipo.Image = global::borrador.Properties.Resources.logotipo;
            this.logotipo.Location = new System.Drawing.Point(63, 11);
            this.logotipo.Margin = new System.Windows.Forms.Padding(2);
            this.logotipo.Name = "logotipo";
            this.logotipo.Size = new System.Drawing.Size(94, 87);
            this.logotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logotipo.TabIndex = 3;
            this.logotipo.TabStop = false;
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1342, 835);
            this.Controls.Add(this.panel1);
            this.Name = "frm_principal";
            this.Text = "Veterinaria";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logotipo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRegistroMascotas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nombreveterinaria1;
        private System.Windows.Forms.PictureBox logotipo;
    }
}