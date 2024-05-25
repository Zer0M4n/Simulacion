using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_Estadisticas
{

    public class Pruebas
    {
        private int N = 0;//Numero de elementos ne ua lista
        private float X = 0;//Resultado de la prueba de promedios
        private float Suma_Numeros = 0;
        private List<float> Lista_Promedio = new List<float>();//Guardar los resultados de la sumatoria
        private float auxiliar = 0;//Nos ayudara para suma
        private float Z = 0;

        public float Prueba_Promedio(List<float> Numeros_Aleatorios)//funcion para calcular el promedio
        {
            N = Numeros_Aleatorios.Count;
            Suma_Numeros = Numeros_Aleatorios.Sum();
            X =  Suma_Numeros / N;
            
            return X;
        }
        public List<float> Lista_prueba(List<float> Numeros_Aleatorios)//lista del proceso de pruba de promedio
        {
            N = Numeros_Aleatorios.Count;

            for (int i = 0; i < N; i++)
            {
                Suma_Numeros = auxiliar + Numeros_Aleatorios[i];
                X = Suma_Numeros / N;
                Lista_Promedio.Add(X);
                auxiliar = Suma_Numeros;


            }
            return Lista_Promedio;
        }
        public float Valor_Distribucion_Normal(List<float> Numero_Aleatorios)
        {
            N = Numero_Aleatorios.Count;
            float T = Prueba_Promedio(Numero_Aleatorios);
            
            float E = (float)Math.Sqrt((1/12.0));
            float N_Raiz = (float)Math.Sqrt(N);
            float z = (float) (( (0.49 - 0.5) * (N_Raiz)) / (E));
            
            Z = Math.Abs(z);

            return Z;
            

        }
        
    }

}
