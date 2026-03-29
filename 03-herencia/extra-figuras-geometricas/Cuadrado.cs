public class Cuadrado : Figura
{
    public double Lado { get; }

    public Cuadrado(string color, double lado)
        : base("Cuadrado", color)
    {
        Lado = lado;
    }

    public override double Area() => Lado * Lado;
    public override double Perimetro() => Lado * 4;
}