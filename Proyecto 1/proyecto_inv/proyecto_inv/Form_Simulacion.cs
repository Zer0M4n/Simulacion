using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_inv
{
    public partial class Form_Simulacion : Form
    {
        //Variables a usar
        //        List<decimal> decimalList = floatList.Select(f => (decimal)f).ToList();


        private List<float> numerosGenerados;
        List<double> numeros_aleatorios;
        private const int PrecioNormal = 150;
        private const double Incremento30 = 1.30;
        private const double Incremento70 = 1.70;
        private const double Decremento10 = 0.90;

        private static readonly Dictionary<double, int> DuracionClimaFrio = new Dictionary<double, int>
        {
            { 0.15, 3 },
            { 0.23, 5 },
            { 0.35, 8 },
            { 0.55, 10 },
            { 0.80, 14 },
            { 1.00, 16 }
        };

        private Dictionary<int, int> contadorDuraciones = new Dictionary<int, int>();
        

        public Form_Simulacion()
        {
            
            // Obtener la instancia del menú
            Menu menuForm = Application.OpenForms.OfType<Menu>().FirstOrDefault();
            if (menuForm != null)
            {
                // Acceder a la lista de números generados en el menú
                numerosGenerados = menuForm.GeneratedNumbersList;
                
                numeros_aleatorios = numerosGenerados.Select(f => (double)f).ToList();
            }
            else
            {
                // Manejar el caso en el que el menú no esté abierto
                MessageBox.Show("El menú no está disponible.");
            }

            InitializeComponent();
        }

        private void Form_Simulacion_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"Nota: al hacer click sobre un numero, este y los proximos 49 se seleccionaran", "Informacion");
            CargarDatos();
            dataGridViewResultados.CellClick += dataGridViewResultados_CellClick; // Suscribir al evento CellClick
        }

        private void CargarDatos()
        {
            dataGridViewResultados.Rows.Clear();
            dataGridViewResultados.Columns.Clear();

            dataGridViewResultados.Columns.Add("Indice", "#");
            dataGridViewResultados.Columns.Add("Numero", "Número Pseudoaleatorios");

            foreach (var numero in numeros_aleatorios.Select((value, index) => new { index, value }))
            {
                dataGridViewResultados.Rows.Add(numero.index + 1, numero.value.ToString("F5"));
            }

            dataGridViewResultados.ReadOnly = true;
            dataGridViewResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewResultados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewResultados.ScrollBars = ScrollBars.Vertical;
        }

        private void dataGridViewResultados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int startingIndex = e.RowIndex;
                int totalNumbers = numeros_aleatorios.Count;

                if (totalNumbers - startingIndex >= 50)
                {
                    List<double> selectedNumbers = numeros_aleatorios.GetRange(startingIndex, 50);
                    Dictionary<int, int> contadorDuracionesCopiadas = new Dictionary<int, int>();

                    dataGridViewNumerosCopiados.Rows.Clear();
                    dataGridViewNumerosCopiados.Columns.Clear();

                    dataGridViewNumerosCopiados.Columns.Add("Indice", "#");
                    dataGridViewNumerosCopiados.Columns.Add("Numero", "Número Pseudoaleatorio");
                    dataGridViewNumerosCopiados.Columns.Add("Duracion", "Dias de clima frio");

                    foreach (var numero in selectedNumbers.Select((value, index) => new { index, value }))
                    {
                        int duracion = ObtenerDuracionClimaFrio(numero.value);
                        dataGridViewNumerosCopiados.Rows.Add(numero.index + 1, numero.value.ToString("F5"), duracion);

                        if (contadorDuracionesCopiadas.ContainsKey(duracion))
                        {
                            contadorDuracionesCopiadas[duracion]++;
                        }
                        else
                        {
                            contadorDuracionesCopiadas[duracion] = 1;
                        }
                    }

                    dataGridViewNumerosCopiados.ReadOnly = true;
                    dataGridViewNumerosCopiados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridViewNumerosCopiados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dataGridViewNumerosCopiados.ScrollBars = ScrollBars.Vertical;

                    MostrarContadorDuracionesCopiadas(contadorDuracionesCopiadas);
                    SimularClima(selectedNumbers);
                }
                else
                {
                    MessageBox.Show("Genera al menos 50 números pseudoaleatorios.", "Error");
                }
            }
        }

        private void MostrarContadorDuracionesCopiadas(Dictionary<int, int> contadorDuraciones)
        {
            dataGridViewContadorDuraciones.Rows.Clear();
            dataGridViewContadorDuraciones.Columns.Clear();

            dataGridViewContadorDuraciones.Columns.Add("Duracion", "Duración (días)");
            dataGridViewContadorDuraciones.Columns.Add("Cantidad", "Cantidad");

            foreach (var duracion in contadorDuraciones.OrderBy(d => d.Key))
            {
                dataGridViewContadorDuraciones.Rows.Add(duracion.Key, duracion.Value);
            }

            dataGridViewContadorDuraciones.ReadOnly = true;
            dataGridViewContadorDuraciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewContadorDuraciones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewContadorDuraciones.ScrollBars = ScrollBars.Vertical;
        }

        private void SimularClima(List<double> numeros)
        {
            List<int> duraciones = new List<int>();

            foreach (double numero in numeros)
            {
                duraciones.Add(ObtenerDuracionClimaFrio(numero));
            }

            int contadorMenorDosSemanas = duraciones.Count(d => d < 14);

            if (contadorMenorDosSemanas >= 23)
            {
                ImplementarPolitica1();
            }
            else
            {
                ImplementarPolitica2(numeros[49]);
            }
        }

        private int ObtenerDuracionClimaFrio(double numero)
        {
            foreach (var item in DuracionClimaFrio)
            {
                if (numero <= item.Key)
                {
                    return item.Value;
                }
            }
            return 16; // Default, should not reach here
        }

        private void ImplementarPolitica1()
        {
            double precioVenta = PrecioNormal * Incremento30;
            MessageBox.Show($"Implementar Política 1: Vender toda la mercancía ahora con una ganancia del 30%. Precio de venta: ${precioVenta} x caja", "Decisión de Venta");
        }

        private void ImplementarPolitica2(double numeroActual)
        {
            int duracionActual = ObtenerDuracionClimaFrio(numeroActual);

            if (duracionActual == 14 || duracionActual == 16)
            {
                double precioVenta = PrecioNormal * Incremento70;
                MessageBox.Show($"Implementar Política 2: Clima frío de {duracionActual} días, ganancia del 70%. Precio de venta: ${precioVenta} x caja", "Decisión de Venta");
            }
            else
            {
                double precioVenta = PrecioNormal * Decremento10;
                MessageBox.Show($"Implementar Política 2: Clima frío de {duracionActual} días, pérdida del 10%. Precio de venta: ${precioVenta} x caja", "Decisión de Venta");
            }
        }

    }
}
