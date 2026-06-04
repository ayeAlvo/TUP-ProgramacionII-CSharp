namespace AbstractFactory.Dominio;

public class Guerrero : IPersonaje
{
    public void Atacar()
    {
        Console.WriteLine("El guerrero ataca cuerpo a cuerpo.");
    }
}