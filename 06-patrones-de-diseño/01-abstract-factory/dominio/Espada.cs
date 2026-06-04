namespace AbstractFactory.Dominio;

public class Espada : IArma
{
    public void Usar()
    {
        Console.WriteLine("La espada corta al enemigo.");
    }
}