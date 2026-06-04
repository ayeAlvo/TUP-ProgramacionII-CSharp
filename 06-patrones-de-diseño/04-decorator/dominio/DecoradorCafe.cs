namespace Decorator.Dominio;

public abstract class DecoradorCafe : ICafe
{
    protected ICafe cafe;

    public DecoradorCafe(ICafe cafe)
    {
        this.cafe = cafe;
    }

    public abstract string Descripcion();

    public abstract double Costo();
}