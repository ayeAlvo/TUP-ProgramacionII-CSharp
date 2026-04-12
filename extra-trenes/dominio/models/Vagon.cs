namespace Trenes.Dominio.Models;

public abstract class Vagon
{
    public int Numero { get; }

    protected Vagon(int numero)
    {
        Numero = numero;
    }

    // Peso máximo total del vagón (abstracto)
    public abstract int PesoMaximo { get; }

    public abstract string Tipo { get; }

    public abstract double Peso { get; }

    public override string ToString() => $"{Tipo} Nº {Numero}";
}