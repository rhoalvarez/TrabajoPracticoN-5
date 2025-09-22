using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una cadena de caracteres: ");
        string texto = Console.ReadLine().ToLower(); // pasamos a minúsculas

        int contadorVocales = 0;

        foreach (char c in texto)
        {
            if ("aeiou".Contains(c))
            {
                contadorVocales++;
            }
        }

        Console.WriteLine($"La cantidad de vocales en la cadena es: {contadorVocales}");
    }
}
