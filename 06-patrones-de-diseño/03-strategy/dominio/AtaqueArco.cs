namespace Strategy.Dominio;

public class AtaqueArco : IAtaque
{
    public void Atacar()
    {
        Console.WriteLine("Ataque con arco.");
    }
}