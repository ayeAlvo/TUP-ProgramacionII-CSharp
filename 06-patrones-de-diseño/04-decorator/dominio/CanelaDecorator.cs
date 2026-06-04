namespace Decorator.Dominio;

public class CanelaDecorator : DecoradorCafe
{
    public CanelaDecorator(ICafe cafe) : base(cafe)
    {
    }

    public override string Descripcion()
    {
        return cafe.Descripcion() + " + canela";
    }

    public override double Costo()
    {
        return cafe.Costo() + 30;
    }
}