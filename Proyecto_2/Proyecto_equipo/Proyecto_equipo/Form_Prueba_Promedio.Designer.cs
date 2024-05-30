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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_Xa = new System.Windows.Forms.TextBox();
            this.lb_texto = new System.Windows.Forms.Label();
            this.btn_Generador = new System.Windows.Forms.Button();
            this.dt_Lista_Promedio = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Lista_Promedio)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Za =";
            // 
            // txtBox_Xa
            // 
            this.txtBox_Xa.Location = new System.Drawing.Point(90, 57);
            this.txtBox_Xa.Name = "txtBox_Xa";
            this.txtBox_Xa.Size = new System.Drawing.Size(100, 22);
            this.txtBox_Xa.TabIndex = 10;
            // 
            // lb_texto
            // 
            this.lb_texto.AutoSize = true;
            this.lb_texto.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_texto.Location = new System.Drawing.Point(43, 172);
            this.lb_texto.Name = "lb_texto";
            this.lb_texto.Size = new System.Drawing.Size(0, 24);
            this.lb_texto.TabIndex = 9;
            // 
            // btn_Generador
            // 
            this.btn_Generador.Location = new System.Drawing.Point(224, 57);
            this.btn_Generador.Name = "btn_Generador";
            this.btn_Generador.Size = new System.Drawing.Size(126, 23);
            this.btn_Generador.TabIndex = 8;
            this.btn_Generador.Text = "Realizar Prueba";
            this.btn_Generador.UseVisualStyleBackColor = true;
            this.btn_Generador.Click += new System.EventHandler(this.btn_Generador_Click);
            // 
            // dt_Lista_Promedio
            // 
            this.dt_Lista_Promedio.AllowUserToAddRows = false;
            this.dt_Lista_Promedio.AllowUserToDeleteRows = false;
            this.dt_Lista_Promedio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_Lista_Promedio.Location = new System.Drawing.Point(453, 92);
            this.dt_Lista_Promedio.Name = "dt_Lista_Promedio";
            this.dt_Lista_Promedio.ReadOnly = true;
            this.dt_Lista_Promedio.RowHeadersWidth = 51;
            this.dt_Lista_Promedio.RowTemplate.Height = 24;
            this.dt_Lista_Promedio.Size = new System.Drawing.Size(240, 326);
            this.dt_Lista_Promedio.TabIndex = 7;
            // 
            // Form_Prueba_Promedio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 474);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_Xa);
            this.Controls.Add(this.lb_texto);
            this.Controls.Add(this.btn_Generador);
            this.Controls.Add(this.dt_Lista_Promedio);
            this.Name = "Form_Prueba_Promedio";
            this.Text = "Form_Prueba_Promedio";
            ((System.ComponentModel.ISupportInitialize)(this.dt_Lista_Promedio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_Xa;
        private System.Windows.Forms.Label lb_texto;
        private System.Windows.Forms.Button btn_Generador;
        private System.Windows.Forms.DataGridView dt_Lista_Promedio;
    }
}