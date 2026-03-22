using FlotaNaval.Dominio;

var acorazado = new Acorazado("Titan")
{
    Blindaje = 90,
    PotenciaFuego = 120,
    Flotabilidad = 80,
    Solidez = 85,
    Estabilidad = 70,
    VelocidadCrucero = 40
};

var destructor = new Destructor("Destructor-X")
{
    PotenciaFuego = 110,
    Maniobrabilidad = 95,
    Flotabilidad = 75,
    Solidez = 80,
    Estabilidad = 88,
    VelocidadCrucero = 45
};

var hospital = new BarcoHospital("Sibelancia")
{
    CapacidadPacientes = 75,
    Flotabilidad = 95,
    Estabilidad = 99,
    Solidez = 70,
    VelocidadCrucero = 30
};

var lancha1 = new LanchaMedica("La Gaucha")
{
    MotorFueraDeBorda = true,
    GruaCapacidad = 300,
    Flotabilidad = 90,
    Estabilidad = 40,
    VelocidadCrucero = 60
};

var lancha2 = new LanchaMedica("El Gaucho")
{
    MotorFueraDeBorda = true,
    GruaCapacidad = 300,
    Flotabilidad = 90,
    Estabilidad = 40,
    VelocidadCrucero = 60
};

acorazado.MostrarDatos();
destructor.MostrarDatos();
hospital.MostrarDatos();
lancha1.MostrarDatos();
lancha2.MostrarDatos();