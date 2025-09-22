using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una frase: ");
        string frase = Console.ReadLine();

        Console.Write("Ingrese una vocal para poner en mayúscula: ");
        char vocal = char.ToLower(Console.ReadKey().KeyChar); // capturamos la vocal
        Console.WriteLine();

        string fraseModificada = "";

        foreach (char c in frase)
        {
            if (char.ToLower(c) == vocal)
                fraseModificada += char.ToUpper(c); // poner en mayúscula
            else
                fraseModificada += c; // mantener igual
        }

        Console.WriteLine($"Frase modificada: {fraseModificada}");
    }
}
