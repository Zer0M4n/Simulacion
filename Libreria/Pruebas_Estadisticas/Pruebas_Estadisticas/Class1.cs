using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Distributions;


namespace Pruebas_Estadisticas
{

    public class Pruebas 
    {
        private int N = 0;//Numero de elementos ne ua lista

        //Variables Para  prueba de promedio
        private float X = 0;//Resultado de la prueba de promedios
        private float Suma_Numeros = 0;
        private List<float> Lista_Promedio = new List<float>();//Guardar los resultados de la sumatoria
        private float auxiliar = 0;//Nos ayudara para suma
        private float Z = 0;

        //Variables ´para la prueba de frecuencias
        private float FE = 0;//FRECUENCIA ESPERADDA
        public int[] ContadorFrecuenciaObservada = new int[4];
        private double X0 = 0;
        private const float Xa = 7.81f;
        private List<float> Lista_frecuencia = new List<float>();
        bool verificar;


        public bool Lista_Frecuencias(List<float> Numeros_Aleatorios, float Xa)//Comprueba si esta unidormente ordenadas
        {
            FE = Numeros_Aleatorios.Count / 4;
            foreach (float Number in Numeros_Aleatorios)
            {
                if (Number >= 0f && Number < 0.25f) ContadorFrecuenciaObservada[0]++;
                else if (Number >= 0.25f && Number < 0.50f) ContadorFrecuenciaObservada[1]++;
                else if (Number >= 0.50f && Number < 0.75f) ContadorFrecuenciaObservada[2]++;
                else if (Number >= 0.75f && Number <= 1f) ContadorFrecuenciaObservada[3]++;
            }
            for (int i = 0; i < ContadorFrecuenciaObservada.Length; i++)
            {
                X0 += Math.Pow(ContadorFrecuenciaObservada[i] - FE, 2) / FE;
                
            }
            return X0 < Xa ? true : false;

        }
        
       

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
        public bool Comprobar_Distribucion(List<float> Numeros_Aleatorios, float Za)//Verifica si la distribucion esta uniformente distribuida
        {
            Z = Valor_Distribucion_Normal(Numeros_Aleatorios);
            if (Z < Za) {
                verificar = true;
            
            }
            if(Z > Za)
            {
                verificar = false;
            }

            return verificar;
        }

    }


    public class Frecuencia_Prueba
    {
        public List<float> numeros_aleatorios = null;
        public int Intervalos = 0; // Number of Intervalos
        public float Alpha = 0; // Level of significance
        private List<(float, float)> Lista_Intervalos_Prob;//Lista de intervalos de la probabilidades
        private int[] Frecuencia_Obsevada;
        private float Freccuencia_Esperada;
        private double Chi_Cuadrada_Cal;
        private double Chi_Cuadrada;

        //Constructor
        public Frecuencia_Prueba(List<float> numeros_aleatorios, int Intervalos, float alpha) //Constructor
        {
            this.numeros_aleatorios = numeros_aleatorios;
            this.Intervalos = Intervalos;
            this.Alpha = alpha;
        }

        private void DefineIntervalos()
        {
            if (Lista_Intervalos_Prob != null) Lista_Intervalos_Prob.Clear();
            this.Lista_Intervalos_Prob = new List<(float, float)>(Intervalos); //List for save the probability of each interval
            float topLimit = 0f, bottomLimit;
            //Find the probability of each interval
            float prob = (float)1 / this.Intervalos;
            //Define the limits of each interval
            for (int i = 0; i < Intervalos; i++)
            {
                bottomLimit = topLimit;
                topLimit += prob;
                Lista_Intervalos_Prob.Add((bottomLimit, topLimit));
            }
        }
        public List<(float, float)> GetIntervalos()
        {
            DefineIntervalos();
            return this.Lista_Intervalos_Prob;
        }
        private void DefineChi_Cuadrada()
        {
            Chi_Cuadrada = ChiSquared.InvCDF((double)Intervalos - 1, (double)Alpha); //Use MathNet.Numerics Library
        }
        public double GetChi_Cuadrada()
        {
            DefineChi_Cuadrada();
            return Chi_Cuadrada;
        }
        private void DefineFrecuencia_Obsevada()
        {
            DefineIntervalos(); // Checking if the probabilities of each interval are defined

            int c; //Counter for the interval
            Frecuencia_Obsevada = new int[Intervalos];
            foreach (float Number in numeros_aleatorios) //Getting each pseudorandom number
            {
                c = 0; //Starting counter
                foreach ((float bottomLimit, float TopLimit) in Lista_Intervalos_Prob) //Getting each limit of each interval
                {

                    if (bottomLimit < Number && Number <= TopLimit) //Checking if number is between both limits
                    {
                        Frecuencia_Obsevada[c]++; //Counter
                        break;
                    }
                    c++; //Counter
                }
            }
        }
        public int[] GetFrecuencia_Obsevada()
        {
            DefineFrecuencia_Obsevada();
            return Frecuencia_Obsevada;
        }
        private void DefineFreccuencia_Esperada()
        {
            Freccuencia_Esperada = (float)numeros_aleatorios.Count / Intervalos; //The expected frequency is the division between the total numbers and the total Intervalos
        }
        public float GetFreccuencia_Esperada()
        {
            DefineFreccuencia_Esperada();
            return Freccuencia_Esperada;
        }
        private void DefineChi_Cuadrada_Cal()
        {
            // Checking if the values are defined yet
            DefineFrecuencia_Obsevada();
            DefineFreccuencia_Esperada();

            for (int i = 0; i < Intervalos; i++)
            {   //Sum
                Chi_Cuadrada_Cal += Math.Pow(Frecuencia_Obsevada[i] - Freccuencia_Esperada, 2) / Freccuencia_Esperada;
            }
        }
        public double GetChi_Cuadrada_Cal()
        {
            DefineChi_Cuadrada_Cal();
            return Chi_Cuadrada_Cal;
        }
        public bool Approved()
        {
            DefineChi_Cuadrada_Cal();
            DefineChi_Cuadrada();

            return Chi_Cuadrada_Cal < Chi_Cuadrada; // Final condition
        }
    }


}
