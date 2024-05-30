namespace proyecto_inv
{
    partial class Form_Simulacion
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
            this.dataGridViewNumerosCopiados = new System.Windows.Forms.DataGridView();
            this.Contador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pseudoaleatorios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewContadorDuraciones = new System.Windows.Forms.DataGridView();
            this.dataGridViewResultados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNumerosCopiados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContadorDuraciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNumerosCopiados
            // 
            this.dataGridViewNumerosCopiados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewNumerosCopiados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewNumerosCopiados.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridViewNumerosCopiados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewNumerosCopiados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNumerosCopiados.Location = new System.Drawing.Point(327, -23);
            this.dataGridViewNumerosCopiados.Name = "dataGridViewNumerosCopiados";
            this.dataGridViewNumerosCopiados.RowHeadersWidth = 51;
            this.dataGridViewNumerosCopiados.RowTemplate.Height = 24;
            this.dataGridViewNumerosCopiados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewNumerosCopiados.Size = new System.Drawing.Size(412, 252);
            this.dataGridViewNumerosCopiados.TabIndex = 59;
            // 
            // Contador
            // 
            this.Contador.HeaderText = "#";
            this.Contador.MinimumWidth = 6;
            this.Contador.Name = "Contador";
            this.Contador.Width = 43;
            // 
            // Pseudoaleatorios
            // 
            this.Pseudoaleatorios.HeaderText = "Números Pseudoaleatorios";
            this.Pseudoaleatorios.MinimumWidth = 150;
            this.Pseudoaleatorios.Name = "Pseudoaleatorios";
            this.Pseudoaleatorios.Width = 183;
            // 
            // dataGridViewContadorDuraciones
            // 
            this.dataGridViewContadorDuraciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewContadorDuraciones.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewContadorDuraciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewContadorDuraciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContadorDuraciones.Location = new System.Drawing.Point(405, 285);
            this.dataGridViewContadorDuraciones.Name = "dataGridViewContadorDuraciones";
            this.dataGridViewContadorDuraciones.RowHeadersWidth = 51;
            this.dataGridViewContadorDuraciones.RowTemplate.Height = 24;
            this.dataGridViewContadorDuraciones.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewContadorDuraciones.Size = new System.Drawing.Size(314, 200);
            this.dataGridViewContadorDuraciones.TabIndex = 60;
            // 
            // dataGridViewResultados
            // 
            this.dataGridViewResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewResultados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewResultados.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridViewResultados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Contador,
            this.Pseudoaleatorios});
            this.dataGridViewResultados.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewResultados.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewResultados.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewResultados.Name = "dataGridViewResultados";
            this.dataGridViewResultados.RowHeadersWidth = 51;
            this.dataGridViewResultados.RowTemplate.Height = 24;
            this.dataGridViewResultados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewResultados.Size = new System.Drawing.Size(255, 450);
            this.dataGridViewResultados.TabIndex = 58;
            // 
            // Form_Simulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewNumerosCopiados);
            this.Controls.Add(this.dataGridViewContadorDuraciones);
            this.Controls.Add(this.dataGridViewResultados);
            this.Name = "Form_Simulacion";
            this.Text = "Form_Simulacion";
            this.Load += new System.EventHandler(this.Form_Simulacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNumerosCopiados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContadorDuraciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNumerosCopiados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pseudoaleatorios;
        private System.Windows.Forms.DataGridView dataGridViewContadorDuraciones;
        private System.Windows.Forms.DataGridView dataGridViewResultados;
    }
}