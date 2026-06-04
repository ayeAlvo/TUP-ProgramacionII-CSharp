using Singleton.Dominio;

Configuracion config1 = Configuracion.ObtenerInstancia();
Configuracion config2 = Configuracion.ObtenerInstancia();

Console.WriteLine(config1.NombreSistema);

config1.NombreSistema = "Sistema Modificado";

Console.WriteLine(config2.NombreSistema);

if (config1 == config2)
{
    Console.WriteLine("Es la misma instancia.");
}