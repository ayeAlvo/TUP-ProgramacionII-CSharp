namespace Strategy.Dominio;

public class AtaqueMagia : IAtaque
{
    public void Atacar()
    {
        Console.WriteLine("Ataque mágico.");
    }
}