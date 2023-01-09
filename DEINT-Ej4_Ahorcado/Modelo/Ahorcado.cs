using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Ej4_Ahorcado.Modelo
{
    public class Ahorcado
    {
        public IEnumerable<char> letras { get; set; } = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        public List<string> lista { get; set; }
        public string ganador { get; set; }

        public Ahorcado()
        {
            lista = new List<string>() { "coche", "perro", "gato", "casa", "plato" };
            ganador = getRnd();
        }

        public string getRnd()
        {
            lista.Sort();
            return lista.First();
        }

        public List<int> comprobarGanador(char palabra)
        {

            if (ganador.Contains(palabra))
            {

                List<int> pos = new List<int>();

                for (int i = 0; i < ganador.Length; i++)
                {
                    if (ganador[i].Equals(palabra))
                    {
                        pos.Add(i);
                    }
                }

                return pos;

            }

            return null;
        }

    }
}
