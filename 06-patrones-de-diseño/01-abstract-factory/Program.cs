using AbstractFactory.Dominio;

// IFabricaJuego fabrica = new FabricaFantasia();

// IPersonaje personaje = fabrica.CrearPersonaje();
// IArma arma = fabrica.CrearArma();

// personaje.Atacar();
// arma.Usar();

IFabricaJuego fabrica = new FabricaCienciaFiccion();

IPersonaje personaje = fabrica.CrearPersonaje();
IArma arma = fabrica.CrearArma();

personaje.Atacar();
arma.Usar();