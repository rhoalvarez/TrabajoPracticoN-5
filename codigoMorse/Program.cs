using System;
using System.Collections.Generic;

class Program
{
    // Diccionario Morse: 0 = corta, 1 = larga
    static Dictionary<string, char> morse = new Dictionary<string, char>()
    {
        {"01", 'A'}, {"1000", 'B'}, {"1010", 'C'}, {"100", 'D'}, {"0", 'E'},
        {"0010", 'F'}, {"110", 'G'}, {"0000", 'H'}, {"00", 'I'}, {"0111", 'J'},
        {"101", 'K'}, {"0100", 'L'}, {"11", 'M'}, {"10", 'N'}, {"111", 'O'},
        {"0110", 'P'}, {"1101", 'Q'}, {"010", 'R'}, {"000", 'S'}, {"1", 'T'},
        {"001", 'U'}, {"0001", 'V'}, {"011", 'W'}, {"1001", 'X'}, {"1011", 'Y'},
        {"1100", 'Z'}
    };

    static void Main()
    {
        string mensajeFinal = "";

        while (true)
        {
            Console.Write("Ingrese trama Morse (X inicio, / fin) o X/ para terminar: ");
            string trama = Console.ReadLine();

            if (trama == "X/")
                break; // fin de la transmisión

            if (!trama.ToUpper().StartsWith("X") || !trama.EndsWith("/"))
            {
                Console.WriteLine("Trama inválida. Debe comenzar con X y terminar con /");
                continue;
            }


            string codigo = trama.Substring(1, trama.Length - 2); // quitar X y /

            string letraActual = "";
            foreach (char c in codigo)
            {
                letraActual += c;

                if (morse.ContainsKey(letraActual))
                {
                    mensajeFinal += morse[letraActual];
                    letraActual = ""; // reiniciar para la siguiente letra
                }
            }

            mensajeFinal += ' '; // separar palabras
        }

        Console.WriteLine("\nMensaje recibido: " + mensajeFinal);
    }
}
