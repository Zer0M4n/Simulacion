namespace proyecto_inv
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Ocultar_Ventana = new System.Windows.Forms.PictureBox();
            this.Cerrar_Ventana = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.Reiniciar = new System.Windows.Forms.Panel();
            this.btn_Numeros_Pseudoaletorios = new System.Windows.Forms.Button();
            this.menuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Tablas_Menu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Prueba_Promedio = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_Prueba_Frecuencias = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_salida = new System.Windows.Forms.Button();
            this.menuTrantion = new System.Windows.Forms.Timer(this.components);
            this.sidebordTransition = new System.Windows.Forms.Timer(this.components);
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ocultar_Ventana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar_Ventana)).BeginInit();
            this.sidebar.SuspendLayout();
            this.Reiniciar.SuspendLayout();
            this.menuContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Minimizar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Ocultar_Ventana);
            this.panel1.Controls.Add(this.Cerrar_Ventana);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 49);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proyecto Individual";
            // 
            // Minimizar
            // 
            this.Minimizar.BackColor = System.Drawing.Color.Transparent;
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Default;
            this.Minimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Minimizar.Image = global::proyecto_inv.Properties.Resources.icons8_macos_minimizar_24;
            this.Minimizar.Location = new System.Drawing.Point(825, 0);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(48, 49);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 4;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::proyecto_inv.Properties.Resources.icons8_promo_100;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Ocultar_Ventana
            // 
            this.Ocultar_Ventana.BackColor = System.Drawing.Color.Transparent;
            this.Ocultar_Ventana.Cursor = System.Windows.Forms.Cursors.Default;
            this.Ocultar_Ventana.Dock = System.Windows.Forms.DockStyle.Right;
            this.Ocultar_Ventana.Image = global::proyecto_inv.Properties.Resources.icons8_restaurar_ventana_24;
            this.Ocultar_Ventana.Location = new System.Drawing.Point(873, 0);
            this.Ocultar_Ventana.Name = "Ocultar_Ventana";
            this.Ocultar_Ventana.Size = new System.Drawing.Size(48, 49);
            this.Ocultar_Ventana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ocultar_Ventana.TabIndex = 3;
            this.Ocultar_Ventana.TabStop = false;
            this.Ocultar_Ventana.Click += new System.EventHandler(this.Ocultar_Ventana_Click);
            // 
            // Cerrar_Ventana
            // 
            this.Cerrar_Ventana.BackColor = System.Drawing.Color.Transparent;
            this.Cerrar_Ventana.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cerrar_Ventana.Dock = System.Windows.Forms.DockStyle.Right;
            this.Cerrar_Ventana.Image = global::proyecto_inv.Properties.Resources.icons8_cerrar_ventana_24;
            this.Cerrar_Ventana.Location = new System.Drawing.Point(921, 0);
            this.Cerrar_Ventana.Name = "Cerrar_Ventana";
            this.Cerrar_Ventana.Size = new System.Drawing.Size(48, 49);
            this.Cerrar_Ventana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cerrar_Ventana.TabIndex = 2;
            this.Cerrar_Ventana.TabStop = false;
            this.Cerrar_Ventana.Click += new System.EventHandler(this.Cerrar_Ventana_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sidebar.Controls.Add(this.Reiniciar);
            this.sidebar.Controls.Add(this.menuContainer);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 49);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(197, 568);
            this.sidebar.TabIndex = 1;
            // 
            // Reiniciar
            // 
            this.Reiniciar.Controls.Add(this.btn_Numeros_Pseudoaletorios);
            this.Reiniciar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Reiniciar.Location = new System.Drawing.Point(3, 3);
            this.Reiniciar.Name = "Reiniciar";
            this.Reiniciar.Size = new System.Drawing.Size(197, 47);
            this.Reiniciar.TabIndex = 7;
            // 
            // btn_Numeros_Pseudoaletorios
            // 
            this.btn_Numeros_Pseudoaletorios.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Numeros_Pseudoaletorios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Numeros_Pseudoaletorios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Numeros_Pseudoaletorios.Location = new System.Drawing.Point(-13, -20);
            this.btn_Numeros_Pseudoaletorios.Name = "btn_Numeros_Pseudoaletorios";
            this.btn_Numeros_Pseudoaletorios.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_Numeros_Pseudoaletorios.Size = new System.Drawing.Size(227, 91);
            this.btn_Numeros_Pseudoaletorios.TabIndex = 3;
            this.btn_Numeros_Pseudoaletorios.Text = "Generador Numeros Pseudoaletorios";
            this.btn_Numeros_Pseudoaletorios.UseVisualStyleBackColor = false;
            this.btn_Numeros_Pseudoaletorios.Click += new System.EventHandler(this.btn_Numeros_Pseudoaletorios_Click);
            // 
            // menuContainer
            // 
            this.menuContainer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuContainer.Controls.Add(this.panel2);
            this.menuContainer.Controls.Add(this.panel3);
            this.menuContainer.Controls.Add(this.panel5);
            this.menuContainer.Location = new System.Drawing.Point(3, 56);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(204, 61);
            this.menuContainer.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Tablas_Menu);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 47);
            this.panel2.TabIndex = 3;
            // 
            // Tablas_Menu
            // 
            this.Tablas_Menu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Tablas_Menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tablas_Menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tablas_Menu.Location = new System.Drawing.Point(-16, -16);
            this.Tablas_Menu.Name = "Tablas_Menu";
            this.Tablas_Menu.Size = new System.Drawing.Size(227, 91);
            this.Tablas_Menu.TabIndex = 3;
            this.Tablas_Menu.Text = "Pruebas";
            this.Tablas_Menu.UseVisualStyleBackColor = false;
            this.Tablas_Menu.Click += new System.EventHandler(this.Tablas_Menu_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Prueba_Promedio);
            this.panel3.Location = new System.Drawing.Point(3, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 47);
            this.panel3.TabIndex = 4;
            // 
            // btn_Prueba_Promedio
            // 
            this.btn_Prueba_Promedio.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Prueba_Promedio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Prueba_Promedio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Prueba_Promedio.Location = new System.Drawing.Point(-16, -25);
            this.btn_Prueba_Promedio.Name = "btn_Prueba_Promedio";
            this.btn_Prueba_Promedio.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_Prueba_Promedio.Size = new System.Drawing.Size(227, 91);
            this.btn_Prueba_Promedio.TabIndex = 3;
            this.btn_Prueba_Promedio.Text = "Prueba de Promedio";
            this.btn_Prueba_Promedio.UseVisualStyleBackColor = false;
            this.btn_Prueba_Promedio.Click += new System.EventHandler(this.btn_Prueba_Promedio_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_Prueba_Frecuencias);
            this.panel5.Location = new System.Drawing.Point(3, 109);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(197, 47);
            this.panel5.TabIndex = 6;
            // 
            // btn_Prueba_Frecuencias
            // 
            this.btn_Prueba_Frecuencias.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Prueba_Frecuencias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Prueba_Frecuencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Prueba_Frecuencias.Location = new System.Drawing.Point(-16, -25);
            this.btn_Prueba_Frecuencias.Name = "btn_Prueba_Frecuencias";
            this.btn_Prueba_Frecuencias.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_Prueba_Frecuencias.Size = new System.Drawing.Size(227, 91);
            this.btn_Prueba_Frecuencias.TabIndex = 3;
            this.btn_Prueba_Frecuencias.Text = "Prueba de Frecuencias";
            this.btn_Prueba_Frecuencias.UseVisualStyleBackColor = false;
            this.btn_Prueba_Frecuencias.Click += new System.EventHandler(this.btn_Prueba_Frecuencias_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_salida);
            this.panel6.Location = new System.Drawing.Point(3, 123);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(197, 47);
            this.panel6.TabIndex = 6;
            // 
            // btn_salida
            // 
            this.btn_salida.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_salida.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_salida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salida.Location = new System.Drawing.Point(-16, -25);
            this.btn_salida.Name = "btn_salida";
            this.btn_salida.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_salida.Size = new System.Drawing.Size(227, 91);
            this.btn_salida.TabIndex = 3;
            this.btn_salida.Text = "Salida";
            this.btn_salida.UseVisualStyleBackColor = false;
            this.btn_salida.Click += new System.EventHandler(this.btn_salida_Click);
            // 
            // menuTrantion
            // 
            this.menuTrantion.Interval = 10;
            this.menuTrantion.Tick += new System.EventHandler(this.menuTrantion_Tick);
            // 
            // sidebordTransition
            // 
            this.sidebordTransition.Interval = 10;
            this.sidebordTransition.Tick += new System.EventHandler(this.sidebordTransition_Tick);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(197, 49);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(772, 568);
            this.panelChildForm.TabIndex = 2;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 617);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ocultar_Ventana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar_Ventana)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.Reiniciar.ResumeLayout(false);
            this.menuContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Cerrar_Ventana;
        private System.Windows.Forms.PictureBox Ocultar_Ventana;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.FlowLayoutPanel menuContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Tablas_Menu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Prueba_Promedio;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_Prueba_Frecuencias;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_salida;
        private System.Windows.Forms.Panel Reiniciar;
        private System.Windows.Forms.Button btn_Numeros_Pseudoaletorios;
        private System.Windows.Forms.Timer menuTrantion;
        private System.Windows.Forms.Timer sidebordTransition;
        private System.Windows.Forms.Panel panelChildForm;
    }
}

