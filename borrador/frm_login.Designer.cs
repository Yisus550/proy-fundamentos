namespace borrador
{
    partial class frm_login
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblcontraseña = new System.Windows.Forms.Label();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Contra = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btningresar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_mostrarContra = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.Image = global::borrador.Properties.Resources.Imagen_de_WhatsApp_2024_04_23_a_las_21_19_08_5d11ca77;
            this.pictureBox1.Location = new System.Drawing.Point(426, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 153);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Salir);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 222);
            this.panel1.TabIndex = 0;
            // 
            // lblusuario
            // 
            this.lblusuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.lblusuario.Location = new System.Drawing.Point(423, 36);
            this.lblusuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(67, 23);
            this.lblusuario.TabIndex = 19;
            this.lblusuario.Text = "Usuario";
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblcontraseña.AutoSize = true;
            this.lblcontraseña.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.lblcontraseña.Location = new System.Drawing.Point(423, 95);
            this.lblcontraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.Size = new System.Drawing.Size(95, 23);
            this.lblcontraseña.TabIndex = 20;
            this.lblcontraseña.Text = "Contraseña";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Usuario.Location = new System.Drawing.Point(426, 59);
            this.txt_Usuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(200, 20);
            this.txt_Usuario.TabIndex = 21;
            // 
            // txt_Contra
            // 
            this.txt_Contra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Contra.Location = new System.Drawing.Point(427, 124);
            this.txt_Contra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Contra.Name = "txt_Contra";
            this.txt_Contra.Size = new System.Drawing.Size(200, 20);
            this.txt_Contra.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_mostrarContra);
            this.panel2.Controls.Add(this.txt_Contra);
            this.panel2.Controls.Add(this.txt_Usuario);
            this.panel2.Controls.Add(this.lblcontraseña);
            this.panel2.Controls.Add(this.lblusuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 222);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1048, 185);
            this.panel2.TabIndex = 20;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btningresar
            // 
            this.btningresar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btningresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btningresar.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btningresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.btningresar.Location = new System.Drawing.Point(462, 27);
            this.btningresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(118, 33);
            this.btningresar.TabIndex = 19;
            this.btningresar.Text = "INGRESAR";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btningresar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 407);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1048, 106);
            this.panel3.TabIndex = 21;
            // 
            // btn_mostrarContra
            // 
            this.btn_mostrarContra.Location = new System.Drawing.Point(286, 124);
            this.btn_mostrarContra.Name = "btn_mostrarContra";
            this.btn_mostrarContra.Size = new System.Drawing.Size(114, 23);
            this.btn_mostrarContra.TabIndex = 23;
            this.btn_mostrarContra.Text = "Mostrar Contraseña";
            this.btn_mostrarContra.UseVisualStyleBackColor = true;
            this.btn_mostrarContra.Click += new System.EventHandler(this.btn_mostrarContraseña_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(892, 111);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(114, 23);
            this.btn_Salir.TabIndex = 24;
            this.btn_Salir.Text = "Salir del sistema";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1048, 514);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblcontraseña;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.TextBox txt_Contra;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_mostrarContra;
        private System.Windows.Forms.Button btn_Salir;
    }
}