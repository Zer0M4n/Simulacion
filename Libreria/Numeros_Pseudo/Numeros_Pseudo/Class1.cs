using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_Pseudo
{
    public class Num_Pseudo
    {
        private int Constante_Multiplicativa = 0;
        private int Semilla = 0;
        private int Constante_Aditiva = 0;
        private int Modulo = 0;
        private int N = 0; //Numeros totales que queremos generar
        private float semilla_auxiliar = 0;
        private float Auxiliar; //Es el enesimo mas 1 numero 

        //Constructor de la clase
        public Num_Pseudo(int Constante_Multiplicativa,
        int Semilla,
        int Constante_Aditiva,
        int Modulo,
        int N)
        {
            this.Constante_Multiplicativa = Constante_Multiplicativa;
            this.Semilla = Semilla;
            this.Constante_Aditiva = Constante_Aditiva;
            this.Modulo = Modulo;
            this.N = N;
        }

        public List<float> Generador()
        {
            semilla_auxiliar = Semilla;
            List<float> Numeros_pseudoaletorios = new List<float>(N);

            for (int i = 0; i < N; i++)
            {
                Auxiliar = (Constante_Multiplicativa * semilla_auxiliar + Constante_Aditiva) % Modulo;
                semilla_auxiliar = Auxiliar;
                Numeros_pseudoaletorios.Add(Auxiliar / 100);
            }

            return Numeros_pseudoaletorios;
        }
    }
}
