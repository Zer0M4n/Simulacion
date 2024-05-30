using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pruebas_Estadisticas;



namespace proyecto_inv
{
    public partial class Form_Prueba_Promedio : Form
    {
        
       
        //Variables
        private List<float> numeros_aleatorios = new List<float>(); 
        private List<float> lista_Promedio = new List<float>();
        private bool OPC;
        private float Za;
        private float Z;


        public Form_Prueba_Promedio()
        {
            
            InitializeComponent();
            configurar_datafrid();
            label3.Text = "Z : Za";
            // Obtener la instancia del menú
            Menu menuForm = Application.OpenForms.OfType<Menu>().FirstOrDefault();
            if (menuForm != null)
            {
                // Acceder a la lista de números generados en el menú
                numeros_aleatorios = menuForm.GeneratedNumbersList;

            }
            else
            {
                // Manejar el caso en el que el menú no esté abierto
                MessageBox.Show("El menú no está disponible.");
            }

        }
        private void configurar_datafrid()
        {
            // Configuración del DataGridView
            dt_Lista_Promedio.ColumnHeadersVisible = true;
            dt_Lista_Promedio.RowHeadersVisible = false;
            dt_Lista_Promedio.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dt_Lista_Promedio.DefaultCellStyle.SelectionForeColor = Color.Black;
            dt_Lista_Promedio.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dt_Lista_Promedio.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dt_Lista_Promedio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dt_Lista_Promedio.ReadOnly = true;
            dt_Lista_Promedio.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dt_Lista_Promedio.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dt_Lista_Promedio.MultiSelect = false;
            dt_Lista_Promedio.GridColor = Color.White;
            
            
            
        }

        private void btn_Generador_Click(object sender, EventArgs e)
        {
            try
            {

                dt_Lista_Promedio.Rows.Clear();
                dt_Lista_Promedio.Columns.Clear();

                Za = (float)Convert.ToDecimal(txtBox_Xa.Text);

                Pruebas p = new Pruebas();
                lista_Promedio = p.Lista_prueba(numeros_aleatorios);

                // Agregar columnas al DataTable
                dt_Lista_Promedio.Columns.Add("RN", "Rn");
                dt_Lista_Promedio.Columns.Add("Sumatoria", "Sumatoria");

                // Llenar el DataTable con los datos de las listas
                for (int i = 0; i < Math.Max(numeros_aleatorios.Count, lista_Promedio.Count); i++)
                {
                    float valorRN = i < numeros_aleatorios.Count ? numeros_aleatorios[i] : 0;
                    float valorSumatoria = i < lista_Promedio.Count ? lista_Promedio[i] : 0;
                    dt_Lista_Promedio.Rows.Add(valorRN, valorSumatoria);
                }

                OPC = p.Comprobar_Distribucion(lista_Promedio, Za);
                Z = p.Valor_Distribucion_Normal(numeros_aleatorios);

                label2.Text = $" Za = {Za} , Z = {Z} ";

                if (OPC == true)
                {

                    lb_texto.Text = "Numeros Uniformente Distribuidos";
                    label3.Text = $"{Z} < {Za}";
                }
                else if (OPC == false)
                {

                    lb_texto.Text = "Numeros no Distribuidos  Uniformente ";
                    label3.Text = $"{Z} > {Za}";
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Surgio un error");
            }

           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
