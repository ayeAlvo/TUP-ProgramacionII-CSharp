class Program
{
    static void Main()
    {
        List<Figura> figuras = new List<Figura>
        {
            new Triangulo("Rojo", 3, 4, 5, 6),
            new Cuadrado("Azul", 5),
            new Circulo("Verde", 2)
        };

        foreach (var f in figuras)
        {
            Console.WriteLine(f.ToString());
        }
    }
}
