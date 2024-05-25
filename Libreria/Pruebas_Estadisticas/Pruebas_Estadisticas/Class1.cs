using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_Estadisticas
{
    public class Prubas_Etsdisticas
    {
        public int N = 0;//Numero de elementos ne ua lista
        public float X = 0;//Resultado de la prueba de promedios
        public float Suma_Numeros = 0;
        public List<float> Lista_Promedio = new List<float>();//Guardar los resultados de la sumatoria
        public float auxiliar = 0;//Nos ayudara para suma
        
        
        public float Prueba_Promedio(List<float> Numeros_Aleatorios)
        {
            N = Numeros_Aleatorios.Count;
            Suma_Numeros = Numeros_Aleatorios.Sum();
            X =  Suma_Numeros / N;
            
            return X;
        }
        public List<float> Lista_prueba(List<float> Numeros_Aleatorios)
        {
            N = Numeros_Aleatorios.Count;

            for (int i = 0; i < N; i++)
            {
                if(i == 0) auxiliar = 0;
                
                Suma_Numeros = auxiliar + Numeros_Aleatorios[i];
                X = Suma_Numeros / N;
                Lista_Promedio.Add(X);
                auxiliar = Suma_Numeros;


            }
            return Lista_Promedio;
        }



    }

}
