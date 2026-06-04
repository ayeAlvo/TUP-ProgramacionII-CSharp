namespace Decorator.Dominio;

public class Cafe : ICafe
{
    public string Descripcion()
    {
        return "Cafe";
    }

    public double Costo()
    {
        return 100;
    }
}