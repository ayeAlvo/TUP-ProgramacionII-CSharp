namespace Strategy.Dominio;

public class Enemigo
{
    private IAtaque ataque;

    public Enemigo(IAtaque ataque)
    {
        this.ataque = ataque;
    }

    public void Atacar()
    {
        ataque.Atacar();
    }

    public void CambiarAtaque(IAtaque nuevoAtaque)
    {
        ataque = nuevoAtaque;
    }
}