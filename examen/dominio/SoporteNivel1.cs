namespace SoporteTecnico.Dominio;

public class SoporteNivel1 : Soporte
{
    protected override bool PuedeResolver(Solicitud solicitud)
    {
        int complejidad = solicitud.GetComplejidad();
        string categoria = solicitud.GetCategoria();

        bool complejidadValida = complejidad <= 2;

        bool categoriaValida = categoria == "Cuenta" || categoria == "Acceso";

        return complejidadValida && categoriaValida;
    }

    protected override void Resolver(Solicitud solicitud)
    {
        Console.WriteLine("Soluciono: " + solicitud.GetCategoria());
    }
}