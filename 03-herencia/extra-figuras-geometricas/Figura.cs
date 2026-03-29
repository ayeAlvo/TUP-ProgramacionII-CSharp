public abstract class Figura
{
    public string Nombre { get; set; }
    public string Color { get; set; }

    protected Figura(string nombre, string color)
    {
        Nombre = nombre;
        Color = color;
    }

    public abstract double Area();
    public abstract double Perimetro();

    public override string ToString()
    {
        return $"{Nombre} ({Color}) - Área: {Area():0.00}, Perímetro: {Perimetro():0.00}";
    }
}