namespace proyecto_inv
{
    partial class Form_Generador_Num
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
            this.btn_Generar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_Numeros_Generados = new System.Windows.Forms.TextBox();
            this.txtBox_Constante_Muntiplicativa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_Semilla = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_Constante_Aditiva = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_Modulo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dt_Numeros_pseudo_lista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Numeros_pseudo_lista)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Generar
            // 
            this.btn_Generar.Location = new System.Drawing.Point(350, 341);
            this.btn_Generar.Name = "btn_Generar";
            this.btn_Generar.Size = new System.Drawing.Size(144, 23);
            this.btn_Generar.TabIndex = 0;
            this.btn_Generar.Text = "Generar Numeros";
            this.btn_Generar.UseVisualStyleBackColor = true;
            this.btn_Generar.Click += new System.EventHandler(this.btn_Generar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidar de Numeros generados";
            // 
            // txtBox_Numeros_Generados
            // 
            this.txtBox_Numeros_Generados.Location = new System.Drawing.Point(420, 84);
            this.txtBox_Numeros_Generados.Name = "txtBox_Numeros_Generados";
            this.txtBox_Numeros_Generados.Size = new System.Drawing.Size(157, 22);
            this.txtBox_Numeros_Generados.TabIndex = 2;
            // 
            // txtBox_Constante_Muntiplicativa
            // 
            this.txtBox_Constante_Muntiplicativa.Location = new System.Drawing.Point(420, 116);
            this.txtBox_Constante_Muntiplicativa.Name = "txtBox_Constante_Muntiplicativa";
            this.txtBox_Constante_Muntiplicativa.Size = new System.Drawing.Size(157, 22);
            this.txtBox_Constante_Muntiplicativa.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Constante multiplicativa (A)";
            // 
            // txtBox_Semilla
            // 
            this.txtBox_Semilla.Location = new System.Drawing.Point(420, 147);
            this.txtBox_Semilla.Name = "txtBox_Semilla";
            this.txtBox_Semilla.Size = new System.Drawing.Size(157, 22);
            this.txtBox_Semilla.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Semilla de números pseudoaleatorios (Xo)";
            // 
            // txtBox_Constante_Aditiva
            // 
            this.txtBox_Constante_Aditiva.Location = new System.Drawing.Point(420, 181);
            this.txtBox_Constante_Aditiva.Name = "txtBox_Constante_Aditiva";
            this.txtBox_Constante_Aditiva.Size = new System.Drawing.Size(157, 22);
            this.txtBox_Constante_Aditiva.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Constante Aditiva (C)";
            // 
            // txtBox_Modulo
            // 
            this.txtBox_Modulo.Location = new System.Drawing.Point(420, 213);
            this.txtBox_Modulo.Name = "txtBox_Modulo";
            this.txtBox_Modulo.Size = new System.Drawing.Size(157, 22);
            this.txtBox_Modulo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Modulo (M)";
            // 
            // dt_Numeros_pseudo_lista
            // 
            this.dt_Numeros_pseudo_lista.AllowUserToAddRows = false;
            this.dt_Numeros_pseudo_lista.AllowUserToDeleteRows = false;
            this.dt_Numeros_pseudo_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_Numeros_pseudo_lista.Location = new System.Drawing.Point(49, 248);
            this.dt_Numeros_pseudo_lista.Name = "dt_Numeros_pseudo_lista";
            this.dt_Numeros_pseudo_lista.ReadOnly = true;
            this.dt_Numeros_pseudo_lista.RowHeadersWidth = 51;
            this.dt_Numeros_pseudo_lista.RowTemplate.Height = 24;
            this.dt_Numeros_pseudo_lista.Size = new System.Drawing.Size(240, 248);
            this.dt_Numeros_pseudo_lista.TabIndex = 11;
            // 
            // Form_Generador_Num
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 521);
            this.Controls.Add(this.dt_Numeros_pseudo_lista);
            this.Controls.Add(this.txtBox_Modulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBox_Constante_Aditiva);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBox_Semilla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBox_Constante_Muntiplicativa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_Numeros_Generados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Generar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Generador_Num";
            this.Text = "Form_Generador_Num";
            ((System.ComponentModel.ISupportInitialize)(this.dt_Numeros_pseudo_lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Generar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_Numeros_Generados;
        private System.Windows.Forms.TextBox txtBox_Constante_Muntiplicativa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_Semilla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_Constante_Aditiva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_Modulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dt_Numeros_pseudo_lista;
    }
}