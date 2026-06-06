using FactoryMethod.Dominio;

// FabricaAnimal fabrica = new FabricaPerro();
FabricaAnimal fabrica = new FabricaGato();

IAnimal animal = fabrica.CrearAnimal();

animal.Hablar();