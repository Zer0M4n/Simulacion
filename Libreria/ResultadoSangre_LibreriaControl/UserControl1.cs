using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Numeros_Pseudo;

namespace ResultadoSangre_LibreriaControl
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            TablaData.Columns.Add("Index", "Animal");
            TablaData.Columns.Add("Number", "Número Pseudoaleatorio");
            TablaData.Columns.Add("Result", "Resultado");

            TablaData2.Columns.Add("Index1", "Muestra");
            TablaData2.Columns.Add("Number1", "Número Pseudoaleatorio");
            TablaData2.Columns.Add("Result1", "Resultado");
        }

        private void Calcular_Click(object sender, EventArgs e)
        {

            //Animales
            //-------------------------------------------------------
            int Constante_Multiplicativa = 10;
            int semilla = 8;
            int Constante_Aditiva = 100;
            int Modulo = 9;
            int N = 16;
            Num_Pseudo rnd = new Num_Pseudo(Constante_Multiplicativa,semilla,Constante_Aditiva,Modulo,N);
            //En la variable "maximo" van a ir la cantidad de numeros pseudoaleatorios que se genraron 
            int maximo = 16;
            //        List<decimal> decimalList = floatList.Select(f => (decimal)f).ToList();

            List<double> list_Num = new List<double>();
            list_Num = rnd.Generador().Select(i => (double)i).ToList();
            //Esta variable cambiala por el arreglo de numeros pseudo aleatorios
            //double[] array = { 0.114, 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 0.167, 0.167, 0.167, 0.167, 0.167, 0.167,0.157 };

            //------------------------------------
            int contador1 = 0;
            int contador2 = 0;
            int contador3 = 0;
            int contador4 = 0;
            int contador5 = 0;


            TablaData.Rows.Clear();
            TablaData.Columns.Clear();
            TablaData.Columns.Add("Index", "Animal");
            TablaData.Columns.Add("Number", "Número Pseudoaleatorio");
            TablaData.Columns.Add("Result", "Resultado");

            for (int a=0;a<maximo;a++)
            {
                if (list_Num[a] > 0.00 && list_Num[a] < 0.18)
                {
                    contador1++;
                    TablaData.Rows.Add((a + 1), list_Num[a], "Alto grado de acidez");
                }
                if (list_Num[a] > 0.18 && list_Num[a] < 0.26)
                {
                    contador2++;
                    TablaData.Rows.Add((a + 1), list_Num[a], "Estado de anemia aguda");
                }
                if (list_Num[a] > 0.26 && list_Num[a] < 0.61)
                {
                    contador3++;
                    TablaData.Rows.Add((a + 1), list_Num[a], "Estado en rango normal");
                }
                if (list_Num[a] > 0.61 && list_Num[a] < 0.78)
                {
                    contador4++;
                    TablaData.Rows.Add((a + 1), list_Num[a], "Exceso de glucosa");
                }
                if (list_Num[a] > 0.78 && list_Num[a] < 1.00)
                {
                    contador5++;
                    TablaData.Rows.Add((a + 1), list_Num[a], "Alto grado de alcalinidad");
                }
            }

            int mayor = contador1;
            string variableMayor = "Resultado: Se encontro un Alto grado de acidez";

            if (contador2 > mayor)
            {                
                mayor = contador2;
                variableMayor = "Resultado: Se encontro un Estado de anemia aguda";
            }

            if (contador3 > mayor)
            {
                mayor = contador3;
                variableMayor = "Resultado: Se encontro un Estado en rango normal";
            }

            if (contador4 > mayor)
            {
                mayor = contador4;
                variableMayor = "Resultado: Se encontro un Exceso de glucosa";
            }

            if (contador5 > mayor)
            {
                mayor = contador5;
                variableMayor = "Resultado: Se encontro un Alto grado de alcanidad";
            }

            label2.Text = variableMayor;


            // Muestras
            //-------------------------------------------------

            int cont1 = 0;
            int cont2 = 0;
            int cont3 = 0;
            int cont4 = 0;
            int cont5 = 0;
            int cont6 = 0;
            int cont7 = 0;

            TablaData2.Rows.Clear();
            TablaData2.Columns.Clear();

            TablaData2.Columns.Add("Index1", "Muestra");
            TablaData2.Columns.Add("Number1", "Número Pseudoaleatorio");
            TablaData2.Columns.Add("Result1", "Resultado");

            for (int a = 0; a < maximo; a++)
            {
                if (list_Num[a] > 0.00 && list_Num[a] < 0.05)
                {
                    cont1++;
                    TablaData2.Rows.Add((a + 1), list_Num[a], "Sustancias coloidales");
                }
                if (list_Num[a] > 0.05 && list_Num[a] < 0.15)
                {
                    cont2++;
                    TablaData2.Rows.Add((a + 1), list_Num[a], "Exceso de mercurio");
                }
                if (list_Num[a] > 0.15 && list_Num[a] < 0.40)
                {
                    cont3++;
                    TablaData2.Rows.Add((a + 1), list_Num[a], "Residuos petroquimicos");
                }
                if (list_Num[a] > 0.40 && list_Num[a] < 0.55)
                {
                    cont4++;
                    TablaData2.Rows.Add((a + 1), list_Num[a], "Sulfatos");
                }
                if (list_Num[a] > 0.55 && list_Num[a] < 0.67)
                {
                    cont5++;
                    TablaData2.Rows.Add((a + 1), list_Num[a], "Acido clorhidrico");
                }
                if (list_Num[a] > 0.67 && list_Num[a] < 0.83)
                {
                    cont6++;
                    TablaData2.Rows.Add((a + 1), list_Num[a], "Fosfatos");
                }
                if (list_Num[a] > 0.83 && list_Num[a] < 1.00)
                {
                    cont7++;
                    TablaData2.Rows.Add((a + 1), list_Num[a], "Oxidos");
                }
            }

            int mayor2 = cont1;
            string variableMayor2 = "Resultado: Se encontro bastantes Sustancias coloidales";

           
            if (cont2 > mayor2)
            {
                mayor2 = cont2;
                variableMayor2 = "Resultado: Se encontro bastantes Exceso de mercurio";
            }

            if (cont3 > mayor2)
            {
                mayor2 = cont3;
                variableMayor2 = "Resultado: Se encontro bastantes Residuos petroquimicos";
            }

            if (cont4 > mayor2)
            {
                mayor2 = cont4;
                variableMayor2 = "Resultado: Se encontro bastante Sulfatos";
            }

            if (cont5 > mayor2)
            {
                mayor2 = cont5;
                variableMayor2 = "Resultado: Se encontro bastante Acido clorhidrico";
            }

            if (cont6 > mayor2)
            {
                mayor2 = cont6;
                variableMayor2 = "Resultado: Se encontro bastantes Fosfatos";
            }

            if (cont7 > mayor2)
            {
                mayor2 = cont7;
                variableMayor2 = "Resultado: Se encontro bastantes Oxidos";
            }

            label3.Text = variableMayor2;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
