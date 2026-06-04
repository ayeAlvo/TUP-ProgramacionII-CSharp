namespace Strategy.Dominio;

public class AtaqueEspada : IAtaque
{
    public void Atacar()
    {
        Console.WriteLine("Ataque con espada.");
    }
}