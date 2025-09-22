using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una frase: ");
        string frase = Console.ReadLine();

        // Convertir la frase a un arreglo de caracteres y luego invertirla
        char[] arr = frase.ToCharArray();
        Array.Reverse(arr);

        string fraseInvertida = new string(arr);

        Console.WriteLine($"Frase invertida: {fraseInvertida}");
    }
}
