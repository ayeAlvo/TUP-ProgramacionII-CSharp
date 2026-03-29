class Program
{
    static void Main()
    {
        var juliana = new Persona("Juliana", new MotorolaG5());
        var catalina = new Persona("Catalina", new Iphone());

        juliana.Llamar(catalina, 10); 
        MostrarEstado(juliana, catalina);

        catalina.Llamar(juliana, 30);
        MostrarEstado(juliana, catalina);

        juliana.Celular.Cargar();
        MostrarEstado(juliana, catalina);
    }

    static void MostrarEstado(Persona p1, Persona p2)
    {
        Console.WriteLine($"{p1.Nombre} batería: {p1.Celular.Bateria:0.00} - apagado: {p1.Celular.Apagado}");
        Console.WriteLine($"{p2.Nombre} batería: {p2.Celular.Bateria:0.00} - apagado: {p2.Celular.Apagado}");
        Console.WriteLine();
    }
}
