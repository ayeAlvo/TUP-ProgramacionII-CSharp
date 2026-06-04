namespace AbstractFactory.Dominio;

public class Soldado : IPersonaje
{
    public void Atacar()
    {
        Console.WriteLine("El soldado dispara a distancia.");
    }
}