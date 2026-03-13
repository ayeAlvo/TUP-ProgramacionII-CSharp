using System;

class Program
{
    static void Main()
    {
        Cine cine1 = new Cine();
        cine1.SetPelicula("Inception");
        cine1.SetHorario("19:00");

        Cine cine2 = new Cine();
        cine2.SetPelicula("Arrival");
        cine2.SetHorario("21:30");

        Console.WriteLine("\nCartelera Cine 1:");
        Console.WriteLine("Pelicula: " + cine1.GetPelicula());
        Console.WriteLine("Horario: " + cine1.GetHorario());

        Console.WriteLine("\nCartelera Cine 2:");
        Console.WriteLine("Pelicula: " + cine2.GetPelicula());
        Console.WriteLine("Horario: " + cine2.GetHorario());

        cine1.SetPelicula("Interstellar");
        cine1.SetHorario("22:00");

        Console.WriteLine("\nDespués de modificar Cine 1:");

        Console.WriteLine("Cartelera Cine 1 modificado:");
        Console.WriteLine("Pelicula: " + cine1.GetPelicula());
        Console.WriteLine("Horario: " + cine1.GetHorario());

        Console.WriteLine("\nCartelera Cine 2 (queda igual):");
        Console.WriteLine("Pelicula: " + cine2.GetPelicula());
        Console.WriteLine("Horario: " + cine2.GetHorario() + "\n");
    }
}