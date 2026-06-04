namespace Decorator.Dominio;

public class LecheDecorator : DecoradorCafe
{
    public LecheDecorator(ICafe cafe) : base(cafe)
    {
    }

    public override string Descripcion()
    {
        return cafe.Descripcion() + " + leche";
    }

    public override double Costo()
    {
        return cafe.Costo() + 50;
    }
}