using System;

class Program
{
    static void Main()
    {
        Vehiculo auto = new Vehiculo();

        // Asignar valores solo a los atributos públicos
        auto.Marca = "Toyota";
        auto.Modelo = "Corolla";

        // auto.Patente = "ABC123";

        Console.WriteLine("Marca: " + auto.Marca);
        Console.WriteLine("Modelo: " + auto.Modelo);

        // La patente no se puede imprimir porque es privada
        Console.WriteLine("Patente: (inaccesible - atributo privado)");
    }
}