using System;

class Program
{
    static void Main()
    {
        // Crear un alumno
        Alumno alumno = new Alumno();

        Console.Write("Ingrese el apellido del alumno: ");
        alumno.Apellido = Console.ReadLine();

        Console.Write("Ingrese el nombre del alumno: ");
        alumno.Nombre = Console.ReadLine();

        Console.Write("Ingrese el DNI del alumno: ");
        alumno.DNI = Console.ReadLine();

        // Inscribir materias (máximo 3)
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"\nInscripción de la materia #{i + 1}:");

            Materia materia = new Materia();

            Console.Write("Ingrese el nombre de la materia: ");
            materia.NombreMateria = Console.ReadLine();

            Console.Write("Ingrese la modalidad: ");
            materia.Modalidad = Console.ReadLine();

            Console.Write("Ingrese el año: ");
            materia.Año = Console.ReadLine();

            alumno.Materias[i] = materia;

            Console.Write("¿Desea inscribir otra materia? (s/n): ");
            string opcion = Console.ReadLine().ToLower();
            if (opcion != "s") break;
        }

        // Mostrar información del alumno y materias inscritas
        Console.WriteLine("\n--- Información del Alumno ---");
        Console.WriteLine($"Apellido: {alumno.Apellido}");
        Console.WriteLine($"Nombre: {alumno.Nombre}");
        Console.WriteLine($"DNI: {alumno.DNI}");
        Console.WriteLine("Materias inscritas:");

        for (int i = 0; i < alumno.Materias.Length; i++)
        {
            if (alumno.Materias[i] != null)
            {
                Materia m = alumno.Materias[i];
                Console.WriteLine($"- {m.NombreMateria} de la Modalidad {m.Modalidad} del {m.Año} año");
            }
        }
    }
}

// Clase Materia
class Materia
{
    public string NombreMateria { get; set; }
    public string Modalidad { get; set; }
    public string Año { get; set; }
}

// Clase Alumno
class Alumno
{
    public string Apellido { get; set; }
    public string Nombre { get; set; }
    public string DNI { get; set; }

    // Máximo 3 materias
    public Materia[] Materias { get; set; } = new Materia[3];
}
