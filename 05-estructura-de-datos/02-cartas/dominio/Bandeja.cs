namespace Cartas.Dominio;

public class Bandeja : MyStack<Carta>
{
    public void Apilar(Carta carta)
    {
        Push(carta);
    }

    public Carta Sacar()
    {
        return Pop();
    }
}