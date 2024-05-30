using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Numeros_Pseudo;
using Pruebas_Estadisticas;


namespace proyecto_inv
{
    public partial class Form_Generador_Num : Form
    {
        //Variables que vamos usar
        private int Constante_Multiplicativa = 0;
        private int Semilla = 0;
        private int Constante_Aditiva = 0;
        private int Modulo = 0;
        private int N = 0; //Numeros totales que queremos generar
        public List<float> numeros_aleatorios = new List<float>();



        public Form_Generador_Num()
        {
            InitializeComponent();
            configurar_datafrid();

        }
        private void configurar_datafrid()
        {
            // Configuración del DataGridView
            dt_Numeros_pseudo_lista.ColumnHeadersVisible = false;
            dt_Numeros_pseudo_lista.RowHeadersVisible = false;
            dt_Numeros_pseudo_lista.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dt_Numeros_pseudo_lista.DefaultCellStyle.SelectionForeColor = Color.Black;
            dt_Numeros_pseudo_lista.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dt_Numeros_pseudo_lista.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dt_Numeros_pseudo_lista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dt_Numeros_pseudo_lista.ReadOnly = true;
            dt_Numeros_pseudo_lista.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dt_Numeros_pseudo_lista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dt_Numeros_pseudo_lista.MultiSelect = false;
            dt_Numeros_pseudo_lista.GridColor = Color.White;

            // Añadir una columna para los elementos de la lista
            dt_Numeros_pseudo_lista.Columns.Add("FloatColumn", "FloatColumn");
        }

        private void btn_Generar_Click(object sender, EventArgs e)
        {
            dt_Numeros_pseudo_lista.Rows.Clear();

            //Capturmos los valores
            Constante_Multiplicativa = Convert.ToInt32(txtBox_Constante_Muntiplicativa.Text);
            Semilla = Convert.ToInt32(txtBox_Semilla.Text);
            Constante_Aditiva = Convert.ToInt32(txtBox_Constante_Aditiva.Text);
            Modulo = Convert.ToInt32(txtBox_Modulo.Text);
            N = Convert.ToInt32(txtBox_Numeros_Generados.Text);

            //llamamos la clase
            Num_Pseudo rnd = new Num_Pseudo(
                Constante_Multiplicativa,
                Semilla, Constante_Aditiva, Modulo, N
                );

            numeros_aleatorios = rnd.Generador();
            foreach (float value in numeros_aleatorios)
            {
                dt_Numeros_pseudo_lista.Rows.Add(value);


            }

            // Obtener la instancia del menú
            Menu menuForm = Application.OpenForms.OfType<Menu>().FirstOrDefault();
            if (menuForm != null)
            {
                // Agregar los números generados a la lista en el menú
                menuForm.GeneratedNumbersList = numeros_aleatorios;
            }


        }
    }
}
