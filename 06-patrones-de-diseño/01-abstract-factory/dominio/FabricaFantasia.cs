namespace AbstractFactory.Dominio;

public class FabricaFantasia : IFabricaJuego
{
    public IPersonaje CrearPersonaje()
    {
        return new Guerrero();
    }

    public IArma CrearArma()
    {
        return new Espada();
    }
}