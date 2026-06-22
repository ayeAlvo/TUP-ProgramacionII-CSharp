namespace SoporteTecnico.Dominio;

public class SoporteNivel3 : Soporte
{
    protected override bool PuedeResolver(Solicitud solicitud)
    {
        int complejidad = solicitud.GetComplejidad();
        string categoria = solicitud.GetCategoria();

        bool complejidadValida = complejidad <= 5;

        bool categoriaValida = categoria == "Infraestructura";

        return complejidadValida && categoriaValida;
    }

    protected override void Resolver(Solicitud solicitud)
    {
        Console.WriteLine("Soluciono: " + solicitud.GetCategoria());
    }
}