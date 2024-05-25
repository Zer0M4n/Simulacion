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


            Num_Pseudo rnd = new Num_Pseudo(
                Constante_Multiplicativa,
                Semilla, Constante_Aditiva, Modulo, N
                );
            
            List<float> list = new List<float>();
            list = rnd.Generador();

            Console.WriteLine("Numeros pseudo aletorios");
            foreach (float f in list)
            {
                Console.WriteLine(f);
            }
            Console.ReadKey();
        }
    }
    
}
