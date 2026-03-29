public class Triangulo : Figura
{
    public double BaseTri { get; }
    public double Altura { get; }
    public double Lado2 { get; }
    public double Lado3 { get; }

    public Triangulo(string color, double baseTri, double altura, double lado2, double lado3)
        : base("Triángulo", color)
    {
        BaseTri = baseTri;
        Altura = altura;
        Lado2 = lado2;
        Lado3 = lado3;
    }

    public override double Area() => (BaseTri * Altura) / 2;
    public override double Perimetro() => BaseTri + Lado2 + Lado3;
}