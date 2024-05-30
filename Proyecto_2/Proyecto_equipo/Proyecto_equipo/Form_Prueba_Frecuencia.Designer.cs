namespace proyecto_inv
{
    partial class Form_Prueba_Frecuencia
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_Alpha = new System.Windows.Forms.TextBox();
            this.txtBox_N_Intervalos = new System.Windows.Forms.TextBox();
            this.btn_Generar = new System.Windows.Forms.Button();
            this.dt_Frecuencias = new System.Windows.Forms.DataGridView();
            this.dt_Intervalos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Frecuencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Intervalos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alpha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de Intervalos";
            // 
            // txtBox_Alpha
            // 
            this.txtBox_Alpha.Location = new System.Drawing.Point(273, 45);
            this.txtBox_Alpha.Name = "txtBox_Alpha";
            this.txtBox_Alpha.Size = new System.Drawing.Size(100, 22);
            this.txtBox_Alpha.TabIndex = 2;
            // 
            // txtBox_N_Intervalos
            // 
            this.txtBox_N_Intervalos.Location = new System.Drawing.Point(273, 78);
            this.txtBox_N_Intervalos.Name = "txtBox_N_Intervalos";
            this.txtBox_N_Intervalos.Size = new System.Drawing.Size(100, 22);
            this.txtBox_N_Intervalos.TabIndex = 3;
            // 
            // btn_Generar
            // 
            this.btn_Generar.Location = new System.Drawing.Point(403, 56);
            this.btn_Generar.Name = "btn_Generar";
            this.btn_Generar.Size = new System.Drawing.Size(113, 23);
            this.btn_Generar.TabIndex = 4;
            this.btn_Generar.Text = "Comenzar prueeba";
            this.btn_Generar.UseVisualStyleBackColor = true;
            this.btn_Generar.Click += new System.EventHandler(this.btn_Generar_Click);
            // 
            // dt_Frecuencias
            // 
            this.dt_Frecuencias.AllowUserToAddRows = false;
            this.dt_Frecuencias.AllowUserToDeleteRows = false;
            this.dt_Frecuencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_Frecuencias.Location = new System.Drawing.Point(310, 136);
            this.dt_Frecuencias.Name = "dt_Frecuencias";
            this.dt_Frecuencias.ReadOnly = true;
            this.dt_Frecuencias.RowHeadersWidth = 51;
            this.dt_Frecuencias.RowTemplate.Height = 24;
            this.dt_Frecuencias.Size = new System.Drawing.Size(240, 245);
            this.dt_Frecuencias.TabIndex = 5;
            // 
            // dt_Intervalos
            // 
            this.dt_Intervalos.AllowUserToAddRows = false;
            this.dt_Intervalos.AllowUserToDeleteRows = false;
            this.dt_Intervalos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_Intervalos.Location = new System.Drawing.Point(39, 136);
            this.dt_Intervalos.Name = "dt_Intervalos";
            this.dt_Intervalos.ReadOnly = true;
            this.dt_Intervalos.RowHeadersWidth = 51;
            this.dt_Intervalos.RowTemplate.Height = 24;
            this.dt_Intervalos.Size = new System.Drawing.Size(240, 245);
            this.dt_Intervalos.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(537, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(537, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 9;
            // 
            // Form_Prueba_Frecuencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dt_Intervalos);
            this.Controls.Add(this.dt_Frecuencias);
            this.Controls.Add(this.btn_Generar);
            this.Controls.Add(this.txtBox_N_Intervalos);
            this.Controls.Add(this.txtBox_Alpha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Prueba_Frecuencia";
            this.Text = "Form_Prueba_Frecuencia";
            ((System.ComponentModel.ISupportInitialize)(this.dt_Frecuencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Intervalos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_Alpha;
        private System.Windows.Forms.TextBox txtBox_N_Intervalos;
        private System.Windows.Forms.Button btn_Generar;
        private System.Windows.Forms.DataGridView dt_Frecuencias;
        private System.Windows.Forms.DataGridView dt_Intervalos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}