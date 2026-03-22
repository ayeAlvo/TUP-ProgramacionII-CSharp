class Program
{
    static void Main()
    {
        Dron dron1 = new Dron("Vigilante-X");

        dron1.AsignarHerramienta(new SensorInfrarrojo());
        dron1.MostrarEstado();

        Dron dron2 = new Dron("Vigilante-electrico");

        dron2.AsignarHerramienta(new Taser());
        dron2.MostrarEstado();

        Dron dron3 = new Dron("Vigilante-robot");

        dron3.AsignarHerramienta(new BrazoRobotico());
        dron3.MostrarEstado();
    }
}