using System;

class Program
{
    static void Main()
    {
        Persona persona = new Persona();
        persona.Nombre = "Juan";
        persona.Apellido = "Pérez";
        Console.WriteLine("Nombre: " + persona.Nombre);
        Console.WriteLine("Apellido: " + persona.Apellido);
    }
}