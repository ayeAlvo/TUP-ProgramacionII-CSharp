namespace FactoryMethod.Dominio;

public class FabricaGato : FabricaAnimal
{
    public override IAnimal CrearAnimal()
    {
        return new Gato();
    }
}