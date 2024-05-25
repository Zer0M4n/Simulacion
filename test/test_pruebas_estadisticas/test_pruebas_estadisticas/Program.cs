using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Numeros_Pseudo;
using Pruebas_Estadisticas;

namespace test_pruebas_estadisticas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables que vamos usar
            int Constante_Multiplicativa = 5;
            int Semilla = 4;
            int Constante_Aditiva = 11;
            int Modulo = 100;
            int N = 5; //Numeros totales que queremos generar
            float x = 0;
            float z = 0;
            List<float> list = new List<float>();//numeros psudoaletorios
            List<float> lista_proemedio = new List<float>();
            
            Num_Pseudo rnd = new Num_Pseudo(
                Constante_Multiplicativa,
                Semilla, Constante_Aditiva, Modulo, N
                );
           
            Pruebas pruebas = new Pruebas();

            list = rnd.Generador();

            Console.WriteLine("Numeros pseudo aletorios");
            foreach (float f in list)
            {
                Console.WriteLine(f);
            }
            x = pruebas.Prueba_Promedio(list);
            lista_proemedio = pruebas.Lista_prueba(list);
            z = pruebas.Valor_Distribucion_Normal(list);


            Console.WriteLine("Valor de la prueba promedio es igual a {0}",x);
            foreach (float f in lista_proemedio)
            {
                Console.WriteLine(f);
            }
            Console.WriteLine("Valor en distribucion normal {0}", z);

            Console.ReadKey();

        }
    }
    
}
