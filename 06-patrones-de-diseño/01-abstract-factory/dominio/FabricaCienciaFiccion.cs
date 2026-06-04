namespace AbstractFactory.Dominio;

public class FabricaCienciaFiccion : IFabricaJuego
{
    public IPersonaje CrearPersonaje()
    {
        return new Soldado();
    }

    public IArma CrearArma()
    {
        return new Rifle();
    }
}