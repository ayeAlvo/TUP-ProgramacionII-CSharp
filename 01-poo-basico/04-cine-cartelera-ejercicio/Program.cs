using System;

class Program
{
    static void Main()
    {
        Cine cine = new Cine();

        cine.SetPelicula("Interstellar");
        cine.SetHorario("20:30");

        Console.WriteLine(cine.ObtenerCartelera());
    }
}