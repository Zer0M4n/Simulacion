using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pruebas_Estadisticas;

namespace proyecto_inv
{
    public partial class Form_Prueba_Frecuencia : Form
    {
        //Variables
        private List<float> numeros_aleatorios = new List<float>();
        private int Intervalos;
        private float Alpha;
        private float Chi_Cuadrada;
        private float chi_Cuadrada_cal;
        private int[] Fo;//Frecuencia Observada
        private float Fe;//Frecuencia esperada
        private List<(float, float)> Lista_Intervalos = new List<(float, float)>();
        private List<int> n = new List<int>();
        private bool OPC;

        public Form_Prueba_Frecuencia()
        {
            InitializeComponent();
            configurar_datafrid();
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
            dt_Frecuencias.ColumnHeadersVisible = true;
            dt_Frecuencias.RowHeadersVisible = false;
            dt_Frecuencias.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dt_Frecuencias.DefaultCellStyle.SelectionForeColor = Color.Black;
            dt_Frecuencias.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dt_Frecuencias.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dt_Frecuencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dt_Frecuencias.ReadOnly = true;
            dt_Frecuencias.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dt_Frecuencias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dt_Frecuencias.MultiSelect = false;
            dt_Frecuencias.GridColor = Color.White;

            // Configuración del DataGridView
            dt_Intervalos.ColumnHeadersVisible = true;
            dt_Intervalos.RowHeadersVisible = false;
            dt_Intervalos.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dt_Intervalos.DefaultCellStyle.SelectionForeColor = Color.Black;
            dt_Intervalos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dt_Intervalos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dt_Intervalos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dt_Intervalos.ReadOnly = true;
            dt_Intervalos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dt_Intervalos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dt_Intervalos.MultiSelect = false;
            dt_Intervalos.GridColor = Color.White;


        }


        private void btn_Generar_Click(object sender, EventArgs e)
        {
            try
            {

                // Convertir y asignar valores
                float Alpha = (float)Convert.ToDecimal(txtBox_Alpha.Text);
                int Intervalos = Convert.ToInt32(txtBox_N_Intervalos.Text);

                // Crear la instancia de Frecuencia_Prueba
                Frecuencia_Prueba pf = new Frecuencia_Prueba(numeros_aleatorios, Intervalos, Alpha);

                // Obtener los resultados del análisis

               
                Fo = pf.GetFrecuencia_Obsevada();
                Fe = pf.GetFreccuencia_Esperada();

                n = Fo.ToList();

                // Configurar las columnas del DataGridView
                dt_Frecuencias.Columns.Clear();
                dt_Frecuencias.Columns.Add("Rn", "Rn");
                dt_Frecuencias.Columns.Add("Frecuencia Observada", "Frecuencia Observada");

                // Llenar el DataGridView con los números aleatorios y las frecuencias observadas
                dt_Frecuencias.Rows.Clear();

                // Calcular la longitud máxima entre las listas
                int maxCount = Math.Max(numeros_aleatorios.Count, n.Count);

                for (int i = 0; i < maxCount; i++)
                {
                    // Obtener valores o usar valores por defecto si la lista es más corta
                    string numeroAleatorio = i < numeros_aleatorios.Count ? numeros_aleatorios[i].ToString() : "N/A";
                    string frecuenciaObservada = i < n.Count ? Fo[i].ToString() : "N/A";

                    dt_Frecuencias.Rows.Add(numeroAleatorio, frecuenciaObservada);
                }

                // Configurar las columnas del DataGridView dt_Intervalos
                dt_Intervalos.Columns.Clear();
                dt_Intervalos.Columns.Add("Límite Inferior", "Límite Inferior");
                dt_Intervalos.Columns.Add("Límite Superior", "Límite Superior");

                // Limpiar las filas existentes en dt_Intervalos
                dt_Intervalos.Rows.Clear();


                Lista_Intervalos = pf.GetIntervalos();



                foreach ((float L_inferior, float L_superior) in Lista_Intervalos)
                {
                    dt_Intervalos.Rows.Add(L_inferior, L_superior);
                }
                Chi_Cuadrada = (float)pf.GetChi_Cuadrada();
                chi_Cuadrada_cal = (float)pf.GetChi_Cuadrada_Cal();

                OPC = pf.Approved();

                if(OPC)
                {
                    label4.Text = $"Chi_C = {Chi_Cuadrada} , Chi_Cal = {chi_Cuadrada_cal}";
                    label5.Text = "Estan distribuidos uniformente";

                    label3.Text = $"{chi_Cuadrada_cal} < {Chi_Cuadrada} ";
                }
                if(OPC == false)
                {
                    label4.Text = $"Chi_C = {Chi_Cuadrada} , Chi_Cal = {chi_Cuadrada_cal}";

                    label5.Text = "No estan distribuidos uniformente";

                    label3.Text = $"{chi_Cuadrada_cal} > {Chi_Cuadrada} ";
                }


            }
            catch (Exception)  
            {
                MessageBox.Show("Surgio un error");
            }
        }
    }
}
