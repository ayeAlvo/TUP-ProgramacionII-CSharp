public abstract class CelularBase
{
    public double BateriaMax { get; } = 5.0;
    public double Bateria { get; protected set; }

    protected CelularBase()
    {
        Bateria = BateriaMax;
    }

    public abstract void Consumir(double duracionMin);

    public void Cargar()
    {
        Bateria = BateriaMax;
    }

    public bool Apagado => Bateria <= 0;
}