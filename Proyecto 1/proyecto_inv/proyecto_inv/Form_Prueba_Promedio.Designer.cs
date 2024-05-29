namespace proyecto_inv
{
    partial class Form_Prueba_Promedio
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
            this.dt_Lista_Promedio = new System.Windows.Forms.DataGridView();
            this.btn_Generador = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Lista_Promedio)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_Lista_Promedio
            // 
            this.dt_Lista_Promedio.AllowUserToAddRows = false;
            this.dt_Lista_Promedio.AllowUserToDeleteRows = false;
            this.dt_Lista_Promedio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_Lista_Promedio.Location = new System.Drawing.Point(445, 38);
            this.dt_Lista_Promedio.Name = "dt_Lista_Promedio";
            this.dt_Lista_Promedio.ReadOnly = true;
            this.dt_Lista_Promedio.RowHeadersWidth = 51;
            this.dt_Lista_Promedio.RowTemplate.Height = 24;
            this.dt_Lista_Promedio.Size = new System.Drawing.Size(240, 370);
            this.dt_Lista_Promedio.TabIndex = 0;
            // 
            // btn_Generador
            // 
            this.btn_Generador.Location = new System.Drawing.Point(100, 184);
            this.btn_Generador.Name = "btn_Generador";
            this.btn_Generador.Size = new System.Drawing.Size(126, 23);
            this.btn_Generador.TabIndex = 1;
            this.btn_Generador.Text = "Realizar Prueba";
            this.btn_Generador.UseVisualStyleBackColor = true;
            this.btn_Generador.Click += new System.EventHandler(this.btn_Generador_Click);
            // 
            // Form_Prueba_Promedio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Generador);
            this.Controls.Add(this.dt_Lista_Promedio);
            this.Name = "Form_Prueba_Promedio";
            this.Text = "Form_Prueba_Promedio";
            ((System.ComponentModel.ISupportInitialize)(this.dt_Lista_Promedio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_Lista_Promedio;
        private System.Windows.Forms.Button btn_Generador;
    }
}