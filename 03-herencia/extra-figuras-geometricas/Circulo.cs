public class Circulo : Figura
{
    public double Radio { get; }

    public Circulo(string color, double radio)
        : base("Círculo", color)
    {
        Radio = radio;
    }

    public override double Area() => Math.PI * Radio * Radio;
    public override double Perimetro() => 2 * Math.PI * Radio;
}