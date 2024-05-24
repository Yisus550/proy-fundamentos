namespace borrador
{
    partial class Data_gridview
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
            this.DataMas = new System.Windows.Forms.DataGridView();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.salirq = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataMas)).BeginInit();
            this.SuspendLayout();
            // 
            // DataMas
            // 
            this.DataMas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataMas.Location = new System.Drawing.Point(12, 90);
            this.DataMas.Name = "DataMas";
            this.DataMas.RowTemplate.Height = 24;
            this.DataMas.Size = new System.Drawing.Size(776, 348);
            this.DataMas.TabIndex = 0;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(171, 61);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 1;
            this.btn_aceptar.Text = "aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click_1);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(12, 61);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 2;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // salirq
            // 
            this.salirq.Location = new System.Drawing.Point(378, 61);
            this.salirq.Name = "salirq";
            this.salirq.Size = new System.Drawing.Size(75, 23);
            this.salirq.TabIndex = 3;
            this.salirq.Text = "Salir";
            this.salirq.UseVisualStyleBackColor = true;
            this.salirq.Click += new System.EventHandler(this.salirq_Click);
            // 
            // Data_gridview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salirq);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.DataMas);
            this.Name = "Data_gridview";
            this.Text = "Data_gridview";
            ((System.ComponentModel.ISupportInitialize)(this.DataMas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataMas;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button salirq;
    }
}