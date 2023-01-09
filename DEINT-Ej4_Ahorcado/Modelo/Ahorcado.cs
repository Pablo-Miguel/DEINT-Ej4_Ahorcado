using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Ej4_Ahorcado.Modelo
{
    public class Ahorcado
    {
        Random rnd = new Random();
        const int INTENTOS = 6;

        public IEnumerable<char> letras { get; set; } = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        public List<string> lista { get; set; }
        public string ganador { get; set; }
        public int error { get; set; }
        public bool AreButtonsEnabled { get; set; }

        public Ahorcado()
        {
            lista = new List<string>() { "coche", "perro", "gato", "casa", "plato" };
            ganador = getRnd();
            error = 0;
            AreButtonsEnabled = true;
        }

        public string getRnd()
        {
            return lista.OrderBy(a => rnd.Next()).ToList().First();
        }

        public List<int> comprobarPosicionGanador(char letra)
        {

            if (ganador.Contains(letra))
            {

                List<int> pos = new List<int>();

                for (int i = 0; i < ganador.Length; i++)
                {
                    if (ganador[i].Equals(letra))
                    {
                        pos.Add(i);
                    }
                }

                return pos;

            }

            error++;
            return null;
        }

        public int comprobarGanar(string palabra) {
            if (ganador.Equals(palabra))
            {
                return 1;
            }
            else if (error == INTENTOS) {
                return -1;
            }

            return 0;

        }

    }
}
