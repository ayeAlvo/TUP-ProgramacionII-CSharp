namespace Trenes.Dominio.Models;

public class Locomotora
{
    // ---- Tus atributos ----
    public string Modelo { get; }
    public int PotenciaHP { get; }

    // ---- Atributos del ejercicio ----
    public int Peso { get; }
    public int PesoMaximoArrastre { get; }
    public int VelocidadMaxima { get; }

    // Arrastre útil = lo que puede arrastrar - su propio peso
    public int ArrastreUtil => PesoMaximoArrastre - Peso;

    public Locomotora(
        string modelo,
        int potenciaHP,
        int peso,
        int pesoMaximoArrastre,
        int velocidadMaxima
    )
    {
        Modelo = modelo;
        PotenciaHP = potenciaHP;

        Peso = peso;
        PesoMaximoArrastre = pesoMaximoArrastre;
        VelocidadMaxima = velocidadMaxima;
    }

    public override string ToString()
        => $"Locomotora {Modelo} - {PotenciaHP} HP - Peso {Peso} kg - Arrastre útil {ArrastreUtil} kg";
}