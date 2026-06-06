namespace FactoryMethod.Dominio;

public class FabricaPerro : FabricaAnimal
{
    public override IAnimal CrearAnimal()
    {
        return new Perro();
    }
}