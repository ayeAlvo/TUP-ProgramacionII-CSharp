namespace FactoryMethod.Dominio;

public class Gato : IAnimal
{
    public void Hablar()
    {
        Console.WriteLine("Miau!");
    }
}