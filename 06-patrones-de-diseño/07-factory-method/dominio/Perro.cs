namespace FactoryMethod.Dominio;

public class Perro : IAnimal
{
    public void Hablar()
    {
        Console.WriteLine("Guau!");
    }
}