namespace Cartas.Dominio;

public class Recepcion
{
    private Bandeja bandeja;

    public Recepcion()
    {
        bandeja = new Bandeja();
    }

    public void RecibirCarta(Carta carta)
    {
        bandeja.Apilar(carta);
    }

    public void DespacharPorHora(int hora)
    {
        if (bandeja.IsEmpty())
        {
            Console.WriteLine("No hay cartas para enviar.");
            return;
        }

        int cantidadAEnviar = CalcularCantidadAEnviar(hora);

        Console.WriteLine("Hora " + hora + ": se despachan " + cantidadAEnviar + " carta/s.");

        for (int i = 0; i < cantidadAEnviar && !bandeja.IsEmpty(); i++)
        {
            Carta carta = bandeja.Sacar();
            Console.WriteLine("Carta enviada a: " + carta.Destinatario);
        }

        Console.WriteLine("Cartas restantes en bandeja: " + bandeja.Count());
    }

    private int CalcularCantidadAEnviar(int hora)
    {
        int cantidadActual = bandeja.Count();

        if (hora == 14)
        {
            return Math.Min(10, cantidadActual);
        }

        if (hora == 15)
        {
            if (cantidadActual >= 20)
            {
                return cantidadActual / 2;
            }

            return Math.Min(5, cantidadActual);
        }

        if (hora == 16)
        {
            if (cantidadActual <= 5)
            {
                return 0;
            }

            return cantidadActual - 5;
        }

        if (hora == 17)
        {
            return cantidadActual;
        }

        return Math.Min(5, cantidadActual);
    }
}