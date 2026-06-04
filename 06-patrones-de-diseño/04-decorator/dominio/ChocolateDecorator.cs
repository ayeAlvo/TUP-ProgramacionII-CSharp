namespace Decorator.Dominio;

public class ChocolateDecorator : DecoradorCafe
{
    public ChocolateDecorator(ICafe cafe) : base(cafe)
    {
    }

    public override string Descripcion()
    {
        return cafe.Descripcion() + " + chocolate";
    }

    public override double Costo()
    {
        return cafe.Costo() + 70;
    }
}