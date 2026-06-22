namespace SoporteTecnico.Dominio;

public class SoporteNivel2 : Soporte
{
    protected override bool PuedeResolver(Solicitud solicitud)
    {
        int complejidad = solicitud.GetComplejidad();
        string categoria = solicitud.GetCategoria();

        bool complejidadValida = complejidad <= 4;
        bool categoriaValida = categoria == "Software";

        return complejidadValida && categoriaValida;
    }

    protected override void Resolver(Solicitud solicitud)
    {
        Console.WriteLine("Soluciono: " + solicitud.GetCategoria());
    }
}