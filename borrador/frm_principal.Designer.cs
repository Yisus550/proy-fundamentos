﻿namespace borrador
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnRegistroMascotas = new System.Windows.Forms.Button();
            this.btnRegistroCitas = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.nombreveterinaria1 = new System.Windows.Forms.TextBox();
            this.logotipo = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelMenu2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.submenuCitas = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logotipo)).BeginInit();
            this.panelChildForm.SuspendLayout();
            this.panelMenu2.SuspendLayout();
            this.submenuCitas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.panelMenu.Controls.Add(this.btnRegistroMascotas);
            this.panelMenu.Controls.Add(this.submenuCitas);
            this.panelMenu.Controls.Add(this.btnRegistroCitas);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(60, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(350, 1028);
            this.panelMenu.TabIndex = 0;
            // 
            // btnRegistroMascotas
            // 
            this.btnRegistroMascotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.btnRegistroMascotas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistroMascotas.FlatAppearance.BorderSize = 0;
            this.btnRegistroMascotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroMascotas.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroMascotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.btnRegistroMascotas.Location = new System.Drawing.Point(0, 395);
            this.btnRegistroMascotas.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistroMascotas.Name = "btnRegistroMascotas";
            this.btnRegistroMascotas.Size = new System.Drawing.Size(350, 55);
            this.btnRegistroMascotas.TabIndex = 3;
            this.btnRegistroMascotas.Text = "Registro de mascotas";
            this.btnRegistroMascotas.UseVisualStyleBackColor = false;
            this.btnRegistroMascotas.Click += new System.EventHandler(this.btnRegistroMascotas_Click);
            // 
            // btnRegistroCitas
            // 
            this.btnRegistroCitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.btnRegistroCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistroCitas.FlatAppearance.BorderSize = 0;
            this.btnRegistroCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroCitas.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroCitas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.btnRegistroCitas.Location = new System.Drawing.Point(0, 222);
            this.btnRegistroCitas.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistroCitas.Name = "btnRegistroCitas";
            this.btnRegistroCitas.Size = new System.Drawing.Size(350, 55);
            this.btnRegistroCitas.TabIndex = 2;
            this.btnRegistroCitas.Text = "Citas";
            this.btnRegistroCitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroCitas.UseVisualStyleBackColor = false;
            this.btnRegistroCitas.Click += new System.EventHandler(this.btnRegistroCitas_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.nombreveterinaria1);
            this.panel2.Controls.Add(this.logotipo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 222);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::borrador.Properties.Resources.menu;
            this.button1.Location = new System.Drawing.Point(290, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 40);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nombreveterinaria1
            // 
            this.nombreveterinaria1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.nombreveterinaria1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombreveterinaria1.Enabled = false;
            this.nombreveterinaria1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreveterinaria1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.nombreveterinaria1.Location = new System.Drawing.Point(39, 160);
            this.nombreveterinaria1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombreveterinaria1.Name = "nombreveterinaria1";
            this.nombreveterinaria1.Size = new System.Drawing.Size(279, 33);
            this.nombreveterinaria1.TabIndex = 4;
            this.nombreveterinaria1.Text = "PATITAS CONTENTAS";
            // 
            // logotipo
            // 
            this.logotipo.Image = global::borrador.Properties.Resources.logotipo;
            this.logotipo.Location = new System.Drawing.Point(108, 32);
            this.logotipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logotipo.Name = "logotipo";
            this.logotipo.Size = new System.Drawing.Size(125, 107);
            this.logotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logotipo.TabIndex = 3;
            this.logotipo.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.AutoScroll = true;
            this.panelChildForm.Controls.Add(this.panelMenu);
            this.panelChildForm.Controls.Add(this.panelMenu2);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 0);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(4);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1789, 1028);
            this.panelChildForm.TabIndex = 1;
            // 
            // panelMenu2
            // 
            this.panelMenu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.panelMenu2.Controls.Add(this.button2);
            this.panelMenu2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu2.Location = new System.Drawing.Point(0, 0);
            this.panelMenu2.Name = "panelMenu2";
            this.panelMenu2.Size = new System.Drawing.Size(60, 1028);
            this.panelMenu2.TabIndex = 7;
            this.panelMenu2.Visible = false;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::borrador.Properties.Resources.menu;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 50);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // submenuCitas
            // 
            this.submenuCitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.submenuCitas.Controls.Add(this.button4);
            this.submenuCitas.Controls.Add(this.button3);
            this.submenuCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.submenuCitas.Location = new System.Drawing.Point(0, 277);
            this.submenuCitas.Name = "submenuCitas";
            this.submenuCitas.Size = new System.Drawing.Size(350, 118);
            this.submenuCitas.TabIndex = 4;
            this.submenuCitas.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(350, 55);
            this.button3.TabIndex = 3;
            this.button3.Text = "Registro";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.button4.Location = new System.Drawing.Point(0, 55);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(350, 55);
            this.button4.TabIndex = 4;
            this.button4.Text = "Historial Clinico";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1789, 1028);
            this.Controls.Add(this.panelChildForm);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veterinaria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logotipo)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panelMenu2.ResumeLayout(false);
            this.submenuCitas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRegistroCitas;
        private System.Windows.Forms.Button btnRegistroMascotas;
        private System.Windows.Forms.TextBox nombreveterinaria1;
        private System.Windows.Forms.PictureBox logotipo;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelMenu2;
        private System.Windows.Forms.Panel submenuCitas;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}