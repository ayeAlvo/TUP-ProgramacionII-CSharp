namespace AbstractFactory.Dominio;

public interface IFabricaJuego
{
    IPersonaje CrearPersonaje();

    IArma CrearArma();
}