
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyecto_inv;


namespace proyecto_inv
{
    public partial class Menu : Form
    {

        //Varibles para controlar los menus
        bool menuExpand = false;
        bool sidebarExpand = true;

        //Forma para generar formas hijas
        private Form activeForm = null;
        public List<float> GeneratedNumbersList { get; set; }



        //Movimiento del la barra
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        Form_Generador_Num n = new Form_Generador_Num();

        public Menu()
        {
            InitializeComponent();
            GeneratedNumbersList = new List<float>(); // Inicializa la lista en el constructor

        }

        private void openChildFormInPanel(Form childForm)//Funcion que genera las formas en el panel
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);

        }

        private void sidebordTransition_Tick(object sender, EventArgs e)
        {

            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 57)
                {
                    sidebarExpand = false;
                    sidebordTransition.Stop();

                }

            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 197)
                {
                    sidebarExpand = true;
                    sidebordTransition.Stop();

                }
            }

        }

        private void menuTrantion_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;

                if (menuContainer.Height >= 174)
                {
                    menuTrantion.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 47)
                {
                    menuTrantion.Stop();
                    menuExpand = false;
                }

            }
        }

        private void Tablas_Menu_Click(object sender, EventArgs e)
        {
            menuTrantion.Start();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebordTransition.Start();

        }

        
        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void Ocultar_Ventana_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Cerrar_Ventana_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_salida_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Numeros_Pseudoaletorios_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Form_Generador_Num() );
        }

        private void btn_Prueba_Promedio_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Form_Prueba_Promedio());

        }

        private void btn_Prueba_Frecuencias_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Form_Prueba_Frecuencia());
        }

        private void btn_Simulacion_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Form_Simulacion());
        }
    }
}
