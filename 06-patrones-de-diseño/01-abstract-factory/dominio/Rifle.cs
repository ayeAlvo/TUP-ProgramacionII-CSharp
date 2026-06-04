namespace AbstractFactory.Dominio;

public class Rifle : IArma
{
    public void Usar()
    {
        Console.WriteLine("El rifle dispara una ráfaga.");
    }
}